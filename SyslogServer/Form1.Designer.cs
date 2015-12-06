namespace SyslogServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label datestampLabel;
            System.Windows.Forms.Label hostnameLabel;
            System.Windows.Forms.Label sourceIPLabel;
            System.Windows.Forms.Label facilityLabel;
            System.Windows.Forms.Label severityLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.severityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.severityTextBox = new System.Windows.Forms.TextBox();
            this.facilityTextBox = new System.Windows.Forms.TextBox();
            this.sourceIPTextBox = new System.Windows.Forms.TextBox();
            this.hostnameTextBox = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            datestampLabel = new System.Windows.Forms.Label();
            hostnameLabel = new System.Windows.Forms.Label();
            sourceIPLabel = new System.Windows.Forms.Label();
            facilityLabel = new System.Windows.Forms.Label();
            severityLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datestampLabel
            // 
            datestampLabel.AutoSize = true;
            datestampLabel.Location = new System.Drawing.Point(180, 32);
            datestampLabel.Name = "datestampLabel";
            datestampLabel.Size = new System.Drawing.Size(61, 13);
            datestampLabel.TabIndex = 0;
            datestampLabel.Text = "Datestamp:";
            // 
            // hostnameLabel
            // 
            hostnameLabel.AutoSize = true;
            hostnameLabel.Location = new System.Drawing.Point(365, 31);
            hostnameLabel.Name = "hostnameLabel";
            hostnameLabel.Size = new System.Drawing.Size(58, 13);
            hostnameLabel.TabIndex = 2;
            hostnameLabel.Text = "Hostname:";
            // 
            // sourceIPLabel
            // 
            sourceIPLabel.AutoSize = true;
            sourceIPLabel.Location = new System.Drawing.Point(363, 57);
            sourceIPLabel.Name = "sourceIPLabel";
            sourceIPLabel.Size = new System.Drawing.Size(60, 13);
            sourceIPLabel.TabIndex = 4;
            sourceIPLabel.Text = "Remote IP:";
            // 
            // facilityLabel
            // 
            facilityLabel.AutoSize = true;
            facilityLabel.Location = new System.Drawing.Point(11, 31);
            facilityLabel.Name = "facilityLabel";
            facilityLabel.Size = new System.Drawing.Size(42, 13);
            facilityLabel.TabIndex = 6;
            facilityLabel.Text = "Facility:";
            // 
            // severityLabel
            // 
            severityLabel.AutoSize = true;
            severityLabel.Location = new System.Drawing.Point(5, 57);
            severityLabel.Name = "severityLabel";
            severityLabel.Size = new System.Drawing.Size(48, 13);
            severityLabel.TabIndex = 8;
            severityLabel.Text = "Severity:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(185, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 13);
            label1.TabIndex = 13;
            label1.Text = "Received:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facilityDataGridViewTextBoxColumn,
            this.severityDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.datestampDataGridViewTextBoxColumn,
            this.hostnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.messageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // facilityDataGridViewTextBoxColumn
            // 
            this.facilityDataGridViewTextBoxColumn.DataPropertyName = "Facility";
            this.facilityDataGridViewTextBoxColumn.HeaderText = "Facility";
            this.facilityDataGridViewTextBoxColumn.Name = "facilityDataGridViewTextBoxColumn";
            this.facilityDataGridViewTextBoxColumn.ReadOnly = true;
            this.facilityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // severityDataGridViewTextBoxColumn
            // 
            this.severityDataGridViewTextBoxColumn.DataPropertyName = "Severity";
            this.severityDataGridViewTextBoxColumn.HeaderText = "Severity";
            this.severityDataGridViewTextBoxColumn.Name = "severityDataGridViewTextBoxColumn";
            this.severityDataGridViewTextBoxColumn.ReadOnly = true;
            this.severityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ReadOnly = true;
            this.contentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // datestampDataGridViewTextBoxColumn
            // 
            this.datestampDataGridViewTextBoxColumn.DataPropertyName = "Datestamp";
            this.datestampDataGridViewTextBoxColumn.HeaderText = "Datestamp";
            this.datestampDataGridViewTextBoxColumn.Name = "datestampDataGridViewTextBoxColumn";
            this.datestampDataGridViewTextBoxColumn.ReadOnly = true;
            this.datestampDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.datestampDataGridViewTextBoxColumn.Width = 125;
            // 
            // hostnameDataGridViewTextBoxColumn
            // 
            this.hostnameDataGridViewTextBoxColumn.DataPropertyName = "Hostname";
            this.hostnameDataGridViewTextBoxColumn.HeaderText = "Hostname";
            this.hostnameDataGridViewTextBoxColumn.Name = "hostnameDataGridViewTextBoxColumn";
            this.hostnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.hostnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataSource = typeof(SyslogServer.Message);
            this.messageBindingSource.Sort = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.contentTextBox);
            this.groupBox1.Controls.Add(severityLabel);
            this.groupBox1.Controls.Add(this.severityTextBox);
            this.groupBox1.Controls.Add(facilityLabel);
            this.groupBox1.Controls.Add(this.facilityTextBox);
            this.groupBox1.Controls.Add(sourceIPLabel);
            this.groupBox1.Controls.Add(this.sourceIPTextBox);
            this.groupBox1.Controls.Add(hostnameLabel);
            this.groupBox1.Controls.Add(this.hostnameTextBox);
            this.groupBox1.Controls.Add(datestampLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Detail";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageBindingSource, "LocalDate", true));
            this.textBox2.Location = new System.Drawing.Point(247, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageBindingSource, "Datestamp", true));
            this.textBox1.Location = new System.Drawing.Point(247, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageBindingSource, "Content", true));
            this.contentTextBox.Location = new System.Drawing.Point(6, 91);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ReadOnly = true;
            this.contentTextBox.Size = new System.Drawing.Size(748, 147);
            this.contentTextBox.TabIndex = 11;
            // 
            // severityTextBox
            // 
            this.severityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageBindingSource, "Severity", true));
            this.severityTextBox.Location = new System.Drawing.Point(59, 54);
            this.severityTextBox.Name = "severityTextBox";
            this.severityTextBox.ReadOnly = true;
            this.severityTextBox.Size = new System.Drawing.Size(100, 20);
            this.severityTextBox.TabIndex = 9;
            // 
            // facilityTextBox
            // 
            this.facilityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageBindingSource, "Facility", true));
            this.facilityTextBox.Location = new System.Drawing.Point(59, 28);
            this.facilityTextBox.Name = "facilityTextBox";
            this.facilityTextBox.ReadOnly = true;
            this.facilityTextBox.Size = new System.Drawing.Size(100, 20);
            this.facilityTextBox.TabIndex = 7;
            // 
            // sourceIPTextBox
            // 
            this.sourceIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageBindingSource, "RemoteIP", true));
            this.sourceIPTextBox.Location = new System.Drawing.Point(429, 54);
            this.sourceIPTextBox.Name = "sourceIPTextBox";
            this.sourceIPTextBox.ReadOnly = true;
            this.sourceIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.sourceIPTextBox.TabIndex = 5;
            // 
            // hostnameTextBox
            // 
            this.hostnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageBindingSource, "Hostname", true));
            this.hostnameTextBox.Location = new System.Drawing.Point(429, 28);
            this.hostnameTextBox.Name = "hostnameTextBox";
            this.hostnameTextBox.ReadOnly = true;
            this.hostnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.hostnameTextBox.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(575, 500);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Syslog Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource messageBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn severityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.TextBox severityTextBox;
        private System.Windows.Forms.TextBox facilityTextBox;
        private System.Windows.Forms.TextBox sourceIPTextBox;
        private System.Windows.Forms.TextBox hostnameTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

