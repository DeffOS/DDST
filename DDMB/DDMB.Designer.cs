namespace DDST
{
    partial class DDMB
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel11 = new System.Windows.Forms.Panel();
            this.GQCsBut = new System.Windows.Forms.Button();
            this.CompileBut = new System.Windows.Forms.Button();
            this.SMD_List = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SetBINPath = new System.Windows.Forms.Button();
            this.ClearBut = new System.Windows.Forms.Button();
            this.OpenBut = new System.Windows.Forms.Button();
            this.ModBox = new System.Windows.Forms.ComboBox();
            this.InfoTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SequncesTick = new System.Windows.Forms.CheckBox();
            this.SequenceGBox = new System.Windows.Forms.GroupBox();
            this.SqLoopTick = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SqFPS = new System.Windows.Forms.NumericUpDown();
            this.panel9 = new System.Windows.Forms.Panel();
            this.PathBut = new System.Windows.Forms.Button();
            this.ExitText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ConvexTick = new System.Windows.Forms.CheckBox();
            this.CollSufixBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.OpacityBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AutoCenterTick = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CDPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LodTick = new System.Windows.Forms.CheckBox();
            this.SurfaceBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StaticTick = new System.Windows.Forms.CheckBox();
            this.ScaleNum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ModelPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Log = new System.Windows.Forms.TextBox();
            this.BinBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExitBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.InfoTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SequenceGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SqFPS)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNum)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.splitContainer1.Panel1.Controls.Add(this.ProgressBar);
            this.splitContainer1.Panel1.Controls.Add(this.panel11);
            this.splitContainer1.Panel1.Controls.Add(this.SMD_List);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ModBox);
            this.splitContainer1.Panel2.Controls.Add(this.InfoTab);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Silver;
            this.splitContainer1.Size = new System.Drawing.Size(683, 491);
            this.splitContainer1.SplitterDistance = 344;
            this.splitContainer1.TabIndex = 0;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ProgressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar.Location = new System.Drawing.Point(0, 454);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(342, 11);
            this.ProgressBar.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.GQCsBut);
            this.panel11.Controls.Add(this.CompileBut);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 465);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(342, 24);
            this.panel11.TabIndex = 4;
            // 
            // GQCsBut
            // 
            this.GQCsBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.GQCsBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GQCsBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.GQCsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GQCsBut.ForeColor = System.Drawing.Color.Silver;
            this.GQCsBut.Location = new System.Drawing.Point(106, 0);
            this.GQCsBut.Name = "GQCsBut";
            this.GQCsBut.Size = new System.Drawing.Size(236, 24);
            this.GQCsBut.TabIndex = 3;
            this.GQCsBut.Text = "Generate QCs";
            this.GQCsBut.UseVisualStyleBackColor = false;
            this.GQCsBut.Click += new System.EventHandler(this.GQCsBut_Click);
            // 
            // CompileBut
            // 
            this.CompileBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CompileBut.Dock = System.Windows.Forms.DockStyle.Left;
            this.CompileBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CompileBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompileBut.ForeColor = System.Drawing.Color.Silver;
            this.CompileBut.Location = new System.Drawing.Point(0, 0);
            this.CompileBut.Name = "CompileBut";
            this.CompileBut.Size = new System.Drawing.Size(106, 24);
            this.CompileBut.TabIndex = 2;
            this.CompileBut.Text = "Compile";
            this.CompileBut.UseVisualStyleBackColor = false;
            this.CompileBut.Click += new System.EventHandler(this.CompileBut_Click);
            // 
            // SMD_List
            // 
            this.SMD_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.SMD_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SMD_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SMD_List.ForeColor = System.Drawing.Color.Silver;
            this.SMD_List.FormattingEnabled = true;
            this.SMD_List.Location = new System.Drawing.Point(0, 26);
            this.SMD_List.Name = "SMD_List";
            this.SMD_List.Size = new System.Drawing.Size(342, 463);
            this.SMD_List.TabIndex = 1;
            this.SMD_List.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SMD_List_Delete);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SetBINPath);
            this.panel1.Controls.Add(this.ClearBut);
            this.panel1.Controls.Add(this.OpenBut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 26);
            this.panel1.TabIndex = 0;
            // 
            // SetBINPath
            // 
            this.SetBINPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SetBINPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetBINPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.SetBINPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetBINPath.ForeColor = System.Drawing.Color.Silver;
            this.SetBINPath.Location = new System.Drawing.Point(48, 0);
            this.SetBINPath.Name = "SetBINPath";
            this.SetBINPath.Size = new System.Drawing.Size(220, 26);
            this.SetBINPath.TabIndex = 4;
            this.SetBINPath.Text = "Set BIN directory";
            this.SetBINPath.UseVisualStyleBackColor = false;
            this.SetBINPath.Click += new System.EventHandler(this.BINBut_Click);
            // 
            // ClearBut
            // 
            this.ClearBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClearBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClearBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBut.ForeColor = System.Drawing.Color.Silver;
            this.ClearBut.Location = new System.Drawing.Point(268, 0);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(74, 26);
            this.ClearBut.TabIndex = 2;
            this.ClearBut.Text = "Clear List";
            this.ClearBut.UseVisualStyleBackColor = false;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // OpenBut
            // 
            this.OpenBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.OpenBut.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.OpenBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBut.ForeColor = System.Drawing.Color.Silver;
            this.OpenBut.Location = new System.Drawing.Point(0, 0);
            this.OpenBut.Name = "OpenBut";
            this.OpenBut.Size = new System.Drawing.Size(48, 26);
            this.OpenBut.TabIndex = 3;
            this.OpenBut.Text = "Open";
            this.OpenBut.UseVisualStyleBackColor = false;
            this.OpenBut.Click += new System.EventHandler(this.OpenBut_Click);
            // 
            // ModBox
            // 
            this.ModBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ModBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModBox.ForeColor = System.Drawing.Color.Silver;
            this.ModBox.FormattingEnabled = true;
            this.ModBox.Items.AddRange(new object[] {
            "garrysmod"});
            this.ModBox.Location = new System.Drawing.Point(234, 2);
            this.ModBox.Name = "ModBox";
            this.ModBox.Size = new System.Drawing.Size(96, 21);
            this.ModBox.TabIndex = 1;
            this.ModBox.Text = "garrysmod";
            // 
            // InfoTab
            // 
            this.InfoTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.InfoTab.Controls.Add(this.tabPage1);
            this.InfoTab.Controls.Add(this.tabPage2);
            this.InfoTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTab.Location = new System.Drawing.Point(0, 0);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfoTab.SelectedIndex = 0;
            this.InfoTab.Size = new System.Drawing.Size(333, 489);
            this.InfoTab.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage1.Controls.Add(this.SequncesTick);
            this.tabPage1.Controls.Add(this.SequenceGBox);
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(325, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            // 
            // SequncesTick
            // 
            this.SequncesTick.AutoSize = true;
            this.SequncesTick.Enabled = false;
            this.SequncesTick.Location = new System.Drawing.Point(21, 148);
            this.SequncesTick.Name = "SequncesTick";
            this.SequncesTick.Size = new System.Drawing.Size(171, 17);
            this.SequncesTick.TabIndex = 2;
            this.SequncesTick.Text = "$sequnces (anims\\\"name\"_#):";
            this.SequncesTick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SequncesTick.UseVisualStyleBackColor = true;
            this.SequncesTick.CheckedChanged += new System.EventHandler(this.SequncesTick_CheckedChanged);
            // 
            // SequenceGBox
            // 
            this.SequenceGBox.Controls.Add(this.SqLoopTick);
            this.SequenceGBox.Controls.Add(this.label7);
            this.SequenceGBox.Controls.Add(this.SqFPS);
            this.SequenceGBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SequenceGBox.Enabled = false;
            this.SequenceGBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SequenceGBox.Location = new System.Drawing.Point(3, 147);
            this.SequenceGBox.Name = "SequenceGBox";
            this.SequenceGBox.Padding = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.SequenceGBox.Size = new System.Drawing.Size(319, 45);
            this.SequenceGBox.TabIndex = 9;
            this.SequenceGBox.TabStop = false;
            // 
            // SqLoopTick
            // 
            this.SqLoopTick.AutoSize = true;
            this.SqLoopTick.Location = new System.Drawing.Point(8, 20);
            this.SqLoopTick.Name = "SqLoopTick";
            this.SqLoopTick.Size = new System.Drawing.Size(50, 17);
            this.SqLoopTick.TabIndex = 9;
            this.SqLoopTick.Text = "Loop";
            this.SqLoopTick.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "FPS:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SqFPS
            // 
            this.SqFPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.SqFPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SqFPS.ForeColor = System.Drawing.Color.Silver;
            this.SqFPS.Location = new System.Drawing.Point(255, 18);
            this.SqFPS.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.SqFPS.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.SqFPS.Name = "SqFPS";
            this.SqFPS.Size = new System.Drawing.Size(63, 20);
            this.SqFPS.TabIndex = 7;
            this.SqFPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SqFPS.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.PathBut);
            this.panel9.Controls.Add(this.ExitText);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Enabled = false;
            this.panel9.Location = new System.Drawing.Point(3, 433);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(319, 24);
            this.panel9.TabIndex = 7;
            this.panel9.Visible = false;
            // 
            // PathBut
            // 
            this.PathBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PathBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PathBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PathBut.ForeColor = System.Drawing.Color.Silver;
            this.PathBut.Location = new System.Drawing.Point(199, 0);
            this.PathBut.Name = "PathBut";
            this.PathBut.Size = new System.Drawing.Size(118, 22);
            this.PathBut.TabIndex = 5;
            this.PathBut.Text = "Set Path";
            this.PathBut.UseVisualStyleBackColor = false;
            this.PathBut.Click += new System.EventHandler(this.PathBut_Click);
            // 
            // ExitText
            // 
            this.ExitText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ExitText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitText.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExitText.ForeColor = System.Drawing.Color.Silver;
            this.ExitText.Location = new System.Drawing.Point(57, 0);
            this.ExitText.Name = "ExitText";
            this.ExitText.Size = new System.Drawing.Size(142, 20);
            this.ExitText.TabIndex = 1;
            this.ExitText.Text = "path_to_mod/game root";
            this.ExitText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitText.Leave += new System.EventHandler(this.ExitText_Leave);
            this.ExitText.MouseEnter += new System.EventHandler(this.ExitText_MouseEnter);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Exit Path :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.ConvexTick);
            this.panel6.Controls.Add(this.CollSufixBox);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 123);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(319, 24);
            this.panel6.TabIndex = 4;
            // 
            // ConvexTick
            // 
            this.ConvexTick.AutoSize = true;
            this.ConvexTick.Dock = System.Windows.Forms.DockStyle.Right;
            this.ConvexTick.Location = new System.Drawing.Point(237, 0);
            this.ConvexTick.Name = "ConvexTick";
            this.ConvexTick.Size = new System.Drawing.Size(80, 22);
            this.ConvexTick.TabIndex = 2;
            this.ConvexTick.Text = ": $concave";
            this.ConvexTick.UseVisualStyleBackColor = true;
            // 
            // CollSufixBox
            // 
            this.CollSufixBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CollSufixBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CollSufixBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CollSufixBox.ForeColor = System.Drawing.Color.Silver;
            this.CollSufixBox.Location = new System.Drawing.Point(86, 0);
            this.CollSufixBox.Name = "CollSufixBox";
            this.CollSufixBox.Size = new System.Drawing.Size(148, 20);
            this.CollSufixBox.TabIndex = 1;
            this.CollSufixBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "$collisionmodel :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.OpacityBox);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.AutoCenterTick);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 99);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 24);
            this.panel7.TabIndex = 5;
            // 
            // OpacityBox
            // 
            this.OpacityBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.OpacityBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.OpacityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.OpacityBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpacityBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpacityBox.ForeColor = System.Drawing.Color.Silver;
            this.OpacityBox.FormattingEnabled = true;
            this.OpacityBox.Items.AddRange(new object[] {
            "opaque",
            "mostlyopaque"});
            this.OpacityBox.Location = new System.Drawing.Point(101, 0);
            this.OpacityBox.Name = "OpacityBox";
            this.OpacityBox.Size = new System.Drawing.Size(165, 21);
            this.OpacityBox.TabIndex = 2;
            this.OpacityBox.Text = "opaque";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Location = new System.Drawing.Point(266, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = ": Opacity";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AutoCenterTick
            // 
            this.AutoCenterTick.AutoSize = true;
            this.AutoCenterTick.Dock = System.Windows.Forms.DockStyle.Left;
            this.AutoCenterTick.Location = new System.Drawing.Point(86, 0);
            this.AutoCenterTick.Name = "AutoCenterTick";
            this.AutoCenterTick.Size = new System.Drawing.Size(15, 22);
            this.AutoCenterTick.TabIndex = 1;
            this.AutoCenterTick.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "$autocenter :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.CDPath);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 24);
            this.panel5.TabIndex = 3;
            // 
            // CDPath
            // 
            this.CDPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CDPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CDPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CDPath.ForeColor = System.Drawing.Color.Silver;
            this.CDPath.Location = new System.Drawing.Point(86, 0);
            this.CDPath.Name = "CDPath";
            this.CDPath.Size = new System.Drawing.Size(231, 20);
            this.CDPath.TabIndex = 1;
            this.CDPath.Text = "only_path\\";
            this.CDPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CDPath.Leave += new System.EventHandler(this.CDPath_Leave);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "$sdmaterials :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.LodTick);
            this.panel4.Controls.Add(this.SurfaceBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 24);
            this.panel4.TabIndex = 2;
            // 
            // LodTick
            // 
            this.LodTick.AutoSize = true;
            this.LodTick.Location = new System.Drawing.Point(172, 2);
            this.LodTick.Name = "LodTick";
            this.LodTick.Size = new System.Drawing.Size(150, 17);
            this.LodTick.TabIndex = 3;
            this.LodTick.Text = "Load lods (\"name\"_lod_#)";
            this.LodTick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LodTick.UseVisualStyleBackColor = true;
            // 
            // SurfaceBox
            // 
            this.SurfaceBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SurfaceBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SurfaceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.SurfaceBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SurfaceBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SurfaceBox.ForeColor = System.Drawing.Color.Silver;
            this.SurfaceBox.FormattingEnabled = true;
            this.SurfaceBox.Items.AddRange(new object[] {
            "alienflesh",
            "antlion",
            "antlionsand",
            "armorflesh",
            "asphalt",
            "baserock",
            "bloodyflesh",
            "boulder",
            "brakingrubbertire",
            "brick",
            "canister",
            "cardboard",
            "carpet",
            "ceiling_tile",
            "chain",
            "chainlink",
            "combine_glass",
            "combine_metal",
            "computer",
            "concrete",
            "concrete_block",
            "crowbar",
            "default",
            "default_silent",
            "dirt",
            "flesh",
            "floating_metal_barrel",
            "floatingstandable",
            "foliage",
            "glass",
            "glassbottle",
            "grass",
            "gravel",
            "gravel",
            "grenade",
            "gunship",
            "ice",
            "item",
            "jeeptire",
            "ladder",
            "metal",
            "metal_barrel",
            "metal_bouncy",
            "Metal_Box",
            "metal_seafloorcar",
            "metalgrate",
            "metalpanel",
            "metalvehicle",
            "metalvent",
            "mud",
            "no_decal",
            "paintcan",
            "paper",
            "papercup",
            "plaster",
            "plastic",
            "plastic_barrel",
            "plastic_barrel_buoyant",
            "Plastic_Box",
            "player",
            "player_control_clip",
            "popcan",
            "pottery",
            "quicksand",
            "rock",
            "roller",
            "rubber",
            "rubbertire",
            "sand",
            "slidingrubbertire",
            "slidingrubbertire_front",
            "slidingrubbertire_rear",
            "slime",
            "slipperymetal",
            "slipperyslime",
            "snow",
            "solidmetal",
            "strider",
            "tile",
            "wade",
            "water",
            "watermelon",
            "weapon",
            "Wood",
            "Wood_Box",
            "Wood_Crate",
            "Wood_Furniture",
            "Wood_LowDensity",
            "Wood_Panel",
            "Wood_Plank",
            "Wood_Solid",
            "zombieflesh"});
            this.SurfaceBox.Location = new System.Drawing.Point(86, 0);
            this.SurfaceBox.Name = "SurfaceBox";
            this.SurfaceBox.Size = new System.Drawing.Size(80, 21);
            this.SurfaceBox.Sorted = true;
            this.SurfaceBox.TabIndex = 1;
            this.SurfaceBox.Text = "default";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "$surfaceprop:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.StaticTick);
            this.panel3.Controls.Add(this.ScaleNum);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 24);
            this.panel3.TabIndex = 1;
            // 
            // StaticTick
            // 
            this.StaticTick.AutoSize = true;
            this.StaticTick.Checked = true;
            this.StaticTick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StaticTick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticTick.Location = new System.Drawing.Point(86, 0);
            this.StaticTick.Name = "StaticTick";
            this.StaticTick.Size = new System.Drawing.Size(131, 22);
            this.StaticTick.TabIndex = 3;
            this.StaticTick.UseVisualStyleBackColor = true;
            this.StaticTick.CheckedChanged += new System.EventHandler(this.StaticTick_CheckedChanged);
            // 
            // ScaleNum
            // 
            this.ScaleNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ScaleNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScaleNum.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScaleNum.ForeColor = System.Drawing.Color.Silver;
            this.ScaleNum.Location = new System.Drawing.Point(217, 0);
            this.ScaleNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ScaleNum.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.ScaleNum.Name = "ScaleNum";
            this.ScaleNum.Size = new System.Drawing.Size(54, 20);
            this.ScaleNum.TabIndex = 2;
            this.ScaleNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScaleNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Location = new System.Drawing.Point(271, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = ": $scale";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "$staticprop :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ModelPath);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 24);
            this.panel2.TabIndex = 0;
            // 
            // ModelPath
            // 
            this.ModelPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ModelPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelPath.ForeColor = System.Drawing.Color.Silver;
            this.ModelPath.Location = new System.Drawing.Point(86, 0);
            this.ModelPath.Name = "ModelPath";
            this.ModelPath.Size = new System.Drawing.Size(231, 20);
            this.ModelPath.TabIndex = 0;
            this.ModelPath.Text = "only_path\\";
            this.ModelPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ModelPath.Leave += new System.EventHandler(this.ModelPath_Leave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "$modelname :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage2.Controls.Add(this.Log);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(325, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.ForeColor = System.Drawing.Color.Silver;
            this.Log.Location = new System.Drawing.Point(0, 0);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(325, 460);
            this.Log.TabIndex = 0;
            // 
            // BinBrowserDialog
            // 
            this.BinBrowserDialog.Description = "Select BIN folder of Source Game";
            this.BinBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.BinBrowserDialog.ShowNewFolderButton = false;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "Main SMDs|*.smd";
            this.OpenFileDialog.Multiselect = true;
            this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // ExitBrowserDialog
            // 
            this.ExitBrowserDialog.Description = "Select BIN folder of Source Game";
            this.ExitBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.ExitBrowserDialog.ShowNewFolderButton = false;
            // 
            // DDMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(683, 491);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DDMB";
            this.ShowIcon = false;
            this.Text = "DDMB";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.InfoTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.SequenceGBox.ResumeLayout(false);
            this.SequenceGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SqFPS)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button CompileBut;
        private System.Windows.Forms.ListBox SMD_List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OpenBut;
        private System.Windows.Forms.Button ClearBut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModelPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button GQCsBut;
        private System.Windows.Forms.Button SetBINPath;
        private System.Windows.Forms.TextBox ExitText;
        private System.Windows.Forms.ComboBox OpacityBox;
        private System.Windows.Forms.CheckBox AutoCenterTick;
        private System.Windows.Forms.CheckBox ConvexTick;
        private System.Windows.Forms.TextBox CollSufixBox;
        private System.Windows.Forms.TextBox CDPath;
        private System.Windows.Forms.ComboBox SurfaceBox;
        private System.Windows.Forms.CheckBox StaticTick;
        private System.Windows.Forms.NumericUpDown ScaleNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button PathBut;
        private System.Windows.Forms.CheckBox LodTick;
        private System.Windows.Forms.FolderBrowserDialog BinBrowserDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog ExitBrowserDialog;
        private System.Windows.Forms.TabControl InfoTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.ComboBox ModBox;
        private System.Windows.Forms.GroupBox SequenceGBox;
        private System.Windows.Forms.CheckBox SequncesTick;
        private System.Windows.Forms.NumericUpDown SqFPS;
        private System.Windows.Forms.CheckBox SqLoopTick;
        private System.Windows.Forms.Label label7;
    }
}

