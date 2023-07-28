using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading.Channels;

namespace DnDMonsterManager
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Size = new Size(400, 50) };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        public static string[] ShowDamageDialogue(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.FromArgb(24, 30, 54)
            };
            Label lbl = new Label();
            NumericUpDown numUD = new NumericUpDown();
            ComboBox cBox = new ComboBox();
            Button btnApply = new Button();
            Button btnCancel = new Button();
            prompt.SuspendLayout();
            // UI Creation Region
            #region 
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.None;
            lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.FromArgb(158, 161, 176);
            lbl.Location = new Point(0, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(500, 36);
            lbl.TabIndex = 0;
            lbl.Text = "Select Damage and Type";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numUD
            // 
            numUD.Anchor = AnchorStyles.None;
            numUD.BackColor = SystemColors.Menu;
            numUD.Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numUD.Location = new Point(124, 35);
            numUD.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUD.Name = "numUD";
            numUD.Size = new Size(90, 30);
            numUD.TabIndex = 5;
            numUD.TextAlign = HorizontalAlignment.Center;
            numUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cBox
            // 
            cBox.Anchor = AnchorStyles.None;
            cBox.BackColor = Color.FromArgb(74, 79, 99);
            cBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox.Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cBox.ForeColor = SystemColors.ScrollBar;
            cBox.FormattingEnabled = true;
            cBox.Items.AddRange(new object[] { "Generic", "Bludgeoning", "Piercing", "Slashing", "Acid", "Cold", "Fire", "Force", "Lightning", "Necrotic", "Poison", "Psychic", "Radiant", "Thunder" });
            cBox.SelectedIndex = 0;
            cBox.Location = new Point(220, 36);
            cBox.Name = "cBox";
            cBox.Size = new Size(160, 29);
            cBox.TabIndex = 10;
            // 
            // btnApply
            // 
            btnApply.Anchor = AnchorStyles.None;
            btnApply.BackColor = Color.FromArgb(46, 51, 73);
            btnApply.DialogResult = DialogResult.Cancel;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Myanmar Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnApply.ForeColor = SystemColors.ScrollBar;
            btnApply.Location = new Point(376, 71);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(96, 28);
            btnApply.TabIndex = 14;
            btnApply.Text = "Cancel";
            btnApply.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(46, 51, 73);
            btnCancel.DialogResult = DialogResult.OK;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Myanmar Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ScrollBar;
            btnCancel.Location = new Point(274, 71);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 28);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Apply";
            btnCancel.UseVisualStyleBackColor = false;

            #endregion
            prompt.Controls.Add(lbl);
            prompt.Controls.Add(numUD);
            prompt.Controls.Add(cBox);
            prompt.Controls.Add(btnApply);
            prompt.Controls.Add(btnCancel);
            btnApply.Click += (sender, e) => { prompt.Close(); };
            btnCancel.Click += (sender, e) => { prompt.Close(); };
            prompt.AcceptButton = btnApply;
            prompt.CancelButton = btnCancel;

            prompt.ResumeLayout(false);

            string[] objs = new string[] { numUD.Text, cBox.Text };
            return prompt.ShowDialog() == DialogResult.OK ? new string[] { numUD.Text, cBox.Text } : new string[] { string.Empty, string.Empty };
        }
        public static bool ShowAlert(string text, string caption) 
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Size = new Size(400, 50) };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog().Equals(DialogResult.OK);
        }
    }
}
