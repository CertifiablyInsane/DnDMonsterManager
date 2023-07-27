using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DnDMonsterManager
{
    internal class MonsterScroll
    {
        private DnDMonsterManager mainForm;
        private Panel mainPanel;
        private Panel scrollPanel;
        private List<Panel> panelList;
        private int numCreated = 0;
        private bool generated = false;
        public MonsterScroll(DnDMonsterManager mf, Panel mainPnl, Panel scrPnl) 
        {
            mainForm = mf;
            mainPanel = mainPnl;
            scrollPanel = scrPnl;
            panelList = new List<Panel>();
        }
        public void Generate()
        {
            if(generated)
            {
                // Destroy if already exists
                Destroy();
            }
            scrollPanel.SuspendLayout();
            string filePath = "MonsterData.json";
            string JSONData = File.ReadAllText(filePath);
            var tempList = JsonConvert.DeserializeObject<List<MonsterData>>(JSONData) ?? new List<MonsterData>();
            List<MonsterData> monsterList = tempList.OrderBy(m=>m._name).ToList();
            tempList.Clear(); tempList.TrimExcess();

            foreach (MonsterData monster in monsterList)
            {
                Panel pnlMain = new();
                // Each panel shall be 60 units tall.
                pnlMain.BackColor = Color.FromArgb(37, 42, 64); pnlMain.SetBounds(0, 60 * numCreated, scrollPanel.Width, 60);
                pnlMain.Name = "pnl" + monster._name; pnlMain.Parent = scrollPanel;  pnlMain.Dock = DockStyle.Top;

                Button btn = new();
                btn.BackColor = Color.FromArgb(74, 79, 99); btn.SetBounds(4, 4, scrollPanel.Width - 8, pnlMain.Height - 8);
                btn.Name = "btn" + monster._name; btn.Parent = pnlMain; btn.Dock = DockStyle.None; btn.Cursor = Cursors.Hand;
                btn.Text = monster._name; btn.Font = new Font("Nirmala UI", 12.0f, FontStyle.Bold);
                btn.FlatStyle = FlatStyle.Flat; btn.ForeColor = Color.FromArgb(200, 200, 200);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                /*
                Panel pnlMain2 = new();
                pnlMain2.BackColor = Color.FromArgb(74, 79, 99); pnlMain2.SetBounds(4, 4, scrollPanel.Width - 8, pnlMain.Height - 8);
                pnlMain2.Name = "pnl" + monster._name + "2"; pnlMain2.Parent = pnlMain; pnlMain2.Dock = DockStyle.None; pnlMain2.Cursor = Cursors.Hand;

                Label lblName = new();
                lblName.BackColor = Color.FromArgb(74, 79, 99); lblName.SetBounds(0, 0, pnlMain2.Width, pnlMain2.Height);
                lblName.Name = "lbl" + monster._name; lblName.Parent = pnlMain2; lblName.Dock = DockStyle.Fill;
                lblName.Text = monster._name; lblName.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold);
                lblName.ForeColor = Color.FromArgb(200, 200, 200); lblName.TextAlign = ContentAlignment.MiddleCenter; lblName.AutoSize = false;
                */

                // Set behaviour based on current panel
                string currentPanel = mainForm.GetPanel().Name;
                switch (currentPanel)
                {
                    case "pnlDashboard":
                        btn.Click += (sender, e) => { mainForm.MS_ClickOnDashboard(monster); };
                        break;
                    case "pnlCreateMonster":
                        btn.Click += (sender, e) => { mainForm.MS_ClickOnCreateMonster(monster); };
                        break;
                    case "pnlCreateScenario":
                        btn.Click += (sender, e) => { mainForm.MS_ClickOnScenario(monster); };
                        break;
                    default:
                        break;
                }

                panelList.Add(pnlMain);
            }

            generated = true;
            scrollPanel.ResumeLayout();
            mainPanel.Visible = true;
        }

        public void Destroy()
        {
            mainPanel.Visible = false;
            if (!generated)
            {
                // No need, already destroyed / never created.
                return;
            }
            // Kill all elements
            foreach(Panel pnl in  panelList)
            {
                pnl.Dispose();
            }
            numCreated = 0;
            generated = false;
            panelList.Clear();  panelList.TrimExcess();
        }
    }
}
