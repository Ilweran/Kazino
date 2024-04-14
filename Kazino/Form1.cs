using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kazino
{
    public partial class Form1 : Form
    {
        PictureBox pictureBox2 = new PictureBox()
        {
            Name = "Play",
            Size = new Size(300, 88),
            Location = new Point(40, 800),
            Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Play.jpg")
        };

        PictureBox pictureBox1 = new PictureBox()
        {
            Name = "pictureBox1",
            Size = new Size(1300, 900),
            Location = new Point(0, 0),
            Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\InitBgrnd.jpg")
        };

        Button play = new Button();

        public Form1()
        {
            InitializeComponent();

            Button play = new Button();
            play.Parent = pictureBox2;
            play.Location = new Point(44, 800);
            play.Size = new Size(300, 88);
            this.Controls.Add(play);

            void play_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Clicked");
            };


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox pictureBox2 = new PictureBox()
            {
                Name = "Play",
                Size = new Size(300, 88),
                Location = new Point(40, 800),
                Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Play.jpg")
            };

            PictureBox pictureBox1 = new PictureBox()
            {
                Name = "SpinMachine",
                Size = new Size(1300, 900),
                Location = new Point(0, 0),
                Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\InitBgrnd.jpg")
            };

 
            this.Controls.Add(pictureBox2);
            this.BringToFront();

            this.Controls.Add(pictureBox1);
        }

    }
}
