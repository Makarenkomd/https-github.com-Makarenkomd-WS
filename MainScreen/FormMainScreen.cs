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
        Slider sl;
        public FormMainScreen()
        {
            InitializeComponent();
            sl = new Slider("images", new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3});
            historyNBA.getHowOldNBA(labelInfo);
        }
      
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            sl.slideLeft();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            sl.slideRight();
        }
    }
}
