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
        private Panel movableArea;
        private Panel parentPanel;
        private Panel moveBar;
        public MonsterPanel(MonsterData sourceData, Panel movableArea) 
        { 
            data = sourceData;
            this.movableArea = movableArea;

            // UI Creation Here
            parentPanel = new Panel();
            parentPanel.SetBounds(32, 32, 256, 384);    parentPanel.BackColor = Color.FromArgb(37, 42, 64);
            parentPanel.Parent = movableArea;
        
            TableLayoutPanel tPnl1 = new TableLayoutPanel();
            tPnl1.BackColor = Color.FromArgb(24, 30, 54);   tPnl1.Dock = DockStyle.Fill;
            tPnl1.ColumnCount = 1;  tPnl1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            tPnl1.RowCount = 2;     tPnl1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));  tPnl1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tPnl1.Parent = parentPanel;

            moveBar = new Panel();
            moveBar.BackColor = Color.FromArgb(158, 161, 176);  moveBar.Dock = DockStyle.Fill;
            moveBar.Parent = tPnl1; moveBar.MouseDown += pnlMovable_MouseDown;

            Button btnClose = new Button();
            btnClose.BackColor = Color.Red; btnClose.ForeColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10f, FontStyle.Bold);  btnClose.Text = "X";
            btnClose.Dock = DockStyle.Fill; btnClose.Margin = new Padding(4);
            // TODO: Add closing functionality

        }

        public void Destroy()
        {
            parentPanel.Dispose();
        }

        private void pnlMovable_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                start = e.Location;
                moveBar.MouseUp += new MouseEventHandler(pnlMovable_MouseUp);
                moveBar.MouseMove += new MouseEventHandler(pnlMovable_MouseMove);
            }
        }
        private void pnlMovable_MouseUp(object? sender, MouseEventArgs e)
        {
            moveBar.MouseUp -= new MouseEventHandler(pnlMovable_MouseUp);
            moveBar.MouseMove -= new MouseEventHandler(pnlMovable_MouseMove);
        }
        private void pnlMovable_MouseMove(object? sender, MouseEventArgs e)
        {
            parentPanel.Location = new Point(parentPanel.Location.X - (start.X - e.X), parentPanel.Location.Y - (start.Y - e.Y));
        }
    }

}
