namespace VanityAddress
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.chkRequireAll = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbThread = new System.Windows.Forms.ComboBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblRequireAll = new System.Windows.Forms.Label();
            this.dgAccounts = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnInfo = new System.Windows.Forms.ToolStripSplitButton();
            this.btnGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTipBox = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlEndsWith = new System.Windows.Forms.Panel();
            this.txtEndsWith = new System.Windows.Forms.TextBox();
            this.lblEndsWith = new System.Windows.Forms.Label();
            this.pnlContains = new System.Windows.Forms.Panel();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.lblContains = new System.Windows.Forms.Label();
            this.pnlStartsWith = new System.Windows.Forms.Panel();
            this.txtStartsWith = new System.Windows.Forms.TextBox();
            this.lblStartsWith = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlEndsWith.SuspendLayout();
            this.pnlContains.SuspendLayout();
            this.pnlStartsWith.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.chkRequireAll);
            this.pnlTop.Controls.Add(this.btnStart);
            this.pnlTop.Controls.Add(this.cmbThread);
            this.pnlTop.Controls.Add(this.btnClean);
            this.pnlTop.Controls.Add(this.lblRequireAll);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(697, 39);
            this.pnlTop.TabIndex = 4;
            // 
            // chkRequireAll
            // 
            this.chkRequireAll.AutoSize = true;
            this.chkRequireAll.Location = new System.Drawing.Point(119, 12);
            this.chkRequireAll.Name = "chkRequireAll";
            this.chkRequireAll.Size = new System.Drawing.Size(15, 14);
            this.chkRequireAll.TabIndex = 8;
            this.chkRequireAll.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DimGray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(246, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 29);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbThread
            // 
            this.cmbThread.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbThread.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbThread.FormattingEnabled = true;
            this.cmbThread.Location = new System.Drawing.Point(3, 5);
            this.cmbThread.Name = "cmbThread";
            this.cmbThread.Size = new System.Drawing.Size(106, 28);
            this.cmbThread.TabIndex = 6;
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClean.BackColor = System.Drawing.Color.DimGray;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(618, 5);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 29);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblRequireAll
            // 
            this.lblRequireAll.ForeColor = System.Drawing.Color.White;
            this.lblRequireAll.Location = new System.Drawing.Point(131, 4);
            this.lblRequireAll.Name = "lblRequireAll";
            this.lblRequireAll.Size = new System.Drawing.Size(112, 31);
            this.lblRequireAll.TabIndex = 9;
            this.lblRequireAll.Text = "Require All Criteria (In Same Address)";
            this.lblRequireAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgAccounts
            // 
            this.dgAccounts.AllowUserToAddRows = false;
            this.dgAccounts.AllowUserToDeleteRows = false;
            this.dgAccounts.AllowUserToResizeRows = false;
            this.dgAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAccounts.BackgroundColor = System.Drawing.Color.Black;
            this.dgAccounts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccounts.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAccounts.EnableHeadersVisualStyles = false;
            this.dgAccounts.GridColor = System.Drawing.Color.Black;
            this.dgAccounts.Location = new System.Drawing.Point(109, 39);
            this.dgAccounts.Name = "dgAccounts";
            this.dgAccounts.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgAccounts.RowHeadersVisible = false;
            this.dgAccounts.RowTemplate.Height = 25;
            this.dgAccounts.Size = new System.Drawing.Size(588, 450);
            this.dgAccounts.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo,
            this.btnInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(697, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(627, 17);
            this.lblInfo.Spring = true;
            this.lblInfo.Text = "Total Generated : 0   |   Per Second : 0   |   Found : 0";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.White;
            this.btnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInfo.DropDownButtonWidth = 20;
            this.btnInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGitHub,
            this.btnTipBox});
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.ForeColor = System.Drawing.Color.Red;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(55, 20);
            this.btnInfo.Text = "Info";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGitHub
            // 
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(117, 22);
            this.btnGitHub.Text = "GitHub ";
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // btnTipBox
            // 
            this.btnTipBox.Name = "btnTipBox";
            this.btnTipBox.Size = new System.Drawing.Size(117, 22);
            this.btnTipBox.Text = "Tip Box";
            this.btnTipBox.Click += new System.EventHandler(this.btnTipBox_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(109, 39);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlEndsWith);
            this.pnlLeft.Controls.Add(this.pnlContains);
            this.pnlLeft.Controls.Add(this.pnlStartsWith);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 39);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(109, 450);
            this.pnlLeft.TabIndex = 15;
            // 
            // pnlEndsWith
            // 
            this.pnlEndsWith.Controls.Add(this.txtEndsWith);
            this.pnlEndsWith.Controls.Add(this.lblEndsWith);
            this.pnlEndsWith.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEndsWith.Location = new System.Drawing.Point(0, 200);
            this.pnlEndsWith.Name = "pnlEndsWith";
            this.pnlEndsWith.Size = new System.Drawing.Size(109, 100);
            this.pnlEndsWith.TabIndex = 3;
            // 
            // txtEndsWith
            // 
            this.txtEndsWith.BackColor = System.Drawing.Color.Silver;
            this.txtEndsWith.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndsWith.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEndsWith.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEndsWith.Location = new System.Drawing.Point(0, 15);
            this.txtEndsWith.Margin = new System.Windows.Forms.Padding(50);
            this.txtEndsWith.Multiline = true;
            this.txtEndsWith.Name = "txtEndsWith";
            this.txtEndsWith.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEndsWith.Size = new System.Drawing.Size(109, 85);
            this.txtEndsWith.TabIndex = 17;
            this.txtEndsWith.WordWrap = false;
            // 
            // lblEndsWith
            // 
            this.lblEndsWith.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEndsWith.ForeColor = System.Drawing.Color.White;
            this.lblEndsWith.Location = new System.Drawing.Point(0, 0);
            this.lblEndsWith.Name = "lblEndsWith";
            this.lblEndsWith.Size = new System.Drawing.Size(109, 15);
            this.lblEndsWith.TabIndex = 18;
            this.lblEndsWith.Text = "Ends With";
            this.lblEndsWith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContains
            // 
            this.pnlContains.Controls.Add(this.txtContains);
            this.pnlContains.Controls.Add(this.lblContains);
            this.pnlContains.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContains.Location = new System.Drawing.Point(0, 100);
            this.pnlContains.Name = "pnlContains";
            this.pnlContains.Size = new System.Drawing.Size(109, 100);
            this.pnlContains.TabIndex = 2;
            // 
            // txtContains
            // 
            this.txtContains.BackColor = System.Drawing.Color.Silver;
            this.txtContains.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContains.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtContains.Location = new System.Drawing.Point(0, 15);
            this.txtContains.Margin = new System.Windows.Forms.Padding(50);
            this.txtContains.Multiline = true;
            this.txtContains.Name = "txtContains";
            this.txtContains.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContains.Size = new System.Drawing.Size(109, 85);
            this.txtContains.TabIndex = 17;
            this.txtContains.WordWrap = false;
            // 
            // lblContains
            // 
            this.lblContains.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContains.ForeColor = System.Drawing.Color.White;
            this.lblContains.Location = new System.Drawing.Point(0, 0);
            this.lblContains.Name = "lblContains";
            this.lblContains.Size = new System.Drawing.Size(109, 15);
            this.lblContains.TabIndex = 18;
            this.lblContains.Text = "Contains";
            this.lblContains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStartsWith
            // 
            this.pnlStartsWith.Controls.Add(this.txtStartsWith);
            this.pnlStartsWith.Controls.Add(this.lblStartsWith);
            this.pnlStartsWith.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStartsWith.Location = new System.Drawing.Point(0, 0);
            this.pnlStartsWith.Name = "pnlStartsWith";
            this.pnlStartsWith.Size = new System.Drawing.Size(109, 100);
            this.pnlStartsWith.TabIndex = 1;
            // 
            // txtStartsWith
            // 
            this.txtStartsWith.BackColor = System.Drawing.Color.Silver;
            this.txtStartsWith.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartsWith.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStartsWith.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStartsWith.Location = new System.Drawing.Point(0, 15);
            this.txtStartsWith.Margin = new System.Windows.Forms.Padding(50);
            this.txtStartsWith.Multiline = true;
            this.txtStartsWith.Name = "txtStartsWith";
            this.txtStartsWith.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStartsWith.Size = new System.Drawing.Size(109, 85);
            this.txtStartsWith.TabIndex = 17;
            this.txtStartsWith.Text = "neo";
            this.txtStartsWith.WordWrap = false;
            // 
            // lblStartsWith
            // 
            this.lblStartsWith.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStartsWith.ForeColor = System.Drawing.Color.White;
            this.lblStartsWith.Location = new System.Drawing.Point(0, 0);
            this.lblStartsWith.Name = "lblStartsWith";
            this.lblStartsWith.Size = new System.Drawing.Size(109, 15);
            this.lblStartsWith.TabIndex = 18;
            this.lblStartsWith.Text = "Starts With";
            this.lblStartsWith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(697, 511);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgAccounts);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neo N3 Vanity Address Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlEndsWith.ResumeLayout(false);
            this.pnlEndsWith.PerformLayout();
            this.pnlContains.ResumeLayout(false);
            this.pnlContains.PerformLayout();
            this.pnlStartsWith.ResumeLayout(false);
            this.pnlStartsWith.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel pnlTop;
        private DataGridView dgAccounts;
        private Button btnClean;
        private ComboBox cmbThread;
        private Button btnStart;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblInfo;
        private System.Windows.Forms.Timer timer1;
        private ToolStripSplitButton btnInfo;
        private ToolStripMenuItem btnGitHub;
        private ToolStripMenuItem btnTipBox;
        private Splitter splitter1;
        private Panel pnlLeft;
        private Panel pnlStartsWith;
        private Label lblStartsWith;
        private TextBox txtStartsWith;
        private Panel pnlEndsWith;
        private Label lblEndsWith;
        private TextBox txtEndsWith;
        private Panel pnlContains;
        private Label lblContains;
        private TextBox txtContains;
        private CheckBox chkRequireAll;
        private Label lblRequireAll;
    }
}