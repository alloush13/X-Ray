using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using XRay.Properties;

namespace XRay
{
    internal class DataCard
    {
        Panel card = new Panel();
        PictureBox pictureBox = new PictureBox();
        Button button = new Button();
        Label label = new Label();
        public DataCard(Panel parent, Image image, String fileName)
        {
            this.create(image, fileName);
            this.card.Parent = parent;
          
            
        }

        private void create(Image image, String fileName)
        {

            this.card.Width = 300;
            this.card.Height = 480;

            this.createPictureBox(image);
            this.createButton(fileName);
            this.createLabel(fileName);
            this.pictureBox.Parent = this.card;
            this.button.Parent = this.card;
            this.label.Parent = this.card;

        }

        private void createPictureBox(Image image)
        {

            this.pictureBox.Width = 300;
            this.pictureBox.Height = 420;
            this.pictureBox.Image = image;
            this.pictureBox.Location = new Point(0, 60);

        }
        private void createLabel(String fileName)
        {
            this.label.Text = fileName;
            this.label.Location = new Point(100, 0);
            


        }
        private void createButton(String fileName)
        {

            this.button.Width = 62;
            this.button.Height = 56;
            this.button.Hide();
            this.button.BackgroundImage = new Bitmap(Resources.play);
            this.button.BackgroundImageLayout = ImageLayout.Stretch;
            string audioFile = FileOption.find("sounds\\", fileName, "wav");
            if (audioFile.Length > 0)
            {
                this.button.Show();
                // this.button.Click += new EventHandler(playSound);
                this.button.Click += (sender, e) => playAudio(sender, e, audioFile);
            }
            
            


        }
        protected void playAudio(object sender, EventArgs e,string audioFile)
        {

            
           // Audio.audioFile = audioFile;
            Audio.playSound(audioFile);

        }
    }
}
