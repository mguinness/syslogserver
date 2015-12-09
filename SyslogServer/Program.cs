using SyslogServer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyslogServer
{
    static class Program
    {
        public delegate void OnMessageReceived(Message message);
        public static event OnMessageReceived MessageReceived;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                var udp = new UdpClient(Settings.Default.UdpPort);
                UdpListener(udp);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

                udp.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private async static void UdpListener(UdpClient udp)
        {
            UdpReceiveResult receiveResult;
            Regex _re = new Regex(@"^
(?<PRI>\<\d{1,3}\>)?
(?<HDR>
  Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec\s
  [0-3][0-9]\s
  [0-9]{2}\:[0-9]{2}\:[0-9]{2}\s
  [^ ]+?\s
)?
(?<MSG>.+)
", RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline | RegexOptions.Compiled);

            while (true)
            {
                try
                {
                    receiveResult = await udp.ReceiveAsync();
                }
                catch (ObjectDisposedException)
                {
                    return;
                }

                Match m = _re.Match(Encoding.ASCII.GetString(receiveResult.Buffer));
                if (m.Success)
                {
                    Message msg = new Message();

                    if (m.Groups["PRI"].Success)
                    {
                        string pri = m.Groups["PRI"].Value;
                        int priority = Int32.Parse(pri.Substring(1, pri.Length - 2));
                        msg.Facility = (FacilityType)Math.Floor((double)priority / 8);
                        msg.Severity = (SeverityType)(priority % 8);
                    }
                    else
                    {
                        msg.Facility = FacilityType.User;
                        msg.Severity = SeverityType.Notice;
                    }

                    if (m.Groups["HDR"].Success)
                    {
                        string hdr = m.Groups["HDR"].Value.TrimEnd();
                        int idx = hdr.LastIndexOf(' ');
                        msg.Datestamp = DateTime.ParseExact(hdr.Substring(0, idx), "MMM dd HH:mm:ss", null);
                        msg.Hostname = hdr.Substring(idx + 1);
                    }
                    else
                    {
                        msg.Datestamp = DateTime.Now;

                        try
                        {
                            IPHostEntry he = Dns.GetHostEntry(receiveResult.RemoteEndPoint.Address);
                            msg.Hostname = he.HostName;
                        }
                        catch (SocketException)
                        {
                            msg.Hostname = receiveResult.RemoteEndPoint.Address.ToString();
                        }
                    }

                    msg.Content = m.Groups["MSG"].Value;
                    msg.RemoteIP = receiveResult.RemoteEndPoint.Address.ToString();
                    msg.LocalDate = DateTime.Now;

                    if (MessageReceived != null)
                        MessageReceived(msg);
                }
            }
        }
    }

    public enum FacilityType
    {
        Kern, User, Mail, Daemon, Auth, Syslog, LPR, News, UUCP, Cron, AuthPriv, FTP, NTP,
        Audit, Audit2, CRON2, Local0, Local1, Local2, Local3, Local4, Local5, Local6, Local7
    };

    public enum SeverityType { Emergency, Alert, Critical, Error, Warning, Notice, Informational, Debug };

    public class Message
    {
        public FacilityType Facility { get; set; }
        public SeverityType Severity { get; set; }
        public DateTime Datestamp { get; set; }
        public string Hostname { get; set; }
        public string Content { get; set; }
        public string RemoteIP{ get; set; }
        public DateTime LocalDate { get; set; }
    }

    public static class PredicateExtensions
    {
        public static Predicate<T> And<T>(this Predicate<T> original, Predicate<T> newPredicate)
        {
            return t => original(t) && newPredicate(t);
        }

        public static Predicate<T> Or<T>(this Predicate<T> original, Predicate<T> newPredicate)
        {
            return t => original(t) || newPredicate(t);
        }

        public static Predicate<T> Not<T>(this Predicate<T> original)
        {
            return t => !original(t);
        }
    }
}
