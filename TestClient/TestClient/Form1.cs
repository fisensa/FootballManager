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
        /*
         * Base Uri for the WebClient used, change to point to FootbalManager api
         */
        private string baseUri = "http://localhost:63122";
        public Form1()
        {
            InitializeComponent();
            DownloadAllPlayers();
            DownloadTeams();
            DownloadStadiums();
        }

        private void DownloadStadiums()
        {
            comboStadiums.Items.Clear();
            listBoxStadiums.Items.Clear();
            using (var client = new WebClient())
            {
            
                client.BaseAddress = baseUri;
                var json = client.DownloadString("/api/footballmanager/getstadiums");
                var stadiums = JsonConvert.DeserializeObject<List<Stadium>>(json);

                foreach (var stadium in stadiums)
                {
                    comboStadiums.Items.Add(stadium);
                    listBoxStadiums.Items.Add(stadium);
                }
            }

            foreach (var playerPos in Enum.GetValues(typeof(PlayerPosition))){
                comboBoxPlayerPosition.Items.Add(playerPos);
            }
            
        }

        private void DownloadTeams()
        {
            comboBox1.Items.Clear();
            comboTransferTeam.Items.Clear();
            comboBoxPlayerTeam.Items.Clear();
            using (var client = new WebClient())
            {

                client.BaseAddress = baseUri;
                var json = client.DownloadString("/api/footballmanager/getteams");
                var teams = JsonConvert.DeserializeObject<List<Team>>(json);

                foreach (var team in teams)
                {
                    comboBox1.Items.Add(team);
                    comboTransferTeam.Items.Add(team);
                    comboBoxPlayerTeam.Items.Add(team);
                }
            }
        }

        private void DownloadAllPlayers()
        {
            listBox1.Items.Clear();
            using (var client = new WebClient())
            {
                try
                {
                    client.BaseAddress = baseUri;
                    var json = client.DownloadString("/api/footballmanager");
                    var players = JsonConvert.DeserializeObject<List<PlayerTeam>>(json);

                    foreach (var player in players)
                    {
                        listBox1.Items.Add(player);
                    }
                }
                catch(Exception e) {
                    MessageBox.Show(e.Message, "Failed to retreive data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var player = ((PlayerTeam)((ListBox)sender).SelectedItem);
            MessageBox.Show(player.PlayerTeamName + "\n" + player.PlayerPosition.ToString(), player.PlayerName + " " + player.PlayerSurname, MessageBoxButtons.OK);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTeam = ((Team)((ComboBox)sender).SelectedItem).TeamId;
            using (var client = new WebClient())
            {

                client.BaseAddress = baseUri;
                var json = client.DownloadString("/api/footballmanager/" + selectedTeam);
                var players = JsonConvert.DeserializeObject<List<PlayerTeam>>(json);
                comboPlayerTransfer.Items.Clear();
                listBox1.Items.Clear();
                foreach (var player in players)
                {
                    comboPlayerTransfer.Items.Add(player);
                    listBox1.Items.Add(player);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateTeam_Click(object sender, EventArgs e)
        {
            var stadiumId = ((Stadium)comboStadiums.SelectedItem).StadiumId;
            using (var client = new WebClient())
            {

                client.BaseAddress = baseUri;

                var values = new Dictionary<string, object>();
                values.Add("TeamLocation", textBoxTeamLocation.Text);
                values.Add("TeamName", textBoxTeamName.Text);
                values.Add("FKStadiumId", stadiumId);
                var valString = JsonConvert.SerializeObject(values);
                client.Headers[HttpRequestHeader.ContentType] = "application/json;";
                var json = client.UploadString("/api/footballmanager/createteam", "POST", valString);
                var team = JsonConvert.DeserializeObject<Team>(json);

            }
            DownloadTeams();
        }

        private void buttonCreatePlayer_Click(object sender, EventArgs e)
        {
            var teamId = ((Team)comboBoxPlayerTeam.SelectedItem).TeamId;
            var playerPosition = ((PlayerPosition)comboBoxPlayerPosition.SelectedItem);
            using (var client = new WebClient())
            {

                client.BaseAddress = baseUri;

                var values = new Dictionary<string, object>();
                values.Add("FKTeamId", teamId);
                values.Add("PlayerName", textBoxName.Text);
                values.Add("PlayerSurname", textBoxSurname.Text);
                values.Add("PlayerNumber", Int32.Parse(textBoxNumber.Text));
                values.Add("PlayerPosition", playerPosition);
                values.Add("PlayerBirthDate", textBoxBirthDate.Text);
                

                var valString = JsonConvert.SerializeObject(values);
                client.Headers[HttpRequestHeader.ContentType] = "application/json;";
                var json = client.UploadString("/api/footballmanager/CreatePlayer", "POST", valString);
                var result = JsonConvert.DeserializeObject(json);

            }
            DownloadAllPlayers();
            
        }

        private void buttonTransferPlayer_Click(object sender, EventArgs e)
        {
            var playerId = ((PlayerTeam)comboPlayerTransfer.SelectedItem).PlayerId;
            var teamId = ((Team)comboTransferTeam.SelectedItem).TeamId;
            using (var client = new WebClient())
            {

                client.BaseAddress = baseUri;

                var values = new Dictionary<string, object>();
                values.Add("playerId", playerId);
                values.Add("teamId", teamId);
                
             
                var json = client.UploadString("/api/footballmanager/moveplayertoteam/"+playerId+"/"+teamId, "POST");
                bool result  = (bool)JsonConvert.DeserializeObject(json);
                if (!result) MessageBox.Show("Transer failed", "", MessageBoxButtons.OK);

            }
            DownloadAllPlayers();
            
        }

      

        private void buttonCreateStadium_Click(object sender, EventArgs e)
        {
            var stadiumName = textBoxStadiumName.Text;
            var stadiumCapacity = textBoxStadiumCapacity.Text;
            using (var client = new WebClient())
            {

                client.BaseAddress = baseUri;

                var values = new Dictionary<string, object>();
                values.Add("stadiumName", stadiumName);
                values.Add("capacity", stadiumCapacity);

                var valString = JsonConvert.SerializeObject(values);
                client.Headers[HttpRequestHeader.ContentType] = "application/json;";
                var json = client.UploadString("/api/footballmanager/createstadium", "POST", valString);
                var result = JsonConvert.DeserializeObject<Stadium>(json);
               

            }
            DownloadStadiums();
        }
    }
}
