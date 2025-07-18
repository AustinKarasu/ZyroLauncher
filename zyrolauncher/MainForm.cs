using System;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ZyroClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;

            try
            {
                this.BackgroundImage = Image.FromFile("background.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch
            {
                MessageBox.Show("Background image not found.");
            }
        }
    }
}

