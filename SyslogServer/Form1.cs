using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyslogServer
{
    public partial class Form1 : Form
    {
        List<Message> messages = new List<Message>();

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.Text = this.Text;

            messageBindingSource.DataSource = messages;
            Program.MessageReceived += Form1_OnMessageReceived;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && MessageBox.Show("Closing application will stop messages from being logged.", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_OnMessageReceived(Message message)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                messages.Add(message);
                messages.Sort((x, y) => y.LocalDate.CompareTo(x.LocalDate));
                messageBindingSource.ResetBindings(false);
            }));
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messages.Clear();
            messageBindingSource.ResetBindings(false);
        }
    }
}
