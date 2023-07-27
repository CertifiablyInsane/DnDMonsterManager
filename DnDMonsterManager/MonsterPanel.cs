using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMonsterManager
{
    public class MonsterPanel
    {
        private Point start;

        private MonsterData data;
        private Panel moveableArea;
        private Panel parentPanel;
        private Panel moveBar;
        public MonsterPanel(MonsterData sourceData, Panel moveableArea) 
        { 
            data = sourceData;
            this.moveableArea = moveableArea;

            // UI Creation Here
            parentPanel = new();
            parentPanel.SetBounds(32, 32, 256, 384);    parentPanel.BackColor = Color.FromArgb(37, 42, 64);
            parentPanel.Parent = moveableArea;
        
            TableLayoutPanel tPnl1 = new();
            tPnl1.BackColor = Color.FromArgb(24, 30, 54);   tPnl1.Dock = DockStyle.Fill;
            tPnl1.ColumnCount = 1;  tPnl1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            tPnl1.RowCount = 2;     tPnl1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));  tPnl1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tPnl1.Parent = parentPanel;

            TableLayoutPanel tPnlTop = new();
            tPnlTop.BackColor = Color.FromArgb(158, 161, 176); tPnlTop.Dock = DockStyle.Fill;
            tPnlTop.ColumnCount = 2; tPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f)); tPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32f));
            tPnlTop.RowCount = 1; tPnlTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tPnlTop.Margin = Padding.Empty;
            tPnlTop.Parent = tPnl1;

            moveBar = new();
            moveBar.BackColor = Color.FromArgb(158, 161, 176);  moveBar.Dock = DockStyle.Fill;
            moveBar.Margin = Padding.Empty;
            moveBar.Parent = tPnlTop; moveBar.MouseDown += pnlMoveable_MouseDown;

            Button btnClose = new();
            btnClose.BackColor = Color.Red; btnClose.ForeColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10f, FontStyle.Bold);  btnClose.Text = "X";
            btnClose.Dock = DockStyle.Fill; btnClose.Margin = new Padding(4);
            btnClose.Parent = tPnlTop;
            // TODO: Add closing functionality

            TableLayoutPanel tPnl2 = new();
            tPnl2.BackColor = Color.FromArgb(24, 30, 54); tPnl2.Dock = DockStyle.Fill;
            tPnl2.ColumnCount = 1; tPnl2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            tPnl2.RowCount = 5; tPnl2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f)); 
            tPnl2.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));   tPnl2.RowStyles.Add(new RowStyle(SizeType.Percent, 40f));
            tPnl2.RowStyles.Add(new RowStyle(SizeType.Percent, 40f));   tPnl2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
            tPnl2.Parent = tPnl1;

            TableLayoutPanel tPnl3 = new();
            tPnl3.BackColor = Color.FromArgb(24, 30, 54); tPnl3.Dock = DockStyle.Fill;
            tPnl3.ColumnCount = 2; tPnl3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48f)); tPnl3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            tPnl3.RowCount = 1; tPnl3.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tPnl3.Parent = tPnl2;

            NumericUpDown numUD = new();
            numUD.BackColor = Color.FromArgb(46, 51, 73);   numUD.BorderStyle = BorderStyle.None;
            numUD.Font = new Font("Segoe UI", 10f); numUD.ForeColor = Color.FromArgb(158, 161, 176);
            numUD.Parent = tPnl3;
            // TODO: Add Initiave non-duplication

            Label lbl1 = new();
            lbl1.BackColor = Color.FromArgb(24, 30, 54);    lbl1.Text = "Initiative";
            lbl1.Font = new Font("Microsoft Sans Serif", 8f);   lbl1.ForeColor = Color.FromArgb(158, 161, 176);
            lbl1.Anchor = AnchorStyles.Left; lbl1.AutoSize = true; lbl1.Margin = new Padding(0, 3, 0, 3);
            lbl1.Parent = tPnl3;

            Label lbl2 = new();
            lbl2.BackColor = Color.FromArgb(24, 30, 54); lbl2.Text = data._name.ToUpper();
            lbl2.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold); lbl2.ForeColor = Color.FromArgb(158, 161, 176);
            lbl2.TextAlign = ContentAlignment.MiddleCenter; lbl2.Anchor = AnchorStyles.None; lbl2.AutoSize = true;
            lbl2.Margin = new Padding(0, 3, 0, 3);  lbl2.Parent = tPnl2;

            TableLayoutPanel tPnl4 = new();
            tPnl4.BackColor = Color.FromArgb(24, 30, 54); tPnl4.Dock = DockStyle.Fill;
            tPnl4.ColumnCount = 1; tPnl4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            tPnl4.RowCount = 3; tPnl4.RowStyles.Add(new RowStyle(SizeType.Percent, 20f)); tPnl4.RowStyles.Add(new RowStyle(SizeType.Percent, 35f)); 
            tPnl4.RowStyles.Add(new RowStyle(SizeType.Percent, 45f));
            tPnl4.Margin = new Padding(2);
            tPnl4.Parent = tPnl2;

            Label lbl3 = new();
            lbl3.BackColor = Color.FromArgb(24, 30, 54); lbl3.Text = "Health:";
            lbl3.Font = new Font("Microsoft Sans Serif", 9.75f); lbl3.ForeColor = Color.FromArgb(158, 161, 176);
            lbl3.Anchor = AnchorStyles.Bottom; lbl3.AutoSize = true;
            lbl3.Margin = new Padding(2); lbl3.Parent = tPnl4;
            
            Label lbl4 = new();
            lbl4.BackColor = Color.FromArgb(24, 30, 54); lbl4.Text = data._maxHp.ToString();
            lbl4.Font = new Font("Segoe UI", 14f); lbl4.ForeColor = Color.FromArgb(0, 126, 249);
            lbl4.Anchor = AnchorStyles.Top; lbl4.AutoSize = true;
            lbl4.Margin = new Padding(2); lbl4.Parent = tPnl4;

            TableLayoutPanel tPnl5 = new();
            tPnl5.BackColor = Color.FromArgb(24, 30, 54); tPnl5.Dock = DockStyle.Fill;
            tPnl5.ColumnCount = 2; tPnl5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f)); tPnl5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tPnl5.RowCount = 1; tPnl5.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tPnl5.Parent = tPnl4;

            Button btnHit = new();
            btnHit.BackColor = Color.FromArgb(24, 30, 54);  btnHit.ForeColor = Color.FromArgb(200, 200, 200);
            btnHit.FlatStyle = FlatStyle.Flat;
            btnHit.Font = new Font("Myanmar Text", 12f);    btnHit.Text = "Hit!";   btnHit.TextAlign = ContentAlignment.MiddleCenter;
            btnHit.Anchor = AnchorStyles.None; btnHit.Dock = DockStyle.Fill; btnHit.Parent = tPnl5;
            // TODO: Add Button Hit Code

            Button btnCrit = new();
            btnCrit.BackColor = Color.FromArgb(24, 30, 54); btnCrit.ForeColor = Color.FromArgb(200, 200, 200);
            btnCrit.FlatStyle = FlatStyle.Flat;
            btnCrit.Font = new Font("Myanmar Text", 12f); btnCrit.Text = "Crit!"; btnCrit.TextAlign = ContentAlignment.MiddleCenter;
            btnCrit.Anchor = AnchorStyles.None; btnCrit.Dock = DockStyle.Fill; btnCrit.Parent = tPnl5;
            // TODO: Add Button Crit Code

            TableLayoutPanel tPnl6 = new();
            tPnl6.BackColor = Color.FromArgb(24, 30, 54); tPnl6.Dock = DockStyle.Fill;
            tPnl6.ColumnCount = 1; tPnl6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            tPnl6.RowCount = 2; tPnl6.RowStyles.Add(new RowStyle(SizeType.Percent, 20f)); tPnl6.RowStyles.Add(new RowStyle(SizeType.Percent, 80f));
            tPnl6.Parent = tPnl2;

            Label lbl5 = new();
            lbl5.BackColor = Color.FromArgb(24, 30, 54); lbl5.Text = "Status Effects:";
            lbl5.Font = new Font("Microsoft Sans Serif", 9.75f); lbl5.ForeColor = Color.FromArgb(158, 161, 176);
            lbl5.Anchor = AnchorStyles.Bottom; lbl5.AutoSize = true;
            lbl5.Margin = new Padding(2);  lbl5.Parent = tPnl6;

            TextBox tb1 = new();
            tb1.BackColor = Color.FromArgb(46, 51, 73); tb1.BorderStyle = BorderStyle.None;
            tb1.ForeColor = Color.FromArgb(158, 161, 176);  tb1.ScrollBars = ScrollBars.Vertical;
            tb1.Multiline = true;   tb1.Dock = DockStyle.Fill;  tb1.PlaceholderText = "None";
            tb1.Parent = tPnl6;

            Button btnInfo = new();
            btnInfo.BackColor = Color.FromArgb(24, 30, 54); btnInfo.Image = Properties.Resources.info_24;
            btnInfo.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            btnInfo.FlatStyle = FlatStyle.Flat; btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.Size = new Size(32, 27);
            btnInfo.Parent = tPnl2;
            // Add info functionality
        }

        public void Destroy()
        {
            parentPanel.Dispose();
        }

        private void pnlMoveable_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                start = e.Location;
                moveBar.MouseUp += new MouseEventHandler(pnlMoveable_MouseUp);
                moveBar.MouseMove += new MouseEventHandler(pnlMoveable_MouseMove);
            }
        }
        private void pnlMoveable_MouseUp(object? sender, MouseEventArgs e)
        {
            moveBar.MouseUp -= new MouseEventHandler(pnlMoveable_MouseUp);
            moveBar.MouseMove -= new MouseEventHandler(pnlMoveable_MouseMove);
        }
        private void pnlMoveable_MouseMove(object? sender, MouseEventArgs e)
        {
            parentPanel.Location = new Point(parentPanel.Location.X - (start.X - e.X), parentPanel.Location.Y - (start.Y - e.Y));
            if(parentPanel.Location.X < 0) 
            { 
                parentPanel.Location = new Point(0, parentPanel.Location.Y); 
            }
            if(parentPanel.Location.X + parentPanel.Width > moveableArea.Width)
            {
                parentPanel.Location = new Point(moveableArea.Width - parentPanel.Width, parentPanel.Location.Y);
            }
            if (parentPanel.Location.Y < 0)
            {
                parentPanel.Location = new Point(parentPanel.Location.X, 0);
            }
            if (parentPanel.Location.Y + parentPanel.Height > moveableArea.Height)
            {
                parentPanel.Location = new Point(parentPanel.Location.X, moveableArea.Height - parentPanel.Height);
            }
        }
    }

}
