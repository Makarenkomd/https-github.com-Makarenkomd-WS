using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainScreen
{
    class Slider
    {
        int numberCurrentPicture = 0;
        List<string> nameImages = new List<string>(); 
        List<PictureBox> pictures = new List<PictureBox>();

        public Slider(string nameFolder, List<PictureBox> pictures)
        {
            // сохранить все объекты в которые закидывать картинки
            this.pictures = pictures;
            // получить список имен всех файлов из папки
            DirectoryInfo dir = new DirectoryInfo(nameFolder);
            foreach (var file in dir.GetFiles())
                nameImages.Add(file.FullName);
            showPicture();
        }
        void showPicture()
        {
            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = Image.FromFile(nameImages[(numberCurrentPicture+i)% nameImages.Count()]);
            }
        }

        public void slideRight()
        {
            numberCurrentPicture = (numberCurrentPicture + pictures.Count) % nameImages.Count;
            showPicture();
        }

        public void slideLeft()
        {
            numberCurrentPicture = (numberCurrentPicture - pictures.Count + nameImages.Count) % nameImages.Count;
            showPicture();
        }
    }
}
