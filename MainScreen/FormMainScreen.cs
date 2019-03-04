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
        void showPicture()
        {
            pictureBox1.Image = Image.FromFile("images/1.jpg");
            pictureBox2.Image = Image.FromFile("images/2.jpg");
            pictureBox3.Image = Image.FromFile("images/3.jpg");
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            
        }
    }
}
