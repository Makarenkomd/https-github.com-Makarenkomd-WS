using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainScreen
{
    public partial class FormMainScreen : Form
    {
        public FormMainScreen()
        {
            InitializeComponent();
            showPicture();
        }
        int numberCurrentPicture = 0;
        void showPicture()
        {
            pictureBox1.Image = Image.FromFile("images/"+((numberCurrentPicture) %18 + 1)+".jpg");
            pictureBox2.Image = Image.FromFile("images/"+ ((numberCurrentPicture+1) % 18 + 1) + ".jpg");
            pictureBox3.Image = Image.FromFile("images/"+ ((numberCurrentPicture+2) % 18 + 1) + ".jpg");
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            numberCurrentPicture += 3;
            showPicture();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            numberCurrentPicture = (numberCurrentPicture +18 - 3)%18;
            showPicture();
        }
    }
}
