using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyslogServer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            checkedListBox1.DataSource = Enum.GetValues(typeof(FacilityType));
            checkedListBox2.DataSource = Enum.GetValues(typeof(SeverityType));
        }

        public IEnumerable<FacilityType> Facilities
        {
            get
            {
                return checkedListBox1.CheckedItems.OfType<FacilityType>();
            }
            set
            {
                foreach (var item in value)
                    checkedListBox1.SetItemChecked(checkedListBox1.Items.IndexOf(item), true);
            }
        }

        public IEnumerable<SeverityType> Severities
        {
            get
            {
                return checkedListBox2.CheckedItems.OfType<SeverityType>();
            }
            set
            {
                foreach (var item in value)
                    checkedListBox2.SetItemChecked(checkedListBox2.Items.IndexOf(item), true);
            }
        }

        public IEnumerable<String> Hosts
        {
            get
            {
                return textBox1.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            }
            set
            {
                textBox1.Text = String.Join(Environment.NewLine, value);
            }
        }

        public IEnumerable<String> Contents
        {
            get
            {
                return textBox2.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            }
            set
            {
                textBox2.Text = String.Join(Environment.NewLine, value);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
