using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace ZyroClient
{
    partial class MainForm
    {
        private PictureBox logoBox;
        private Label infoLabel;
        private Button video2Button;
        private Button discordButton;
        private Button zyroClientButton;
        private Button menuButton;
        private Panel sideMenu;
        private Button reportButton;
        private Button appealButton;
        private Label ranksLabel;

        private void InitializeComponent()
        {
            this.logoBox = new PictureBox();
            this.infoLabel = new Label();
            this.video2Button = new Button();
            this.discordButton = new Button();
            this.zyroClientButton = new Button();
            this.menuButton = new Button();
            this.sideMenu = new Panel();
            this.reportButton = new Button();
            this.appealButton = new Button();
            this.ranksLabel = new Label();

            this.ClientSize = new Size(800, 600);
            this.Text = "ZyroLauncher";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;

            // 🖼️ Logo
            this.logoBox.Image = Image.FromFile("logo.png");
            this.logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.logoBox.Location = new Point(350, 20);
            this.logoBox.Size = new Size(100, 100);

            // 🌐 Server Info
            this.infoLabel.Text = "IP: play.zyronetwork.net\nPORT: 19132\nWebsite: www.zyronetwork.net";
            this.infoLabel.ForeColor = Color.White;
            this.infoLabel.BackColor = Color.Transparent;
            this.infoLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.infoLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.infoLabel.Location = new Point(250, 130);
            this.infoLabel.Size = new Size(300, 80);

            // 📺 Gameplay Video Button
            this.video2Button.Text = "Watch Gameplay";
            this.video2Button.Location = new Point(250, 230);
            this.video2Button.Size = new Size(300, 40);
            this.video2Button.Click += (s, e) => Process.Start("https://www.youtube.com/watch?v=RjAzLdv1KrY");

            // 💬 Discord Button
            this.discordButton.Text = "Join Discord";
            this.discordButton.Location = new Point(250, 280);
            this.discordButton.Size = new Size(300, 40);
            this.discordButton.Click += (s, e) => Process.Start("https://discord.zyronetwork.net/");

            // 🚀 Zyro Client Button
            this.zyroClientButton.Text = "Zyro Client";
            this.zyroClientButton.Location = new Point(250, 330);
            this.zyroClientButton.Size = new Size(300, 40);
            this.zyroClientButton.Click += (s, e) => MessageBox.Show("Still in-progress", "Zyro Client");

            // ☰ Menu Button
            this.menuButton.Text = "☰";
            this.menuButton.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            this.menuButton.Location = new Point(10, 10);
            this.menuButton.Size = new Size(40, 40);
            this.menuButton.Click += (s, e) => sideMenu.Visible = !sideMenu.Visible;

            // 📋 Side Menu Panel
            this.sideMenu.BackColor = Color.Green;
            this.sideMenu.Size = new Size(200, 200);
            this.sideMenu.Location = new Point(10, 60);
            this.sideMenu.Visible = false;

            // 🧾 Report Button
            this.reportButton.Text = "Report Player";
            this.reportButton.Size = new Size(180, 30);
            this.reportButton.Location = new Point(10, 10);
            this.reportButton.BackColor = Color.Red;
            this.reportButton.ForeColor = Color.White;
            this.reportButton.FlatStyle = FlatStyle.Flat;
            this.reportButton.Click += (s, e) => Process.Start("https://www.zyronetwork.net/report.html");

            // 🧾 Appeal Button
            this.appealButton.Text = "Appeal";
            this.appealButton.Size = new Size(180, 30);
            this.appealButton.Location = new Point(10, 50);
            this.appealButton.BackColor = Color.Red;
            this.appealButton.ForeColor = Color.White;
            this.appealButton.FlatStyle = FlatStyle.Flat;
            this.appealButton.Click += (s, e) => Process.Start("https://www.zyronetwork.net/appeal.html");

            // 🧾 Ranks Label
            this.ranksLabel.Text = "Ranks:\n1- Zenix\n2- Elite\n3- Sapphire\n4- Ruby";
            this.ranksLabel.ForeColor = Color.White;
            this.ranksLabel.Location = new Point(10, 90);
            this.ranksLabel.Size = new Size(180, 80);

            // Add items to side menu
            this.sideMenu.Controls.Add(this.reportButton);
            this.sideMenu.Controls.Add(this.appealButton);
            this.sideMenu.Controls.Add(this.ranksLabel);

            // Add controls to form
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.video2Button);
            this.Controls.Add(this.discordButton);
            this.Controls.Add(this.zyroClientButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.sideMenu);
        }
    }
}






