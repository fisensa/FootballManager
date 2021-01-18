
using FootballManager.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace TestClient
{
    partial class Form1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCreateStadium = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStadiumCapacity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxStadiumName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboStadiums = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonCreateTeam = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTeamLocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCreatePlayer = new System.Windows.Forms.Button();
            this.comboBoxPlayerTeam = new System.Windows.Forms.ComboBox();
            this.comboBoxPlayerPosition = new System.Windows.Forms.ComboBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonTransferPlayer = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.comboTransferTeam = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboPlayerTransfer = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.listBoxStadiums = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCreateStadium);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxStadiumCapacity);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxStadiumName);
            this.groupBox3.Location = new System.Drawing.Point(651, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 171);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Stadium";
            // 
            // buttonCreateStadium
            // 
            this.buttonCreateStadium.Location = new System.Drawing.Point(68, 131);
            this.buttonCreateStadium.Name = "buttonCreateStadium";
            this.buttonCreateStadium.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateStadium.TabIndex = 4;
            this.buttonCreateStadium.Text = "Create";
            this.buttonCreateStadium.UseVisualStyleBackColor = true;
            this.buttonCreateStadium.Click += new System.EventHandler(this.buttonCreateStadium_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Stadium Capacity";
            // 
            // textBoxStadiumCapacity
            // 
            this.textBoxStadiumCapacity.Location = new System.Drawing.Point(94, 46);
            this.textBoxStadiumCapacity.Name = "textBoxStadiumCapacity";
            this.textBoxStadiumCapacity.Size = new System.Drawing.Size(100, 20);
            this.textBoxStadiumCapacity.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Stadium Name";
            // 
            // textBoxStadiumName
            // 
            this.textBoxStadiumName.Location = new System.Drawing.Point(94, 19);
            this.textBoxStadiumName.Name = "textBoxStadiumName";
            this.textBoxStadiumName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStadiumName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboStadiums);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.buttonCreateTeam);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxTeamLocation);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxTeamName);
            this.groupBox2.Location = new System.Drawing.Point(416, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 171);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Team";
            // 
            // comboStadiums
            // 
            this.comboStadiums.FormattingEnabled = true;
            this.comboStadiums.Location = new System.Drawing.Point(73, 76);
            this.comboStadiums.Name = "comboStadiums";
            this.comboStadiums.Size = new System.Drawing.Size(121, 21);
            this.comboStadiums.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Stadium";
            // 
            // buttonCreateTeam
            // 
            this.buttonCreateTeam.Location = new System.Drawing.Point(68, 131);
            this.buttonCreateTeam.Name = "buttonCreateTeam";
            this.buttonCreateTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateTeam.TabIndex = 4;
            this.buttonCreateTeam.Text = "Create";
            this.buttonCreateTeam.UseVisualStyleBackColor = true;
            this.buttonCreateTeam.Click += new System.EventHandler(this.buttonCreateTeam_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Team Location";
            // 
            // textBoxTeamLocation
            // 
            this.textBoxTeamLocation.Location = new System.Drawing.Point(94, 46);
            this.textBoxTeamLocation.Name = "textBoxTeamLocation";
            this.textBoxTeamLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxTeamLocation.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Team Name";
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(94, 19);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTeamName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreatePlayer);
            this.groupBox1.Controls.Add(this.comboBoxPlayerTeam);
            this.groupBox1.Controls.Add(this.comboBoxPlayerPosition);
            this.groupBox1.Controls.Add(this.textBoxNumber);
            this.groupBox1.Controls.Add(this.textBoxWeight);
            this.groupBox1.Controls.Add(this.textBoxBirthDate);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(210, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 303);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Player";
            // 
            // buttonCreatePlayer
            // 
            this.buttonCreatePlayer.Location = new System.Drawing.Point(71, 216);
            this.buttonCreatePlayer.Name = "buttonCreatePlayer";
            this.buttonCreatePlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonCreatePlayer.TabIndex = 14;
            this.buttonCreatePlayer.Text = "Create";
            this.buttonCreatePlayer.UseVisualStyleBackColor = true;
            this.buttonCreatePlayer.Click += new System.EventHandler(this.buttonCreatePlayer_Click);
            // 
            // comboBoxPlayerTeam
            // 
            this.comboBoxPlayerTeam.FormattingEnabled = true;
            this.comboBoxPlayerTeam.Location = new System.Drawing.Point(71, 161);
            this.comboBoxPlayerTeam.Name = "comboBoxPlayerTeam";
            this.comboBoxPlayerTeam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlayerTeam.TabIndex = 13;
            // 
            // comboBoxPlayerPosition
            // 
            this.comboBoxPlayerPosition.FormattingEnabled = true;
            this.comboBoxPlayerPosition.Location = new System.Drawing.Point(71, 133);
            this.comboBoxPlayerPosition.Name = "comboBoxPlayerPosition";
            this.comboBoxPlayerPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlayerPosition.TabIndex = 12;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(71, 106);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumber.TabIndex = 11;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(71, 82);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(121, 20);
            this.textBoxWeight.TabIndex = 10;
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(71, 59);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(121, 20);
            this.textBoxBirthDate.TabIndex = 9;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(71, 36);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(121, 20);
            this.textBoxSurname.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(71, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birth Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 368);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonTransferPlayer);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.comboTransferTeam);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.comboPlayerTransfer);
            this.groupBox4.Location = new System.Drawing.Point(416, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 125);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transfer Player";
            // 
            // buttonTransferPlayer
            // 
            this.buttonTransferPlayer.Location = new System.Drawing.Point(174, 87);
            this.buttonTransferPlayer.Name = "buttonTransferPlayer";
            this.buttonTransferPlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonTransferPlayer.TabIndex = 4;
            this.buttonTransferPlayer.Text = "Transfer";
            this.buttonTransferPlayer.UseVisualStyleBackColor = true;
            this.buttonTransferPlayer.Click += new System.EventHandler(this.buttonTransferPlayer_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(235, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "To Team";
            // 
            // comboTransferTeam
            // 
            this.comboTransferTeam.FormattingEnabled = true;
            this.comboTransferTeam.Location = new System.Drawing.Point(235, 40);
            this.comboTransferTeam.Name = "comboTransferTeam";
            this.comboTransferTeam.Size = new System.Drawing.Size(182, 21);
            this.comboTransferTeam.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Player";
            // 
            // comboPlayerTransfer
            // 
            this.comboPlayerTransfer.FormattingEnabled = true;
            this.comboPlayerTransfer.Location = new System.Drawing.Point(8, 39);
            this.comboPlayerTransfer.Name = "comboPlayerTransfer";
            this.comboPlayerTransfer.Size = new System.Drawing.Size(186, 21);
            this.comboPlayerTransfer.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Players";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(210, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Teams";
            // 
            // listBoxStadiums
            // 
            this.listBoxStadiums.FormattingEnabled = true;
            this.listBoxStadiums.Location = new System.Drawing.Point(863, 59);
            this.listBoxStadiums.Name = "listBoxStadiums";
            this.listBoxStadiums.Size = new System.Drawing.Size(173, 368);
            this.listBoxStadiums.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(863, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Stadiums";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 450);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.listBoxStadiums);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCreateStadium;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStadiumCapacity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxStadiumName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboStadiums;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonCreateTeam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTeamLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCreatePlayer;
        private System.Windows.Forms.ComboBox comboBoxPlayerTeam;
        private System.Windows.Forms.ComboBox comboBoxPlayerPosition;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboPlayerTransfer;
        private System.Windows.Forms.Button buttonTransferPlayer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboTransferTeam;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox listBoxStadiums;
        private System.Windows.Forms.Label label17;
    }
}

