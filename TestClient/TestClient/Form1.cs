using FootballManager.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DownloadAllPlayers();
            DownloadTeams();
        }

        private void DownloadTeams()
        {
            using (var client = new WebClient())
            {

                client.BaseAddress = "http://localhost:63122";
                var json = client.DownloadString("/api/footballmanager/getteams");
                var teams = JsonConvert.DeserializeObject<List<Team>>(json);

                foreach (var team in teams)
                {
                 comboBox1.Items.Add(team);
                }
            }
        }

        private void DownloadAllPlayers()
        {
            using (var client = new WebClient())
            {

                client.BaseAddress = "http://localhost:63122";
                var json = client.DownloadString("/api/footballmanager");
                var players = JsonConvert.DeserializeObject<List<PlayerTeam>>(json);

                foreach (var player in players)
                {
                    listBox1.Items.Add(player);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var player = ((PlayerTeam)((ListBox)sender).SelectedItem);
            MessageBox.Show(player.PlayerTeamName + "\n" + player.PlayerPosition.ToString(),player.PlayerName + " " + player.PlayerSurname, MessageBoxButtons.OK);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTeam = ((Team)((ComboBox)sender).SelectedItem).TeamId;
            using (var client = new WebClient())
            {

                client.BaseAddress = "http://localhost:63122";
                var json = client.DownloadString("/api/footballmanager/"+selectedTeam);
                var players = JsonConvert.DeserializeObject<List<PlayerTeam>>(json);
                listBox1.Items.Clear();
                foreach (var player in players)
                {
                    listBox1.Items.Add(player);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateTeam_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {

                client.BaseAddress = "http://localhost:63122";

                var values = new Dictionary<string, object>();
                values.Add("TeamLocation", textBoxTeamName);
                values.Add("TeamName", textBoxTeamLocation);
                values.Add("FKStadiumId",1);
                var valString = JsonConvert.SerializeObject(values);
                client.Headers[HttpRequestHeader.ContentType] = "application/json;";
                var json = client.UploadString("/api/footballmanager/createteam","POST", valString);
                var players = JsonConvert.DeserializeObject<List<PlayerTeam>>(json);
                listBox1.Items.Clear();
                foreach (var player in players)
                {
                    listBox1.Items.Add(player);
                }
            }
        }
    }
}
