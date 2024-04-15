using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kazino
{
    public partial class Form3 : Form
    {
        public Form1 frm1;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            PictureBox pictureBox1 = new PictureBox()
            {
                Name = "InitBgrdn",
                Visible = true,
                Size = new Size(1300, 900),
                Location = new Point(0, 0),
                Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\InitBgrnd.jpg")
            };
            this.Controls.Add(pictureBox1);
        }
    }
}
