namespace DnDMonsterManager
{
    partial class DnDMonsterManager
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
            pnlTabs = new Panel();
            pnlNav = new Panel();
            btnOutput = new Button();
            btnExit = new Button();
            btnSettings = new Button();
            btnCreateScenario = new Button();
            btnCreateMonster = new Button();
            btnDashboard = new Button();
            pnlIcon = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pnlDashboard = new Panel();
            pnlMovableArea = new Panel();
            pnlMonster_1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            button1 = new Button();
            pnlMoveBar = new Panel();
            textBox1 = new TextBox();
            pnlCreateMonster = new Panel();
            label3 = new Label();
            pnlCrMonPadding = new Panel();
            pnlCrMonData = new TableLayoutPanel();
            CrMon_btnSave = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            CrMon_textName = new TextBox();
            label6 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label9 = new Label();
            CrMon_boolHPVar = new CheckBox();
            CrMon_intHP = new NumericUpDown();
            tableLayoutPanel4 = new TableLayoutPanel();
            label8 = new Label();
            CrMon_textType = new ComboBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label7 = new Label();
            CrMon_textSize = new ComboBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            CrMon_textLink = new TextBox();
            label1 = new Label();
            btnDeleteMonster = new Button();
            pnlCreateScenario = new Panel();
            label4 = new Label();
            pnlSettings = new Panel();
            label5 = new Label();
            pnlOutput = new Panel();
            label10 = new Label();
            pnlOutputWindow = new Panel();
            tbOutput = new TextBox();
            pnlMonsterScroll = new Panel();
            pnlScrollbar = new Panel();
            panel2 = new Panel();
            pnlTabs.SuspendLayout();
            pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDashboard.SuspendLayout();
            pnlMovableArea.SuspendLayout();
            pnlMonster_1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            pnlCreateMonster.SuspendLayout();
            pnlCrMonPadding.SuspendLayout();
            pnlCrMonData.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CrMon_intHP).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            pnlCreateScenario.SuspendLayout();
            pnlSettings.SuspendLayout();
            pnlOutput.SuspendLayout();
            pnlOutputWindow.SuspendLayout();
            pnlMonsterScroll.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabs
            // 
            pnlTabs.BackColor = Color.FromArgb(24, 30, 54);
            pnlTabs.Controls.Add(pnlNav);
            pnlTabs.Controls.Add(btnOutput);
            pnlTabs.Controls.Add(btnExit);
            pnlTabs.Controls.Add(btnSettings);
            pnlTabs.Controls.Add(btnCreateScenario);
            pnlTabs.Controls.Add(btnCreateMonster);
            pnlTabs.Controls.Add(btnDashboard);
            pnlTabs.Controls.Add(pnlIcon);
            pnlTabs.Dock = DockStyle.Left;
            pnlTabs.Location = new Point(0, 0);
            pnlTabs.Name = "pnlTabs";
            pnlTabs.Size = new Size(228, 861);
            pnlTabs.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 144);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 42);
            pnlNav.TabIndex = 2;
            // 
            // btnOutput
            // 
            btnOutput.Dock = DockStyle.Bottom;
            btnOutput.FlatAppearance.BorderSize = 0;
            btnOutput.FlatStyle = FlatStyle.Flat;
            btnOutput.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOutput.ForeColor = Color.FromArgb(0, 126, 249);
            btnOutput.Location = new Point(0, 777);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(228, 42);
            btnOutput.TabIndex = 1;
            btnOutput.Text = "System Output";
            btnOutput.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOutput.UseVisualStyleBackColor = true;
            btnOutput.Click += btnTab_Click;
            btnOutput.Leave += btnTab_Leave;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(0, 126, 249);
            btnExit.Location = new Point(0, 819);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(228, 42);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnQuit_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.FromArgb(0, 126, 249);
            btnSettings.Location = new Point(0, 270);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(228, 42);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnTab_Click;
            btnSettings.Leave += btnTab_Leave;
            // 
            // btnCreateScenario
            // 
            btnCreateScenario.Dock = DockStyle.Top;
            btnCreateScenario.FlatAppearance.BorderSize = 0;
            btnCreateScenario.FlatStyle = FlatStyle.Flat;
            btnCreateScenario.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateScenario.ForeColor = Color.FromArgb(0, 126, 249);
            btnCreateScenario.Location = new Point(0, 228);
            btnCreateScenario.Name = "btnCreateScenario";
            btnCreateScenario.Size = new Size(228, 42);
            btnCreateScenario.TabIndex = 1;
            btnCreateScenario.Text = "Scenarios";
            btnCreateScenario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateScenario.UseVisualStyleBackColor = true;
            btnCreateScenario.Click += btnTab_Click;
            btnCreateScenario.Leave += btnTab_Leave;
            // 
            // btnCreateMonster
            // 
            btnCreateMonster.Dock = DockStyle.Top;
            btnCreateMonster.FlatAppearance.BorderSize = 0;
            btnCreateMonster.FlatStyle = FlatStyle.Flat;
            btnCreateMonster.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateMonster.ForeColor = Color.FromArgb(0, 126, 249);
            btnCreateMonster.Location = new Point(0, 186);
            btnCreateMonster.Name = "btnCreateMonster";
            btnCreateMonster.Size = new Size(228, 42);
            btnCreateMonster.TabIndex = 1;
            btnCreateMonster.Text = "Monsters";
            btnCreateMonster.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateMonster.UseVisualStyleBackColor = true;
            btnCreateMonster.Click += btnTab_Click;
            btnCreateMonster.Leave += btnTab_Leave;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            btnDashboard.Location = new Point(0, 144);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(228, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnTab_Click;
            btnDashboard.Leave += btnTab_Leave;
            // 
            // pnlIcon
            // 
            pnlIcon.Controls.Add(pictureBox1);
            pnlIcon.Dock = DockStyle.Top;
            pnlIcon.Location = new Point(0, 0);
            pnlIcon.Name = "pnlIcon";
            pnlIcon.Size = new Size(228, 144);
            pnlIcon.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.certifiablyinsane;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(158, 161, 176);
            label2.Location = new Point(36, 33);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 1;
            label2.Text = "Dashboard";
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(label2);
            pnlDashboard.Controls.Add(pnlMovableArea);
            pnlDashboard.Dock = DockStyle.Fill;
            pnlDashboard.Location = new Point(228, 0);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Padding = new Padding(32, 96, 32, 32);
            pnlDashboard.Size = new Size(1129, 861);
            pnlDashboard.TabIndex = 2;
            // 
            // pnlMovableArea
            // 
            pnlMovableArea.BackColor = Color.FromArgb(37, 42, 64);
            pnlMovableArea.Controls.Add(pnlMonster_1);
            pnlMovableArea.Dock = DockStyle.Fill;
            pnlMovableArea.Location = new Point(32, 96);
            pnlMovableArea.Name = "pnlMovableArea";
            pnlMovableArea.Size = new Size(1065, 733);
            pnlMovableArea.TabIndex = 2;
            // 
            // pnlMonster_1
            // 
            pnlMonster_1.Controls.Add(tableLayoutPanel1);
            pnlMonster_1.Location = new Point(32, 39);
            pnlMonster_1.Name = "pnlMonster_1";
            pnlMonster_1.Size = new Size(233, 373);
            pnlMonster_1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(24, 30, 54);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(233, 373);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.FromArgb(158, 161, 176);
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel7.Controls.Add(button1, 1, 0);
            tableLayoutPanel7.Controls.Add(pnlMoveBar, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(233, 32);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(205, 4);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(24, 24);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // pnlMoveBar
            // 
            pnlMoveBar.BackColor = Color.FromArgb(158, 161, 176);
            pnlMoveBar.Dock = DockStyle.Fill;
            pnlMoveBar.Location = new Point(0, 0);
            pnlMoveBar.Margin = new Padding(0);
            pnlMoveBar.Name = "pnlMoveBar";
            pnlMoveBar.Size = new Size(201, 32);
            pnlMoveBar.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(74, 79, 99);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(16, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Monsters...";
            textBox1.Size = new Size(194, 32);
            textBox1.TabIndex = 2;
            // 
            // pnlCreateMonster
            // 
            pnlCreateMonster.AutoSize = true;
            pnlCreateMonster.Controls.Add(label3);
            pnlCreateMonster.Controls.Add(pnlCrMonPadding);
            pnlCreateMonster.Dock = DockStyle.Fill;
            pnlCreateMonster.Location = new Point(228, 0);
            pnlCreateMonster.Name = "pnlCreateMonster";
            pnlCreateMonster.Size = new Size(1129, 861);
            pnlCreateMonster.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(20, 17);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 1;
            label3.Text = "Monsters";
            // 
            // pnlCrMonPadding
            // 
            pnlCrMonPadding.Controls.Add(pnlCrMonData);
            pnlCrMonPadding.Controls.Add(btnDeleteMonster);
            pnlCrMonPadding.Dock = DockStyle.Fill;
            pnlCrMonPadding.Location = new Point(0, 0);
            pnlCrMonPadding.Name = "pnlCrMonPadding";
            pnlCrMonPadding.Padding = new Padding(64, 64, 64, 128);
            pnlCrMonPadding.Size = new Size(1129, 861);
            pnlCrMonPadding.TabIndex = 6;
            // 
            // pnlCrMonData
            // 
            pnlCrMonData.BackColor = Color.FromArgb(37, 42, 64);
            pnlCrMonData.ColumnCount = 1;
            pnlCrMonData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlCrMonData.Controls.Add(CrMon_btnSave, 0, 5);
            pnlCrMonData.Controls.Add(tableLayoutPanel2, 0, 0);
            pnlCrMonData.Controls.Add(tableLayoutPanel3, 0, 1);
            pnlCrMonData.Controls.Add(tableLayoutPanel4, 0, 2);
            pnlCrMonData.Controls.Add(tableLayoutPanel5, 0, 3);
            pnlCrMonData.Controls.Add(tableLayoutPanel6, 0, 4);
            pnlCrMonData.Dock = DockStyle.Fill;
            pnlCrMonData.Location = new Point(64, 64);
            pnlCrMonData.MinimumSize = new Size(337, 450);
            pnlCrMonData.Name = "pnlCrMonData";
            pnlCrMonData.RowCount = 6;
            pnlCrMonData.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlCrMonData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlCrMonData.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlCrMonData.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlCrMonData.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlCrMonData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlCrMonData.Size = new Size(1001, 669);
            pnlCrMonData.TabIndex = 5;
            // 
            // CrMon_btnSave
            // 
            CrMon_btnSave.Anchor = AnchorStyles.None;
            CrMon_btnSave.BackColor = Color.FromArgb(24, 30, 54);
            CrMon_btnSave.FlatStyle = FlatStyle.Flat;
            CrMon_btnSave.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CrMon_btnSave.ForeColor = SystemColors.ScrollBar;
            CrMon_btnSave.Location = new Point(422, 582);
            CrMon_btnSave.Name = "CrMon_btnSave";
            CrMon_btnSave.Size = new Size(157, 37);
            CrMon_btnSave.TabIndex = 13;
            CrMon_btnSave.Text = "Save Monster";
            CrMon_btnSave.UseVisualStyleBackColor = false;
            CrMon_btnSave.Click += CrMon_btnSave_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(CrMon_textName, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Location = new Point(376, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(249, 61);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // CrMon_textName
            // 
            CrMon_textName.Anchor = AnchorStyles.None;
            CrMon_textName.BackColor = SystemColors.Menu;
            CrMon_textName.BorderStyle = BorderStyle.None;
            CrMon_textName.Cursor = Cursors.IBeam;
            CrMon_textName.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CrMon_textName.ForeColor = SystemColors.WindowText;
            CrMon_textName.Location = new Point(25, 33);
            CrMon_textName.Name = "CrMon_textName";
            CrMon_textName.PlaceholderText = "Enter Name...";
            CrMon_textName.Size = new Size(198, 30);
            CrMon_textName.TabIndex = 3;
            CrMon_textName.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(158, 161, 176);
            label6.Location = new Point(85, 2);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 4;
            label6.Text = "Name:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Controls.Add(CrMon_boolHPVar, 0, 2);
            tableLayoutPanel3.Controls.Add(CrMon_intHP, 0, 1);
            tableLayoutPanel3.Location = new Point(392, 124);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Size = new Size(217, 84);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(158, 161, 176);
            label9.Location = new Point(53, 0);
            label9.Name = "label9";
            label9.Size = new Size(110, 25);
            label9.TabIndex = 10;
            label9.Text = "Base HP:";
            // 
            // CrMon_boolHPVar
            // 
            CrMon_boolHPVar.Anchor = AnchorStyles.None;
            CrMon_boolHPVar.AutoSize = true;
            CrMon_boolHPVar.Checked = true;
            CrMon_boolHPVar.CheckState = CheckState.Checked;
            CrMon_boolHPVar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            CrMon_boolHPVar.ForeColor = Color.FromArgb(158, 161, 176);
            CrMon_boolHPVar.Location = new Point(50, 62);
            CrMon_boolHPVar.Name = "CrMon_boolHPVar";
            CrMon_boolHPVar.Size = new Size(117, 17);
            CrMon_boolHPVar.TabIndex = 12;
            CrMon_boolHPVar.Text = "Allow Variation?";
            CrMon_boolHPVar.UseVisualStyleBackColor = true;
            // 
            // CrMon_intHP
            // 
            CrMon_intHP.Anchor = AnchorStyles.None;
            CrMon_intHP.BackColor = SystemColors.Menu;
            CrMon_intHP.Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CrMon_intHP.Location = new Point(63, 28);
            CrMon_intHP.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            CrMon_intHP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CrMon_intHP.Name = "CrMon_intHP";
            CrMon_intHP.Size = new Size(90, 30);
            CrMon_intHP.TabIndex = 4;
            CrMon_intHP.TextAlign = HorizontalAlignment.Center;
            CrMon_intHP.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label8, 0, 0);
            tableLayoutPanel4.Controls.Add(CrMon_textType, 0, 1);
            tableLayoutPanel4.Location = new Point(400, 252);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(200, 61);
            tableLayoutPanel4.TabIndex = 16;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(158, 161, 176);
            label8.Location = new Point(64, 2);
            label8.Name = "label8";
            label8.Size = new Size(71, 25);
            label8.TabIndex = 8;
            label8.Text = "Type:";
            // 
            // CrMon_textType
            // 
            CrMon_textType.Anchor = AnchorStyles.None;
            CrMon_textType.BackColor = Color.FromArgb(74, 79, 99);
            CrMon_textType.DropDownStyle = ComboBoxStyle.DropDownList;
            CrMon_textType.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CrMon_textType.ForeColor = SystemColors.ScrollBar;
            CrMon_textType.FormattingEnabled = true;
            CrMon_textType.Items.AddRange(new object[] { "<Pick Type>", "Aberration", "Beast", "Celestial", "Construct", "Dragon", "Elemental", "Fey", "Fiend", "Giant", "Humanoid", "Monstrosity", "Ooze", "Plant", "Undead" });
            CrMon_textType.Location = new Point(31, 33);
            CrMon_textType.Name = "CrMon_textType";
            CrMon_textType.Size = new Size(138, 37);
            CrMon_textType.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.None;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label7, 0, 0);
            tableLayoutPanel5.Controls.Add(CrMon_textSize, 0, 1);
            tableLayoutPanel5.Location = new Point(402, 352);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(197, 61);
            tableLayoutPanel5.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(158, 161, 176);
            label7.Location = new Point(66, 2);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 7;
            label7.Text = "Size:";
            // 
            // CrMon_textSize
            // 
            CrMon_textSize.Anchor = AnchorStyles.None;
            CrMon_textSize.BackColor = Color.FromArgb(74, 79, 99);
            CrMon_textSize.DropDownStyle = ComboBoxStyle.DropDownList;
            CrMon_textSize.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CrMon_textSize.ForeColor = SystemColors.ScrollBar;
            CrMon_textSize.FormattingEnabled = true;
            CrMon_textSize.Items.AddRange(new object[] { "<Pick Type>", "Tiny", "Small", "Medium", "Large", "Huge", "Gargantuan" });
            CrMon_textSize.Location = new Point(29, 33);
            CrMon_textSize.Name = "CrMon_textSize";
            CrMon_textSize.Size = new Size(138, 37);
            CrMon_textSize.TabIndex = 6;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.None;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(CrMon_textLink, 0, 1);
            tableLayoutPanel6.Controls.Add(label1, 0, 0);
            tableLayoutPanel6.Location = new Point(310, 452);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(381, 61);
            tableLayoutPanel6.TabIndex = 18;
            // 
            // CrMon_textLink
            // 
            CrMon_textLink.Anchor = AnchorStyles.None;
            CrMon_textLink.BackColor = SystemColors.Menu;
            CrMon_textLink.BorderStyle = BorderStyle.None;
            CrMon_textLink.Cursor = Cursors.IBeam;
            CrMon_textLink.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CrMon_textLink.ForeColor = SystemColors.WindowText;
            CrMon_textLink.Location = new Point(8, 33);
            CrMon_textLink.Name = "CrMon_textLink";
            CrMon_textLink.PlaceholderText = "dndbeyond.com/monsters/#####-monster-name";
            CrMon_textLink.Size = new Size(364, 30);
            CrMon_textLink.TabIndex = 3;
            CrMon_textLink.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(158, 161, 176);
            label1.Location = new Point(46, 2);
            label1.Name = "label1";
            label1.Size = new Size(289, 25);
            label1.TabIndex = 7;
            label1.Text = "Link To Source: (Optional)";
            // 
            // btnDeleteMonster
            // 
            btnDeleteMonster.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteMonster.BackColor = Color.FromArgb(24, 30, 54);
            btnDeleteMonster.FlatStyle = FlatStyle.Flat;
            btnDeleteMonster.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteMonster.ForeColor = SystemColors.ScrollBar;
            btnDeleteMonster.Location = new Point(908, 17);
            btnDeleteMonster.Name = "btnDeleteMonster";
            btnDeleteMonster.Size = new Size(157, 37);
            btnDeleteMonster.TabIndex = 13;
            btnDeleteMonster.Text = "Delete Monster";
            btnDeleteMonster.UseVisualStyleBackColor = false;
            btnDeleteMonster.Click += btnDeleteMonster_Click;
            // 
            // pnlCreateScenario
            // 
            pnlCreateScenario.Controls.Add(label4);
            pnlCreateScenario.Dock = DockStyle.Fill;
            pnlCreateScenario.Location = new Point(228, 0);
            pnlCreateScenario.Name = "pnlCreateScenario";
            pnlCreateScenario.Size = new Size(1356, 861);
            pnlCreateScenario.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(158, 161, 176);
            label4.Location = new Point(20, 17);
            label4.Name = "label4";
            label4.Size = new Size(301, 32);
            label4.TabIndex = 1;
            label4.Text = "Create New Scenario";
            // 
            // pnlSettings
            // 
            pnlSettings.Controls.Add(label5);
            pnlSettings.Dock = DockStyle.Fill;
            pnlSettings.Location = new Point(228, 0);
            pnlSettings.Name = "pnlSettings";
            pnlSettings.Size = new Size(1356, 861);
            pnlSettings.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(158, 161, 176);
            label5.Location = new Point(20, 17);
            label5.Name = "label5";
            label5.Size = new Size(126, 32);
            label5.TabIndex = 1;
            label5.Text = "Settings";
            // 
            // pnlOutput
            // 
            pnlOutput.Controls.Add(label10);
            pnlOutput.Controls.Add(pnlOutputWindow);
            pnlOutput.Dock = DockStyle.Fill;
            pnlOutput.Location = new Point(228, 0);
            pnlOutput.Name = "pnlOutput";
            pnlOutput.Size = new Size(1356, 861);
            pnlOutput.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(158, 161, 176);
            label10.Location = new Point(20, 17);
            label10.Name = "label10";
            label10.Size = new Size(214, 32);
            label10.TabIndex = 1;
            label10.Text = "System Output";
            // 
            // pnlOutputWindow
            // 
            pnlOutputWindow.BackColor = Color.FromArgb(46, 51, 73);
            pnlOutputWindow.Controls.Add(tbOutput);
            pnlOutputWindow.Dock = DockStyle.Fill;
            pnlOutputWindow.Location = new Point(0, 0);
            pnlOutputWindow.Margin = new Padding(32, 96, 32, 32);
            pnlOutputWindow.Name = "pnlOutputWindow";
            pnlOutputWindow.Padding = new Padding(32, 96, 32, 32);
            pnlOutputWindow.Size = new Size(1356, 861);
            pnlOutputWindow.TabIndex = 2;
            // 
            // tbOutput
            // 
            tbOutput.BackColor = Color.FromArgb(37, 42, 64);
            tbOutput.Dock = DockStyle.Fill;
            tbOutput.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbOutput.ForeColor = Color.FromArgb(0, 126, 249);
            tbOutput.Location = new Point(32, 96);
            tbOutput.Margin = new Padding(0);
            tbOutput.Multiline = true;
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.ScrollBars = ScrollBars.Vertical;
            tbOutput.Size = new Size(1292, 733);
            tbOutput.TabIndex = 0;
            // 
            // pnlMonsterScroll
            // 
            pnlMonsterScroll.BackColor = Color.FromArgb(24, 30, 54);
            pnlMonsterScroll.Controls.Add(pnlScrollbar);
            pnlMonsterScroll.Controls.Add(panel2);
            pnlMonsterScroll.Dock = DockStyle.Right;
            pnlMonsterScroll.Location = new Point(1357, 0);
            pnlMonsterScroll.Name = "pnlMonsterScroll";
            pnlMonsterScroll.Size = new Size(227, 861);
            pnlMonsterScroll.TabIndex = 4;
            // 
            // pnlScrollbar
            // 
            pnlScrollbar.AutoScroll = true;
            pnlScrollbar.Location = new Point(16, 85);
            pnlScrollbar.Name = "pnlScrollbar";
            pnlScrollbar.Size = new Size(194, 526);
            pnlScrollbar.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 85);
            panel2.TabIndex = 3;
            // 
            // DnDMonsterManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1584, 861);
            Controls.Add(pnlCreateMonster);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlMonsterScroll);
            Controls.Add(pnlOutput);
            Controls.Add(pnlSettings);
            Controls.Add(pnlCreateScenario);
            Controls.Add(pnlTabs);
            MaximumSize = new Size(1600, 900);
            MinimumSize = new Size(1024, 650);
            Name = "DnDMonsterManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "D&D Monster Manager";
            Load += Form1_Load;
            pnlTabs.ResumeLayout(false);
            pnlIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDashboard.ResumeLayout(false);
            pnlMovableArea.ResumeLayout(false);
            pnlMonster_1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            pnlCreateMonster.ResumeLayout(false);
            pnlCreateMonster.PerformLayout();
            pnlCrMonPadding.ResumeLayout(false);
            pnlCrMonData.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CrMon_intHP).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            pnlCreateScenario.ResumeLayout(false);
            pnlCreateScenario.PerformLayout();
            pnlSettings.ResumeLayout(false);
            pnlSettings.PerformLayout();
            pnlOutput.ResumeLayout(false);
            pnlOutput.PerformLayout();
            pnlOutputWindow.ResumeLayout(false);
            pnlOutputWindow.PerformLayout();
            pnlMonsterScroll.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTabs;
        private Panel pnlIcon;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnExit;
        private Button btnSettings;
        private Button btnCreateScenario;
        private Button btnCreateMonster;
        private Panel pnlNav;
        private Label label2;
        private Panel pnlDashboard;
        private TextBox textBox1;
        private Panel pnlCreateMonster;
        private Label label3;
        private Panel pnlCreateScenario;
        private Label label4;
        private Panel pnlSettings;
        private Label label5;
        private TextBox CrMon_textName;
        private Label label6;
        private Label label7;
        private ComboBox CrMon_textSize;
        private ComboBox CrMon_textType;
        private Label label8;
        private Label label9;
        private CheckBox CrMon_boolHPVar;
        private Button CrMon_btnSave;
        private Button btnOutput;
        private Panel pnlOutput;
        private Label label10;
        private Panel pnlOutputWindow;
        public TextBox tbOutput;
        private NumericUpDown CrMon_intHP;
        private Panel pnlMonsterScroll;
        private Panel panel2;
        private Panel pnlScrollbar;
        private TableLayoutPanel pnlCrMonData;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel pnlCrMonPadding;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox CrMon_textLink;
        private Label label1;
        private Button btnDeleteMonster;
        private Panel pnlMovableArea;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel7;
        private Button button1;
        private Panel pnlMoveBar;
        private Panel pnlMonster_1;
    }
}