using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            richTextBox2.Text = GameManager.Instance.activeplayer.currentstate;
            richTextBox1.Text = GameManager.Instance.activeplayer.Name;
            Player1.Text = GameManager.Instance.player1.Health.ToString();
            Player2.Text = GameManager.Instance.player2.Health.ToString();
            Player3.Text = GameManager.Instance.player3.Health.ToString();
            Player4.Text = GameManager.Instance.player4.Health.ToString();
            Player5.Text = GameManager.Instance.player5.Health.ToString();
            Player6.Text = GameManager.Instance.player6.Health.ToString();
            progressBar1.Value = GameManager.Instance.player1.Health;
            progressBar2.Value = GameManager.Instance.player2.Health;
            progressBar3.Value = GameManager.Instance.player3.Health;
            progressBar4.Value = GameManager.Instance.player4.Health;
            progressBar5.Value = GameManager.Instance.player5.Health;
            progressBar6.Value = GameManager.Instance.player6.Health;
            
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            GameManager.Instance.activeplayer.Attack();
            UpdateUI();
        }

        private void EndTurn_Click(object sender, EventArgs e)
        {
            GameManager.Instance.activeplayer.EndTurn();
            UpdateUI();
        }

        private void Idle_Click(object sender, EventArgs e)
        {
            GameManager.Instance.activeplayer.ToIdle();
            UpdateUI();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataManagement<Player>.Serialize("ActivePlayer", GameManager.Instance.activeplayer);
            DataManagement<string>.Serialize("ActivePlayerState", GameManager.Instance.activeplayer.currentstate);
            DataManagement<List<Player>>.Serialize("PlayerList", GameManager.Instance.playerlist);
            UpdateUI();
        }

        private void load_Click(object sender, EventArgs e)
        {
            GameManager.Instance.activeplayer = DataManagement<Player>.Deserialize("ActivePlayer");
            GameManager.Instance.activeplayer.currentstate = DataManagement<string>.Deserialize("ActivePlayerState");
            GameManager.Instance.playerlist = DataManagement<List<Player>>.Deserialize("PlayerList");            
            UpdateUI();
        }

        
    }
}
