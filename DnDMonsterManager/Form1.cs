using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace DnDMonsterManager
{
    public partial class DnDMonsterManager : Form
    {
        private Panel[] panels = new Panel[5];
        private List<MonsterPanel>? activeMonsterPanels;
        private Output? output;
        private MonsterScroll? monsterScroll;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottonRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        private void SetPanel(Panel pnl)
        {
            foreach (Panel panel in panels)
            {
                panel.Visible = panel == pnl;
            }
            if (pnl.Equals(pnlCreateMonster) || pnl.Equals(pnlCreateScenario) || pnl.Equals(pnlDashboard))
            {
                if (monsterScroll != null)
                {
                    monsterScroll.Generate();
                }
            }
            else
            {
                if (monsterScroll != null)
                {
                    monsterScroll.Destroy();
                }
            }
        }
        public Panel GetPanel()
        {
            try
            {
                foreach (Panel panel in panels)
                {
                    if (panel.Visible)
                    {
                        // There shouldn't be more than one visible panel at a time
                        return panel;
                    }
                }
                throw new Exception("Tried to get panel when no panel is currently active!");
            }
            catch (Exception e)
            {
                if (output != null)
                {
                    output.Print(e.Message);
                }
                throw;
            }
        }
        public DnDMonsterManager()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            output = new Output(tbOutput);
            activeMonsterPanels = new List<MonsterPanel>();
            panels[0] = pnlDashboard; panels[1] = pnlCreateMonster; panels[2] = pnlCreateScenario;
            panels[3] = pnlSettings; panels[4] = pnlOutput;
            monsterScroll = new MonsterScroll(this, pnlMonsterScroll, pnlScrollbar);
            CrMon_textType.SelectedIndex = 0;
            CrMon_textSize.SelectedIndex = 0;
            SetPanel(pnlDashboard);
            print("Begin Output:");
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            pnlNav.Height = btn.Height;
            pnlNav.Top = btn.Top;
            pnlNav.Left = btn.Left;
            btn.BackColor = Color.FromArgb(46, 51, 73);

            switch (btn.Name)
            {
                case "btnDashboard":
                    SetPanel(pnlDashboard);
                    break;
                case "btnCreateMonster":
                    SetPanel(pnlCreateMonster);
                    break;
                case "btnCreateScenario":
                    SetPanel(pnlCreateScenario);
                    break;
                case "btnSettings":
                    SetPanel(pnlSettings);
                    break;
                case "btnOutput":
                    SetPanel(pnlOutput);
                    break;

                default:
                    break;
            }
        }
        private void btnTab_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CrMon_btnSave_Click(object sender, EventArgs e)
        {
            // Format Monster Data
            string monsterName = CrMon_textName.Text;
            if (monsterName == "")
            {
                // Send Error
                CreateMonster_SetErrorMessage("ERROR: Monster Name Cannot Be Blank");
                return;
            }
            if (!int.TryParse(CrMon_intHP.Text, out int monsterHP))
            {
                // Could not parse int, put fail code here.
                CreateMonster_SetErrorMessage("ERROR: HP Must Be A Full Number");
                return;
            }
            if (monsterHP <= 0)
            {
                CreateMonster_SetErrorMessage("ERROR: HP Must Be A Positive Number");
                return;
            }
            bool monsterVarHp = CrMon_boolHPVar.Checked;
            if (!Enum.TryParse(CrMon_textSize.Text, true, out ESize monsterSize)
                    || CrMon_textSize.SelectedIndex == 0)
            {
                // Could not parse size
                CreateMonster_SetErrorMessage("ERROR: Size Value Invalid");
                return;
            }
            if (!Enum.TryParse(CrMon_textType.Text, true, out EType monsterType)
                    || CrMon_textType.SelectedIndex == 0)
            {
                // Could not parse type
                CreateMonster_SetErrorMessage("ERROR: Type Value Invalid");
                return;
            }
            Uri? uriResult;
            string monsterLink;
            bool b = Uri.TryCreate(CrMon_textLink.Text, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (b && (uriResult != null))
            {
                monsterLink = uriResult.ToString();
            }
            else
            {
                monsterLink = string.Empty;
            }
            MonsterData newMonster = new MonsterData(
                monsterName,
                monsterHP,
                monsterVarHp,
                monsterSize,
                monsterType,
                monsterLink
                );
            if (newMonster.SaveAsJSON())
            {
                print("Monster Saved As: " + File.ReadAllText("MonsterData.json"));
                if (monsterScroll != null) { monsterScroll.Generate(); }
                // Reset Form to Default
                CrMon_textName.Text = string.Empty;
                CrMon_intHP.Text = "1";
                CrMon_boolHPVar.Checked = true;
                CrMon_textType.SelectedIndex = 0;
                CrMon_textSize.SelectedIndex = 0;
                CrMon_textLink.Text = string.Empty;
                // End Reset
            }
            else
            {
                print("ERROR: I/O Exception");
                CreateMonster_SetErrorMessage("ERROR: Could Not Write To File");
                // Could not save monster
            }

        }
        private void CreateMonster_SetErrorMessage(string message)
        {
            Prompt.ShowAlert(message, "Create Monster Error");
        }

        public void print(string message)
        {
            if (output != null)
            {
                output.Print(message);
            }
        }

        private void btnDeleteMonster_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog("Name of monster to delete:", "Delete Monster");
            string filePath = "MonsterData.json";
            string JSONData = File.ReadAllText(filePath);
            var monsterList = JsonConvert.DeserializeObject<List<MonsterData>>(JSONData) ?? new List<MonsterData>();
            bool foundMatch = false;
            foreach (MonsterData monster in monsterList)
            {
                if (monster._name == promptValue)
                {
                    foundMatch = true;
                    monsterList.Remove(monster);
                    break;
                }
            }

            if (foundMatch)
            {
                JSONData = JsonConvert.SerializeObject(monsterList);
                File.WriteAllText(filePath, JSONData);
                if (monsterScroll != null)
                {
                    monsterScroll.Generate();
                }
                Prompt.ShowAlert("Delete Successful.", "Delete Monster");
            }
            else
            {
                Prompt.ShowAlert("Monster not found. Please try again.", "Delete Monster");
            }
        }
        public void MS_ClickOnDashboard(MonsterData md)
        {
            print("Button Clicked: Dashboard");
            MonsterPanel mp = new(md, pnlMovableArea);
            if (activeMonsterPanels != null)
            {
                activeMonsterPanels.Add(mp);
            }

        }
        public void MS_ClickOnCreateMonster(MonsterData md)
        {
            print("Button Clicked: Create Monster");
            // Set data to monster clicked on
            CrMon_textName.Text = md._name;
            CrMon_intHP.Text = md._maxHp.ToString();
            CrMon_boolHPVar.Checked = md._hpVar;
            CrMon_textType.SelectedIndex = (int)md._type + 1; // +1 to skip <Pick Type>
            CrMon_textSize.SelectedIndex = (int)md._size + 1; // +1 to skip <Pick Size>
            CrMon_textLink.Text = md._link;
        }
        public void MS_ClickOnScenario(MonsterData md)
        {
            print("Button Clicked: Create Scenario");
        }
    }

}