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
        

//        Button play = new Button()
 //       {
 //           Location = new Point(44,800),
//            Size = new Size(300, 88)
 //       };


        PictureBox pictureBox2 = new PictureBox()
        {
            Name = "Play",
            Visible = true,
            Size = new Size(300, 88),
            Location = new Point(40, 800),
            Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Play.jpg")
        };

        PictureBox pictureBox1 = new PictureBox()
        {
            Name = "InitBgrdn",
            Visible = true,
            Size = new Size(1300, 900),
            Location = new Point(0, 0),
            Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\InitBgrnd.jpg")
        };

        public Form1()
        {
            InitializeComponent();

        }

        Control control;

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox pictureBox2 = new PictureBox()
            {
                Name = "Play",
                Visible = true,
                Size = new Size(300, 88),
                Location = new Point(40, 600),
                Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Play.jpg"),
                
            };

            PictureBox pictureBox1 = new PictureBox()
            {
                Name = "InitBgrdn",
                Visible = true,
                Size = new Size(1300, 900),
                Location = new Point(0, 0),
                Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\InitBgrnd.jpg")
            };
            
            this.Controls.Add(pictureBox1);
            this.Controls.Add(pictureBox2);
            pictureBox2.BringToFront();
            
            foreach (Control control in this.Controls)
                if (control is PictureBox)
                    control.Click += pictureBoxClickHandler;

            

 //           play.Parent = pictureBox2;
 //this.Controls.Add(play);
        }

        private void pictureBoxClickHandler(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox == pictureBox2)
            {
                Form3 A = new Form3();
                A.frm1 = this;
                A.Show();
            }
        }

 //       private void play_Click(object sender, EventArgs e)
 //       {
 //           MessageBox.Show("Clicked");
 //       }

    }
}
