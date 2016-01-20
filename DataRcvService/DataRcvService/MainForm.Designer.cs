namespace DataRcvService
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiStartService = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStopService = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIncrementalPath = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServiceState = new System.Windows.Forms.Label();
            this.timerService = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStartService,
            this.tsmiStopService,
            this.tsmiSet});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiStartService
            // 
            this.tsmiStartService.Name = "tsmiStartService";
            this.tsmiStartService.Size = new System.Drawing.Size(68, 21);
            this.tsmiStartService.Text = "启动服务";
            this.tsmiStartService.Click += new System.EventHandler(this.tsmiStartService_Click);
            // 
            // tsmiStopService
            // 
            this.tsmiStopService.Name = "tsmiStopService";
            this.tsmiStopService.Size = new System.Drawing.Size(68, 21);
            this.tsmiStopService.Text = "停止服务";
            this.tsmiStopService.Click += new System.EventHandler(this.tsmiStopService_Click);
            // 
            // tsmiSet
            // 
            this.tsmiSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIncrementalPath});
            this.tsmiSet.Name = "tsmiSet";
            this.tsmiSet.Size = new System.Drawing.Size(44, 21);
            this.tsmiSet.Text = "设置";
            // 
            // tsmiIncrementalPath
            // 
            this.tsmiIncrementalPath.Name = "tsmiIncrementalPath";
            this.tsmiIncrementalPath.Size = new System.Drawing.Size(160, 22);
            this.tsmiIncrementalPath.Text = "增量文件的路径";
            this.tsmiIncrementalPath.Click += new System.EventHandler(this.tsmiIncrementalPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 407);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器消息";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(748, 381);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblServiceState);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 109);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "服务状态";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器状态：";
            // 
            // lblServiceState
            // 
            this.lblServiceState.Location = new System.Drawing.Point(92, 36);
            this.lblServiceState.Name = "lblServiceState";
            this.lblServiceState.Size = new System.Drawing.Size(71, 25);
            this.lblServiceState.TabIndex = 1;
            this.lblServiceState.Text = "停止";
            this.lblServiceState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerService
            // 
            this.timerService.Interval = 5000;
            this.timerService.Tick += new System.EventHandler(this.timerService_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "同步服务器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        /// <summary>
        /// 菜单中的按钮“启动服务”
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem tsmiStartService;
        /// <summary>
        /// 菜单中的按钮“停止服务”
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem tsmiStopService;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        /// <summary>
        /// 主窗体的消息区
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;
        /// <summary>
        /// 消息显示文本框
        /// </summary>
        private System.Windows.Forms.RichTextBox richTextBox1;
        /// <summary>
        /// 菜单中的按钮“设置”
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem tsmiSet;
        /// <summary>
        /// 菜单中的按钮“增量文件的路径”
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem tsmiIncrementalPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServiceState;
        private System.Windows.Forms.Timer timerService;
    }
}

