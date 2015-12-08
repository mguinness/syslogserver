using Equin.ApplicationFramework;
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
        IEnumerable<FacilityType> facilities = Enumerable.Empty<FacilityType>();
        IEnumerable<SeverityType> severities = Enumerable.Empty<SeverityType>();
        IEnumerable<String> hosts = Enumerable.Empty<String>();
        IEnumerable<String> contents = Enumerable.Empty<String>();

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.Text = this.Text;

            messageBindingSource.Sort = "LocalDate DESC";
            messageBindingSource.DataSource = new BindingListView<Message>(messages);
            Program.MessageReceived += Form1_OnMessageReceived;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && MessageBox.Show(
                "Closing application will stop new messages from being logged and existing messages will also be lost.", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
            else
                notifyIcon1.Visible = false;
        }

        private void Form1_OnMessageReceived(Message message)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                var view = messageBindingSource.DataSource as BindingListView<Message>;
                view.DataSource.Add(message);
                view.Refresh();
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

        private void setFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form2 form = new Form2())
            {
                form.Facilities = facilities;
                form.Severities = severities;
                form.Hosts = hosts;
                form.Contents = contents;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    facilities = form.Facilities;
                    severities = form.Severities;
                    hosts = form.Hosts;
                    contents = form.Contents;

                    if (facilities.Any() || severities.Any() || hosts.Any() || contents.Any())
                        ApplyFilter(messageBindingSource.DataSource as BindingListView<Message>);
                }
            }
        }


        private void resetFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm Reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                facilities = Enumerable.Empty<FacilityType>();
                severities = Enumerable.Empty<SeverityType>();
                hosts = Enumerable.Empty<String>();
                contents = Enumerable.Empty<String>();

                messageBindingSource.RemoveFilter();
            }
        }

        private void copyLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                sb.Append(dataGridView1.Columns[i].HeaderText + (i < (dataGridView1.Columns.Count - 1) ? "\t" : Environment.NewLine));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                    sb.Append(row.Cells[i].Value + (i < (row.Cells.Count - 1) ? "\t" : Environment.NewLine));
            }

            Clipboard.SetText(sb.ToString());
        }

        private void flushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm Flush", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var view = messageBindingSource.DataSource as BindingListView<Message>;
                view.DataSource.Clear();
                view.Refresh();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox1 about = new AboutBox1())
            {
                about.ShowDialog();
            }
        }

        private void messageBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (messageBindingSource.DataSource is BindingListView<Message>)
            {
                var view = messageBindingSource.DataSource as BindingListView<Message>;
                if (view.Filter is IncludeAllItemFilter<Message>)
                    this.Text = "Syslog Server";
                else if (view.Filter is PredicateItemFilter<Message>)
                    this.Text = String.Format("Syslog Server ({0}/{1} entries)", ((BindingSource)sender).Count, messages.Count);
            }
        }

        internal void ApplyFilter(BindingListView<Message> view)
        {
            Predicate<Message> predicate = msg => true;

            if (facilities.Any())
            {
                Predicate<Message> predicateFacility = msg => false;
                foreach (FacilityType item in facilities)
                    predicateFacility = predicateFacility.Or(msg => msg.Facility == item);
                predicate = predicate.And(predicateFacility);
            }

            if (severities.Any())
            {
                Predicate<Message> predicateSeverity = msg => false;
                foreach (SeverityType item in severities)
                    predicateSeverity = predicateSeverity.Or(msg => msg.Severity == item);
                predicate = predicate.And(predicateSeverity);
            }

            if (contents.Any())
            {
                Predicate<Message> predicateContents = msg => false;
                foreach (string item in contents)
                    predicateContents = predicateContents.Or(msg => msg.Content.ToLower().Contains(item.ToLower()));
                predicate = predicate.And(predicateContents);
            }

            if (hosts.Any())
            {
                Predicate<Message> predicateHosts = msg => false;
                foreach (string item in hosts)
                    predicateHosts = predicateHosts.Or(msg => msg.Hostname.ToLower().Contains(item.ToLower()));
                predicate = predicate.And(predicateHosts);
            }

            view.ApplyFilter(predicate);
        }
    }
}
