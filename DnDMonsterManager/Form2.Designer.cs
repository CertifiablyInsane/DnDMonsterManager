namespace DnDMonsterManager
{
    partial class Form2
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
            pnlMonster_1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            button1 = new Button();
            pnlMoveBar = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            CrMon_btnSave = new Button();
            button2 = new Button();
            pnlMonster_1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMonster_1
            // 
            pnlMonster_1.Controls.Add(tableLayoutPanel1);
            pnlMonster_1.Location = new Point(284, 39);
            pnlMonster_1.MinimumSize = new Size(172, 276);
            pnlMonster_1.Name = "pnlMonster_1";
            pnlMonster_1.Size = new Size(216, 343);
            pnlMonster_1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(24, 30, 54);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(216, 343);
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
            tableLayoutPanel7.Size = new Size(216, 32);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(188, 4);
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
            pnlMoveBar.Size = new Size(184, 32);
            pnlMoveBar.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel2.Controls.Add(button2, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 35);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.Size = new Size(210, 305);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(numericUpDown1, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(204, 26);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(46, 51, 73);
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.ForeColor = Color.FromArgb(158, 161, 176);
            numericUpDown1.Location = new Point(3, 3);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(42, 21);
            numericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(158, 161, 176);
            label1.Location = new Point(51, 6);
            label1.Name = "label1";
            label1.Size = new Size(46, 13);
            label1.TabIndex = 1;
            label1.Text = "Initiative";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(158, 161, 176);
            label2.Location = new Point(31, 44);
            label2.Name = "label2";
            label2.Size = new Size(148, 48);
            label2.TabIndex = 1;
            label2.Text = "ANCIENT RED DRAGON";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(label4, 0, 1);
            tableLayoutPanel4.Controls.Add(CrMon_btnSave, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 107);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.Size = new Size(204, 162);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(77, 26);
            label3.Margin = new Padding(6);
            label3.Name = "label3";
            label3.Size = new Size(49, 16);
            label3.TabIndex = 0;
            label3.Text = "Health:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(81, 54);
            label4.Margin = new Padding(6);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 1;
            label4.Text = "576";
            // 
            // CrMon_btnSave
            // 
            CrMon_btnSave.Anchor = AnchorStyles.None;
            CrMon_btnSave.BackColor = Color.FromArgb(24, 30, 54);
            CrMon_btnSave.FlatStyle = FlatStyle.Flat;
            CrMon_btnSave.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CrMon_btnSave.ForeColor = SystemColors.ScrollBar;
            CrMon_btnSave.Location = new Point(23, 110);
            CrMon_btnSave.Name = "CrMon_btnSave";
            CrMon_btnSave.Size = new Size(157, 37);
            CrMon_btnSave.TabIndex = 14;
            CrMon_btnSave.Text = "Damage Monster";
            CrMon_btnSave.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Image = Properties.Resources.info_24;
            button2.Location = new Point(3, 275);
            button2.Name = "button2";
            button2.Size = new Size(32, 27);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 523);
            Controls.Add(pnlMonster_1);
            Name = "Form2";
            Text = "Form2";
            pnlMonster_1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMonster_1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel7;
        private Button button1;
        private Panel pnlMoveBar;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Label label4;
        private Button CrMon_btnSave;
        private Button button2;
    }
}