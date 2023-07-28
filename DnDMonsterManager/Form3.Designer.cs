namespace DnDMonsterManager
{
    partial class Form3
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
            label1 = new Label();
            CrMon_intHP = new NumericUpDown();
            CrMon_textType = new ComboBox();
            CrMon_btnSave = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)CrMon_intHP).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(158, 161, 176);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(500, 36);
            label1.TabIndex = 0;
            label1.Text = "Select Damage and Type";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CrMon_intHP
            // 
            CrMon_intHP.Anchor = AnchorStyles.None;
            CrMon_intHP.BackColor = SystemColors.Menu;
            CrMon_intHP.Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CrMon_intHP.Location = new Point(124, 35);
            CrMon_intHP.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            CrMon_intHP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CrMon_intHP.Name = "CrMon_intHP";
            CrMon_intHP.Size = new Size(90, 30);
            CrMon_intHP.TabIndex = 5;
            CrMon_intHP.TextAlign = HorizontalAlignment.Center;
            CrMon_intHP.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CrMon_textType
            // 
            CrMon_textType.Anchor = AnchorStyles.None;
            CrMon_textType.BackColor = Color.FromArgb(74, 79, 99);
            CrMon_textType.DropDownStyle = ComboBoxStyle.DropDownList;
            CrMon_textType.Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CrMon_textType.ForeColor = SystemColors.ScrollBar;
            CrMon_textType.FormattingEnabled = true;
            CrMon_textType.Items.AddRange(new object[] { "<Pick Type>", "Aberration", "Beast", "Celestial", "Construct", "Dragon", "Elemental", "Fey", "Fiend", "Giant", "Humanoid", "Monstrosity", "Ooze", "Plant", "Undead" });
            CrMon_textType.Location = new Point(220, 36);
            CrMon_textType.Name = "CrMon_textType";
            CrMon_textType.Size = new Size(160, 29);
            CrMon_textType.TabIndex = 10;
            // 
            // CrMon_btnSave
            // 
            CrMon_btnSave.Anchor = AnchorStyles.None;
            CrMon_btnSave.BackColor = Color.FromArgb(46, 51, 73);
            CrMon_btnSave.DialogResult = DialogResult.Cancel;
            CrMon_btnSave.FlatStyle = FlatStyle.Flat;
            CrMon_btnSave.Font = new Font("Myanmar Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CrMon_btnSave.ForeColor = SystemColors.ScrollBar;
            CrMon_btnSave.Location = new Point(376, 71);
            CrMon_btnSave.Name = "CrMon_btnSave";
            CrMon_btnSave.Size = new Size(96, 28);
            CrMon_btnSave.TabIndex = 14;
            CrMon_btnSave.Text = "Cancel";
            CrMon_btnSave.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(46, 51, 73);
            button1.DialogResult = DialogResult.OK;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Myanmar Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ScrollBar;
            button1.Location = new Point(274, 71);
            button1.Name = "button1";
            button1.Size = new Size(96, 28);
            button1.TabIndex = 14;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(484, 111);
            Controls.Add(button1);
            Controls.Add(CrMon_btnSave);
            Controls.Add(CrMon_textType);
            Controls.Add(CrMon_intHP);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)CrMon_intHP).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private NumericUpDown CrMon_intHP;
        private ComboBox CrMon_textType;
        private Button CrMon_btnSave;
        private Button button1;
    }
}