
namespace TCSniffer
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_analy = new System.Windows.Forms.Button();
            this.button_stopCapt = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_startCapt = new System.Windows.Forms.Button();
            this.button_loadDevices = new System.Windows.Forms.Button();
            this.comboBox_devices = new System.Windows.Forms.ComboBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listView_package = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Orientation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SrcIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DstIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CaptureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PayloadLen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PayloadData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxMenuStrip_packets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制选中载荷ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制全部载荷ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取抓包记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存抓包记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.r_txt_log = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.listView_analysis = new System.Windows.Forms.ListView();
            this.方向 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServiceCmd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SSOReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.载荷大小 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.捕获时间 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.载荷数据 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.解析数据 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PBJCE数据 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clean_httpserver_log = new System.Windows.Forms.Button();
            this.btn_stop_httpserver = new System.Windows.Forms.Button();
            this.btn_start_httpserver = new System.Windows.Forms.Button();
            this.txt_httpserver_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_httpserver_log = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.btn_decrypt_byte_by_byte = new System.Windows.Forms.Button();
            this.btn_tea_key_log_decrypt = new System.Windows.Forms.Button();
            this.btn_tea_copy_decrypt_data = new System.Windows.Forms.Button();
            this.btn_tea_decrypt = new System.Windows.Forms.Button();
            this.btn_tea_encrypt = new System.Windows.Forms.Button();
            this.txt_tea_key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.txt_tea_encrypt_data = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tea_decrypt_data = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox_keySetting = new System.Windows.Forms.GroupBox();
            this.textBox_keys = new System.Windows.Forms.TextBox();
            this.button_saveKey = new System.Windows.Forms.Button();
            this.button_readKey = new System.Windows.Forms.Button();
            this.ctxMenuStrip_analysis_tools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tea解密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.十六个0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KEY日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kEY逐日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据转换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.到10进制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.到文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.到QQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dec到时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hex到IPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hex到时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解压数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算字节数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TLV格式化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反解析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuStrip_trace_flow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制载荷数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制解析数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制PBJCE数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ServiceCmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解析PB数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解析JCE数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.ctxMenuStrip_packets.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox_keySetting.SuspendLayout();
            this.ctxMenuStrip_analysis_tools.SuspendLayout();
            this.ctxMenuStrip_trace_flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 633);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(962, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据包捕获";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_analy);
            this.splitContainer1.Panel1.Controls.Add(this.button_stopCapt);
            this.splitContainer1.Panel1.Controls.Add(this.button_clean);
            this.splitContainer1.Panel1.Controls.Add(this.button_startCapt);
            this.splitContainer1.Panel1.Controls.Add(this.button_loadDevices);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_devices);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 150;
            this.splitContainer1.Size = new System.Drawing.Size(956, 601);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_analy
            // 
            this.button_analy.Location = new System.Drawing.Point(770, 9);
            this.button_analy.Name = "button_analy";
            this.button_analy.Size = new System.Drawing.Size(75, 23);
            this.button_analy.TabIndex = 9;
            this.button_analy.Text = "分析";
            this.button_analy.UseVisualStyleBackColor = true;
            this.button_analy.Click += new System.EventHandler(this.button_analy_Click);
            // 
            // button_stopCapt
            // 
            this.button_stopCapt.Location = new System.Drawing.Point(586, 9);
            this.button_stopCapt.Name = "button_stopCapt";
            this.button_stopCapt.Size = new System.Drawing.Size(75, 23);
            this.button_stopCapt.TabIndex = 8;
            this.button_stopCapt.Text = "停止";
            this.button_stopCapt.UseVisualStyleBackColor = true;
            this.button_stopCapt.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(678, 9);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(75, 23);
            this.button_clean.TabIndex = 7;
            this.button_clean.Text = "清空";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_startCapt
            // 
            this.button_startCapt.Location = new System.Drawing.Point(494, 9);
            this.button_startCapt.Name = "button_startCapt";
            this.button_startCapt.Size = new System.Drawing.Size(75, 23);
            this.button_startCapt.TabIndex = 6;
            this.button_startCapt.Text = "开始";
            this.button_startCapt.UseVisualStyleBackColor = true;
            this.button_startCapt.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_loadDevices
            // 
            this.button_loadDevices.Location = new System.Drawing.Point(402, 9);
            this.button_loadDevices.Name = "button_loadDevices";
            this.button_loadDevices.Size = new System.Drawing.Size(75, 23);
            this.button_loadDevices.TabIndex = 5;
            this.button_loadDevices.Text = "读取";
            this.button_loadDevices.UseVisualStyleBackColor = true;
            this.button_loadDevices.Click += new System.EventHandler(this.button_loadDevices_Click_1);
            // 
            // comboBox_devices
            // 
            this.comboBox_devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_devices.FormattingEnabled = true;
            this.comboBox_devices.Location = new System.Drawing.Point(5, 12);
            this.comboBox_devices.Name = "comboBox_devices";
            this.comboBox_devices.Size = new System.Drawing.Size(370, 20);
            this.comboBox_devices.TabIndex = 4;
            this.comboBox_devices.SelectedIndexChanged += new System.EventHandler(this.ComboBox_devices_SelectedIndexChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(5, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listView_package);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.r_txt_log);
            this.splitContainer3.Panel2MinSize = 200;
            this.splitContainer3.Size = new System.Drawing.Size(946, 546);
            this.splitContainer3.SplitterDistance = 229;
            this.splitContainer3.TabIndex = 0;
            // 
            // listView_package
            // 
            this.listView_package.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Orientation,
            this.SrcIp,
            this.DstIp,
            this.CaptureTime,
            this.PayloadLen,
            this.PayloadData});
            this.listView_package.ContextMenuStrip = this.ctxMenuStrip_analysis_tools;
            this.listView_package.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_package.FullRowSelect = true;
            this.listView_package.GridLines = true;
            this.listView_package.HideSelection = false;
            this.listView_package.Location = new System.Drawing.Point(0, 0);
            this.listView_package.Name = "listView_package";
            this.listView_package.Size = new System.Drawing.Size(946, 229);
            this.listView_package.TabIndex = 8;
            this.listView_package.UseCompatibleStateImageBehavior = false;
            this.listView_package.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            // 
            // Orientation
            // 
            this.Orientation.Text = "方向";
            // 
            // SrcIp
            // 
            this.SrcIp.Text = "源地址";
            this.SrcIp.Width = 120;
            // 
            // DstIp
            // 
            this.DstIp.Text = "目的地址";
            this.DstIp.Width = 120;
            // 
            // CaptureTime
            // 
            this.CaptureTime.Text = "捕获时间";
            this.CaptureTime.Width = 126;
            // 
            // PayloadLen
            // 
            this.PayloadLen.Text = "载荷长度(byte)";
            this.PayloadLen.Width = 107;
            // 
            // PayloadData
            // 
            this.PayloadData.Text = "载荷数据";
            this.PayloadData.Width = 400;
            // 
            // ctxMenuStrip_packets
            // 
            this.ctxMenuStrip_packets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制选中载荷ToolStripMenuItem,
            this.复制全部载荷ToolStripMenuItem,
            this.读取抓包记录ToolStripMenuItem,
            this.保存抓包记录ToolStripMenuItem});
            this.ctxMenuStrip_packets.Name = "ctxMenuStrip_packets";
            this.ctxMenuStrip_packets.Size = new System.Drawing.Size(149, 92);
            // 
            // 复制选中载荷ToolStripMenuItem
            // 
            this.复制选中载荷ToolStripMenuItem.Name = "复制选中载荷ToolStripMenuItem";
            this.复制选中载荷ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.复制选中载荷ToolStripMenuItem.Text = "复制选中载荷";
            // 
            // 复制全部载荷ToolStripMenuItem
            // 
            this.复制全部载荷ToolStripMenuItem.Name = "复制全部载荷ToolStripMenuItem";
            this.复制全部载荷ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.复制全部载荷ToolStripMenuItem.Text = "复制全部载荷";
            // 
            // 读取抓包记录ToolStripMenuItem
            // 
            this.读取抓包记录ToolStripMenuItem.Name = "读取抓包记录ToolStripMenuItem";
            this.读取抓包记录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.读取抓包记录ToolStripMenuItem.Text = "读取抓包记录";
            // 
            // 保存抓包记录ToolStripMenuItem
            // 
            this.保存抓包记录ToolStripMenuItem.Name = "保存抓包记录ToolStripMenuItem";
            this.保存抓包记录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.保存抓包记录ToolStripMenuItem.Text = "保存抓包记录";
            // 
            // r_txt_log
            // 
            this.r_txt_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_txt_log.Location = new System.Drawing.Point(0, 0);
            this.r_txt_log.Name = "r_txt_log";
            this.r_txt_log.Size = new System.Drawing.Size(946, 313);
            this.r_txt_log.TabIndex = 0;
            this.r_txt_log.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(962, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据包分析";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.listView_analysis);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer4.Size = new System.Drawing.Size(956, 601);
            this.splitContainer4.SplitterDistance = 318;
            this.splitContainer4.TabIndex = 0;
            // 
            // listView_analysis
            // 
            this.listView_analysis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.方向,
            this.ServiceCmd,
            this.SSOReq,
            this.载荷大小,
            this.捕获时间,
            this.载荷数据,
            this.解析数据,
            this.PBJCE数据});
            this.listView_analysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_analysis.FullRowSelect = true;
            this.listView_analysis.GridLines = true;
            this.listView_analysis.HideSelection = false;
            this.listView_analysis.Location = new System.Drawing.Point(0, 0);
            this.listView_analysis.Name = "listView_analysis";
            this.listView_analysis.Size = new System.Drawing.Size(956, 318);
            this.listView_analysis.TabIndex = 7;
            this.listView_analysis.UseCompatibleStateImageBehavior = false;
            this.listView_analysis.View = System.Windows.Forms.View.Details;
            // 
            // 方向
            // 
            this.方向.Text = "方向";
            // 
            // ServiceCmd
            // 
            this.ServiceCmd.Text = "ServiceCmd";
            this.ServiceCmd.Width = 160;
            // 
            // SSOReq
            // 
            this.SSOReq.Text = "SSOReq";
            this.SSOReq.Width = 120;
            // 
            // 载荷大小
            // 
            this.载荷大小.Text = "载荷大小(byte)";
            this.载荷大小.Width = 106;
            // 
            // 捕获时间
            // 
            this.捕获时间.Text = "捕获时间";
            this.捕获时间.Width = 106;
            // 
            // 载荷数据
            // 
            this.载荷数据.Text = "载荷数据";
            this.载荷数据.Width = 100;
            // 
            // 解析数据
            // 
            this.解析数据.Text = "解析数据";
            this.解析数据.Width = 100;
            // 
            // PBJCE数据
            // 
            this.PBJCE数据.Text = "PB/JCE数据";
            this.PBJCE数据.Width = 100;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(956, 279);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(962, 607);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HTPP服务器";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.richTextBox_httpserver_log);
            this.splitContainer5.Size = new System.Drawing.Size(956, 601);
            this.splitContainer5.SplitterDistance = 54;
            this.splitContainer5.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clean_httpserver_log);
            this.groupBox1.Controls.Add(this.btn_stop_httpserver);
            this.groupBox1.Controls.Add(this.btn_start_httpserver);
            this.groupBox1.Controls.Add(this.txt_httpserver_port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器配置";
            // 
            // btn_clean_httpserver_log
            // 
            this.btn_clean_httpserver_log.Location = new System.Drawing.Point(293, 20);
            this.btn_clean_httpserver_log.Name = "btn_clean_httpserver_log";
            this.btn_clean_httpserver_log.Size = new System.Drawing.Size(75, 23);
            this.btn_clean_httpserver_log.TabIndex = 20;
            this.btn_clean_httpserver_log.Text = "清空";
            this.btn_clean_httpserver_log.UseVisualStyleBackColor = true;
            // 
            // btn_stop_httpserver
            // 
            this.btn_stop_httpserver.Location = new System.Drawing.Point(212, 20);
            this.btn_stop_httpserver.Name = "btn_stop_httpserver";
            this.btn_stop_httpserver.Size = new System.Drawing.Size(75, 23);
            this.btn_stop_httpserver.TabIndex = 19;
            this.btn_stop_httpserver.Text = "关闭";
            this.btn_stop_httpserver.UseVisualStyleBackColor = true;
            // 
            // btn_start_httpserver
            // 
            this.btn_start_httpserver.Location = new System.Drawing.Point(131, 20);
            this.btn_start_httpserver.Name = "btn_start_httpserver";
            this.btn_start_httpserver.Size = new System.Drawing.Size(75, 23);
            this.btn_start_httpserver.TabIndex = 18;
            this.btn_start_httpserver.Text = "启动";
            this.btn_start_httpserver.UseVisualStyleBackColor = true;
            // 
            // txt_httpserver_port
            // 
            this.txt_httpserver_port.Location = new System.Drawing.Point(47, 20);
            this.txt_httpserver_port.Name = "txt_httpserver_port";
            this.txt_httpserver_port.Size = new System.Drawing.Size(78, 21);
            this.txt_httpserver_port.TabIndex = 17;
            this.txt_httpserver_port.Text = "8001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "端口";
            // 
            // richTextBox_httpserver_log
            // 
            this.richTextBox_httpserver_log.BackColor = System.Drawing.Color.Black;
            this.richTextBox_httpserver_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_httpserver_log.ForeColor = System.Drawing.Color.LimeGreen;
            this.richTextBox_httpserver_log.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_httpserver_log.Name = "richTextBox_httpserver_log";
            this.richTextBox_httpserver_log.ReadOnly = true;
            this.richTextBox_httpserver_log.Size = new System.Drawing.Size(956, 543);
            this.richTextBox_httpserver_log.TabIndex = 1;
            this.richTextBox_httpserver_log.Text = "";
            this.richTextBox_httpserver_log.WordWrap = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(962, 607);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tea加解密";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.btn_decrypt_byte_by_byte);
            this.splitContainer6.Panel1.Controls.Add(this.btn_tea_key_log_decrypt);
            this.splitContainer6.Panel1.Controls.Add(this.btn_tea_copy_decrypt_data);
            this.splitContainer6.Panel1.Controls.Add(this.btn_tea_decrypt);
            this.splitContainer6.Panel1.Controls.Add(this.btn_tea_encrypt);
            this.splitContainer6.Panel1.Controls.Add(this.txt_tea_key);
            this.splitContainer6.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer6.Size = new System.Drawing.Size(956, 601);
            this.splitContainer6.SplitterDistance = 47;
            this.splitContainer6.TabIndex = 0;
            // 
            // btn_decrypt_byte_by_byte
            // 
            this.btn_decrypt_byte_by_byte.Location = new System.Drawing.Point(815, 12);
            this.btn_decrypt_byte_by_byte.Name = "btn_decrypt_byte_by_byte";
            this.btn_decrypt_byte_by_byte.Size = new System.Drawing.Size(121, 23);
            this.btn_decrypt_byte_by_byte.TabIndex = 16;
            this.btn_decrypt_byte_by_byte.Text = "逐字节KEY日志解密";
            this.btn_decrypt_byte_by_byte.UseVisualStyleBackColor = true;
            // 
            // btn_tea_key_log_decrypt
            // 
            this.btn_tea_key_log_decrypt.Location = new System.Drawing.Point(698, 12);
            this.btn_tea_key_log_decrypt.Name = "btn_tea_key_log_decrypt";
            this.btn_tea_key_log_decrypt.Size = new System.Drawing.Size(96, 23);
            this.btn_tea_key_log_decrypt.TabIndex = 15;
            this.btn_tea_key_log_decrypt.Text = "KEY日志解密";
            this.btn_tea_key_log_decrypt.UseVisualStyleBackColor = true;
            // 
            // btn_tea_copy_decrypt_data
            // 
            this.btn_tea_copy_decrypt_data.Location = new System.Drawing.Point(587, 12);
            this.btn_tea_copy_decrypt_data.Name = "btn_tea_copy_decrypt_data";
            this.btn_tea_copy_decrypt_data.Size = new System.Drawing.Size(96, 23);
            this.btn_tea_copy_decrypt_data.TabIndex = 14;
            this.btn_tea_copy_decrypt_data.Text = "复制解密数据";
            this.btn_tea_copy_decrypt_data.UseVisualStyleBackColor = true;
            // 
            // btn_tea_decrypt
            // 
            this.btn_tea_decrypt.Location = new System.Drawing.Point(495, 12);
            this.btn_tea_decrypt.Name = "btn_tea_decrypt";
            this.btn_tea_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_tea_decrypt.TabIndex = 13;
            this.btn_tea_decrypt.Text = "解密";
            this.btn_tea_decrypt.UseVisualStyleBackColor = true;
            // 
            // btn_tea_encrypt
            // 
            this.btn_tea_encrypt.Location = new System.Drawing.Point(401, 12);
            this.btn_tea_encrypt.Name = "btn_tea_encrypt";
            this.btn_tea_encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_tea_encrypt.TabIndex = 12;
            this.btn_tea_encrypt.Text = "加密";
            this.btn_tea_encrypt.UseVisualStyleBackColor = true;
            // 
            // txt_tea_key
            // 
            this.txt_tea_key.Location = new System.Drawing.Point(47, 12);
            this.txt_tea_key.Name = "txt_tea_key";
            this.txt_tea_key.Size = new System.Drawing.Size(332, 21);
            this.txt_tea_key.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "密钥";
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.txt_tea_encrypt_data);
            this.splitContainer7.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.txt_tea_decrypt_data);
            this.splitContainer7.Size = new System.Drawing.Size(956, 550);
            this.splitContainer7.SplitterDistance = 273;
            this.splitContainer7.TabIndex = 0;
            // 
            // txt_tea_encrypt_data
            // 
            this.txt_tea_encrypt_data.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_tea_encrypt_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tea_encrypt_data.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_tea_encrypt_data.Location = new System.Drawing.Point(0, 0);
            this.txt_tea_encrypt_data.Multiline = true;
            this.txt_tea_encrypt_data.Name = "txt_tea_encrypt_data";
            this.txt_tea_encrypt_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_tea_encrypt_data.Size = new System.Drawing.Size(956, 273);
            this.txt_tea_encrypt_data.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-76, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "加密数据";
            // 
            // txt_tea_decrypt_data
            // 
            this.txt_tea_decrypt_data.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt_tea_decrypt_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tea_decrypt_data.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_tea_decrypt_data.Location = new System.Drawing.Point(0, 0);
            this.txt_tea_decrypt_data.Multiline = true;
            this.txt_tea_decrypt_data.Name = "txt_tea_decrypt_data";
            this.txt_tea_decrypt_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_tea_decrypt_data.Size = new System.Drawing.Size(956, 273);
            this.txt_tea_decrypt_data.TabIndex = 6;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(962, 607);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "软件设置";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox_keySetting);
            this.splitContainer2.Size = new System.Drawing.Size(956, 601);
            this.splitContainer2.SplitterDistance = 398;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox_keySetting
            // 
            this.groupBox_keySetting.Controls.Add(this.textBox_keys);
            this.groupBox_keySetting.Controls.Add(this.button_saveKey);
            this.groupBox_keySetting.Controls.Add(this.button_readKey);
            this.groupBox_keySetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_keySetting.Location = new System.Drawing.Point(0, 0);
            this.groupBox_keySetting.Name = "groupBox_keySetting";
            this.groupBox_keySetting.Size = new System.Drawing.Size(398, 601);
            this.groupBox_keySetting.TabIndex = 0;
            this.groupBox_keySetting.TabStop = false;
            this.groupBox_keySetting.Text = "key设置";
            // 
            // textBox_keys
            // 
            this.textBox_keys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_keys.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox_keys.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox_keys.Location = new System.Drawing.Point(6, 49);
            this.textBox_keys.Multiline = true;
            this.textBox_keys.Name = "textBox_keys";
            this.textBox_keys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_keys.Size = new System.Drawing.Size(386, 546);
            this.textBox_keys.TabIndex = 2;
            // 
            // button_saveKey
            // 
            this.button_saveKey.Location = new System.Drawing.Point(317, 20);
            this.button_saveKey.Name = "button_saveKey";
            this.button_saveKey.Size = new System.Drawing.Size(75, 23);
            this.button_saveKey.TabIndex = 1;
            this.button_saveKey.Text = "保存";
            this.button_saveKey.UseVisualStyleBackColor = true;
            // 
            // button_readKey
            // 
            this.button_readKey.Location = new System.Drawing.Point(226, 20);
            this.button_readKey.Name = "button_readKey";
            this.button_readKey.Size = new System.Drawing.Size(75, 23);
            this.button_readKey.TabIndex = 0;
            this.button_readKey.Text = "读取";
            this.button_readKey.UseVisualStyleBackColor = true;
            // 
            // ctxMenuStrip_analysis_tools
            // 
            this.ctxMenuStrip_analysis_tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tea解密ToolStripMenuItem,
            this.数据转换ToolStripMenuItem,
            this.计算字节数ToolStripMenuItem,
            this.TLV格式化ToolStripMenuItem,
            this.反解析ToolStripMenuItem});
            this.ctxMenuStrip_analysis_tools.Name = "ctxMenuStrip_analysis_tools";
            this.ctxMenuStrip_analysis_tools.Size = new System.Drawing.Size(137, 114);
            // 
            // tea解密ToolStripMenuItem
            // 
            this.tea解密ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.十六个0ToolStripMenuItem,
            this.KEY日志ToolStripMenuItem,
            this.kEY逐日志ToolStripMenuItem});
            this.tea解密ToolStripMenuItem.Name = "tea解密ToolStripMenuItem";
            this.tea解密ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tea解密ToolStripMenuItem.Text = "Tea解密";
            // 
            // 十六个0ToolStripMenuItem
            // 
            this.十六个0ToolStripMenuItem.Name = "十六个0ToolStripMenuItem";
            this.十六个0ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.十六个0ToolStripMenuItem.Text = "十六个0";
            // 
            // KEY日志ToolStripMenuItem
            // 
            this.KEY日志ToolStripMenuItem.Name = "KEY日志ToolStripMenuItem";
            this.KEY日志ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.KEY日志ToolStripMenuItem.Text = "KEY日志";
            // 
            // kEY逐日志ToolStripMenuItem
            // 
            this.kEY逐日志ToolStripMenuItem.Name = "kEY逐日志ToolStripMenuItem";
            this.kEY逐日志ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.kEY逐日志ToolStripMenuItem.Text = "KEY逐字节";
            // 
            // 数据转换ToolStripMenuItem
            // 
            this.数据转换ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.到10进制ToolStripMenuItem,
            this.到文本ToolStripMenuItem,
            this.到QQToolStripMenuItem,
            this.dec到时间ToolStripMenuItem,
            this.hex到IPToolStripMenuItem,
            this.hex到时间ToolStripMenuItem,
            this.解压数据ToolStripMenuItem});
            this.数据转换ToolStripMenuItem.Name = "数据转换ToolStripMenuItem";
            this.数据转换ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.数据转换ToolStripMenuItem.Text = "数据转换";
            // 
            // 到10进制ToolStripMenuItem
            // 
            this.到10进制ToolStripMenuItem.Name = "到10进制ToolStripMenuItem";
            this.到10进制ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.到10进制ToolStripMenuItem.Text = "到10进制";
            // 
            // 到文本ToolStripMenuItem
            // 
            this.到文本ToolStripMenuItem.Name = "到文本ToolStripMenuItem";
            this.到文本ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.到文本ToolStripMenuItem.Text = "到文本";
            // 
            // 到QQToolStripMenuItem
            // 
            this.到QQToolStripMenuItem.Name = "到QQToolStripMenuItem";
            this.到QQToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.到QQToolStripMenuItem.Text = "到QQ";
            // 
            // dec到时间ToolStripMenuItem
            // 
            this.dec到时间ToolStripMenuItem.Name = "dec到时间ToolStripMenuItem";
            this.dec到时间ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dec到时间ToolStripMenuItem.Text = "Dec到时间";
            // 
            // hex到IPToolStripMenuItem
            // 
            this.hex到IPToolStripMenuItem.Name = "hex到IPToolStripMenuItem";
            this.hex到IPToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.hex到IPToolStripMenuItem.Text = "Hex到IP";
            // 
            // hex到时间ToolStripMenuItem
            // 
            this.hex到时间ToolStripMenuItem.Name = "hex到时间ToolStripMenuItem";
            this.hex到时间ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.hex到时间ToolStripMenuItem.Text = "Hex到时间";
            // 
            // 解压数据ToolStripMenuItem
            // 
            this.解压数据ToolStripMenuItem.Name = "解压数据ToolStripMenuItem";
            this.解压数据ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.解压数据ToolStripMenuItem.Text = "解压数据";
            // 
            // 计算字节数ToolStripMenuItem
            // 
            this.计算字节数ToolStripMenuItem.Name = "计算字节数ToolStripMenuItem";
            this.计算字节数ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.计算字节数ToolStripMenuItem.Text = "计算字节数";
            // 
            // TLV格式化ToolStripMenuItem
            // 
            this.TLV格式化ToolStripMenuItem.Name = "TLV格式化ToolStripMenuItem";
            this.TLV格式化ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.TLV格式化ToolStripMenuItem.Text = "TLV格式化";
            // 
            // 反解析ToolStripMenuItem
            // 
            this.反解析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jCEToolStripMenuItem,
            this.pBToolStripMenuItem});
            this.反解析ToolStripMenuItem.Name = "反解析ToolStripMenuItem";
            this.反解析ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.反解析ToolStripMenuItem.Text = "反解析";
            // 
            // jCEToolStripMenuItem
            // 
            this.jCEToolStripMenuItem.Name = "jCEToolStripMenuItem";
            this.jCEToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.jCEToolStripMenuItem.Text = "JCE";
            // 
            // pBToolStripMenuItem
            // 
            this.pBToolStripMenuItem.Name = "pBToolStripMenuItem";
            this.pBToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.pBToolStripMenuItem.Text = "PB";
            // 
            // ctxMenuStrip_trace_flow
            // 
            this.ctxMenuStrip_trace_flow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.清空数据ToolStripMenuItem,
            this.解析ToolStripMenuItem});
            this.ctxMenuStrip_trace_flow.Name = "ctxMenuStrip_trace_flow";
            this.ctxMenuStrip_trace_flow.Size = new System.Drawing.Size(125, 70);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制载荷数据ToolStripMenuItem,
            this.复制解析数据ToolStripMenuItem,
            this.复制PBJCE数据ToolStripMenuItem,
            this.复制ServiceCmdToolStripMenuItem});
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 复制载荷数据ToolStripMenuItem
            // 
            this.复制载荷数据ToolStripMenuItem.Name = "复制载荷数据ToolStripMenuItem";
            this.复制载荷数据ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.复制载荷数据ToolStripMenuItem.Text = "复制载荷数据";
            // 
            // 复制解析数据ToolStripMenuItem
            // 
            this.复制解析数据ToolStripMenuItem.Name = "复制解析数据ToolStripMenuItem";
            this.复制解析数据ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.复制解析数据ToolStripMenuItem.Text = "复制解析数据";
            // 
            // 复制PBJCE数据ToolStripMenuItem
            // 
            this.复制PBJCE数据ToolStripMenuItem.Name = "复制PBJCE数据ToolStripMenuItem";
            this.复制PBJCE数据ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.复制PBJCE数据ToolStripMenuItem.Text = "复制PB/JCE数据";
            // 
            // 复制ServiceCmdToolStripMenuItem
            // 
            this.复制ServiceCmdToolStripMenuItem.Name = "复制ServiceCmdToolStripMenuItem";
            this.复制ServiceCmdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.复制ServiceCmdToolStripMenuItem.Text = "复制ServiceCmd";
            // 
            // 清空数据ToolStripMenuItem
            // 
            this.清空数据ToolStripMenuItem.Name = "清空数据ToolStripMenuItem";
            this.清空数据ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.清空数据ToolStripMenuItem.Text = "清空数据";
            // 
            // 解析ToolStripMenuItem
            // 
            this.解析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.解析PB数据ToolStripMenuItem,
            this.解析JCE数据ToolStripMenuItem});
            this.解析ToolStripMenuItem.Name = "解析ToolStripMenuItem";
            this.解析ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.解析ToolStripMenuItem.Text = "解析";
            // 
            // 解析PB数据ToolStripMenuItem
            // 
            this.解析PB数据ToolStripMenuItem.Name = "解析PB数据ToolStripMenuItem";
            this.解析PB数据ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.解析PB数据ToolStripMenuItem.Text = "解析PB数据";
            // 
            // 解析JCE数据ToolStripMenuItem
            // 
            this.解析JCE数据ToolStripMenuItem.Name = "解析JCE数据ToolStripMenuItem";
            this.解析JCE数据ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.解析JCE数据ToolStripMenuItem.Text = "解析JCE数据";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 633);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TC_QQSniffer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ctxMenuStrip_packets.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox_keySetting.ResumeLayout(false);
            this.groupBox_keySetting.PerformLayout();
            this.ctxMenuStrip_analysis_tools.ResumeLayout(false);
            this.ctxMenuStrip_trace_flow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_startCapt;
        private System.Windows.Forms.Button button_loadDevices;
        private System.Windows.Forms.ComboBox comboBox_devices;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button button_stopCapt;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox_keySetting;
        public System.Windows.Forms.TextBox textBox_keys;
        public System.Windows.Forms.Button button_saveKey;
        public System.Windows.Forms.Button button_readKey;
        private System.Windows.Forms.Button button_analy;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        public System.Windows.Forms.ListView listView_analysis;
        private System.Windows.Forms.ColumnHeader 方向;
        private System.Windows.Forms.ColumnHeader ServiceCmd;
        private System.Windows.Forms.ColumnHeader SSOReq;
        private System.Windows.Forms.ColumnHeader 载荷大小;
        private System.Windows.Forms.ColumnHeader 捕获时间;
        private System.Windows.Forms.ColumnHeader 载荷数据;
        private System.Windows.Forms.ColumnHeader 解析数据;
        private System.Windows.Forms.ColumnHeader PBJCE数据;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btn_clean_httpserver_log;
        public System.Windows.Forms.Button btn_stop_httpserver;
        public System.Windows.Forms.Button btn_start_httpserver;
        public System.Windows.Forms.TextBox txt_httpserver_port;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox richTextBox_httpserver_log;
        private System.Windows.Forms.SplitContainer splitContainer6;
        public System.Windows.Forms.Button btn_tea_key_log_decrypt;
        public System.Windows.Forms.Button btn_tea_copy_decrypt_data;
        public System.Windows.Forms.Button btn_tea_decrypt;
        public System.Windows.Forms.Button btn_tea_encrypt;
        public System.Windows.Forms.TextBox txt_tea_key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer7;
        public System.Windows.Forms.TextBox txt_tea_encrypt_data;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_tea_decrypt_data;
        public System.Windows.Forms.Button btn_decrypt_byte_by_byte;
        public System.Windows.Forms.ContextMenuStrip ctxMenuStrip_analysis_tools;
        public System.Windows.Forms.ToolStripMenuItem 到10进制ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 到文本ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 到QQToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem dec到时间ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem hex到时间ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem hex到IPToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem jCEToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pBToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tea解密ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 数据转换ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 计算字节数ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem TLV格式化ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 反解析ToolStripMenuItem;
        public System.Windows.Forms.RichTextBox r_txt_log;
        public System.Windows.Forms.ToolStripMenuItem 十六个0ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem KEY日志ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kEY逐日志ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 解压数据ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxMenuStrip_packets;
        public System.Windows.Forms.ListView listView_package;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Orientation;
        private System.Windows.Forms.ColumnHeader SrcIp;
        private System.Windows.Forms.ColumnHeader DstIp;
        private System.Windows.Forms.ColumnHeader CaptureTime;
        private System.Windows.Forms.ColumnHeader PayloadLen;
        private System.Windows.Forms.ColumnHeader PayloadData;
        public System.Windows.Forms.ToolStripMenuItem 复制选中载荷ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 复制全部载荷ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 读取抓包记录ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 保存抓包记录ToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip ctxMenuStrip_trace_flow;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 复制载荷数据ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 复制解析数据ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 复制PBJCE数据ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 复制ServiceCmdToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 清空数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解析PB数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解析JCE数据ToolStripMenuItem;
    }
}

