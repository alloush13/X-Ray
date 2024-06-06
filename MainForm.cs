using Emgu.CV.Structure;
using Emgu.CV;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XRay
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            ImageOption.upload(pictureBoxEnter);
            if (pictureBoxEnter.Image != null)
            {
                buttonUpload.Hide();
                panelDrowOption.Show();
                panelImageOption.Show();

                Bitmap bitmap = new Bitmap(pictureBoxEnter.Image);
                Image<Bgr, byte> image = ImageOption.BitmapToImage<Bgr>(bitmap);
                string severity = ClassifySeverity.apply(image);
                MessageBox.Show($"The severity of the disease is: {severity}");

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            pictureBoxOuter.Image = null;
            pictureBoxOuter.Hide();
            pictureBoxEnter.Refresh();
            pictureBoxEnter.Image = null;
            pictureBoxEnter.Hide();
            buttonUpload.Show();
            panelDrowOption.Hide();
            panelImageOption.Hide();
            panelOuterOption.Hide();
            panelOuterOptionReport.Hide();
            panelRecordingOption.Hide();
            Shape.rectangles.Clear();
            Shape.circles.Clear();
            Shape.rect = new System.Drawing.Rectangle(0, 0, 0, 0);
            buttonCompress.Hide();
        }

        private void buttonSpectrum_Click(object sender, EventArgs e)
        {
            ImageOption.ConvertImageColor(pictureBoxEnter, pictureBoxOuter, "spectrum");
            panelOuterOption.Show();
            panelOuterOptionReport.Show();
        }

        private void buttonHot_Click(object sender, EventArgs e)
        {
            ImageOption.ConvertImageColor(pictureBoxEnter, pictureBoxOuter, "hot");
            panelOuterOption.Show();
            panelOuterOptionReport.Show();
        }

        private void buttonJet_Click(object sender, EventArgs e)
        {
            ImageOption.ConvertImageColor(pictureBoxEnter, pictureBoxOuter, "jet");
            panelOuterOption.Show();
            panelOuterOptionReport.Show();
        }

        private void buttonCool_Click(object sender, EventArgs e)
        {
            ImageOption.ConvertImageColor(pictureBoxEnter, pictureBoxOuter, "cool");
            panelOuterOption.Show();
            panelOuterOptionReport.Show();
        }
        private void buttonSpring_Click(object sender, EventArgs e)
        {
            ImageOption.ConvertImageColor(pictureBoxEnter, pictureBoxOuter, "spring");
            panelOuterOption.Show();
            panelOuterOptionReport.Show();
        }

        private void buttonRainbow_Click(object sender, EventArgs e)
        {
            ImageOption.ConvertImageColor(pictureBoxEnter, pictureBoxOuter, "rainbow");
            panelOuterOption.Show();
            panelOuterOptionReport.Show();
        }
        private void buttonNormal_Click(object sender, EventArgs e)
        {
            ImageOption.ConvertImageColor(pictureBoxEnter, pictureBoxOuter, "normal");
            panelOuterOption.Show();
            panelOuterOptionReport.Show();
        }
        private void pictureBoxEnter_MouseUp(object sender, MouseEventArgs e)
        {
            Shape.endDrow(pictureBoxEnter, e.X, e.Y);
        }


        private void pictureBoxEnter_MouseDown(object sender, MouseEventArgs e)
        {
            Shape.startDrow(e.X, e.Y);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (textBoxImageName.Text.Length > 0 && FileOption.find("images\\", textBoxImageName.Text, "jpeg").Length == 0)
            {
                pictureBoxOuter.Image.Save(FileOption.subdirectoryPath + "images\\" + textBoxImageName.Text + ".jpeg", ImageFormat.Jpeg);

                panelOuterOption.Hide();
                panelRecordingOption.Show();
                buttonCompress.Show();



            }



        }

        private void buttonNavDisplay_Click(object sender, EventArgs e)
        {
            panelLayoutNew.Hide();
            panelLayoutCompare.Hide();
            panelLayoutDisplay.Show();
            string[] images = FileOption.getAllFiles("images\\", "jpeg");
            for (int i = 0; i < images.Length; i++)

            {

                Bitmap image = new Bitmap(images[i]);
                new DataCard(flowLayoutPanelData, image, Path.GetFileNameWithoutExtension(images[i]));
            }


        }

        private void buttonRecording_Click(object sender, EventArgs e)
        {

            if (textBoxImageName.Text.Length > 0)
            {

                Audio.record(FileOption.subdirectoryPath + "sounds\\" + textBoxImageName.Text + ".wav");
                buttonRecording.Hide();
                buttonStopRecording.Show();
            }


        }

        private void buttonPlayAudio_Click(object sender, EventArgs e)
        {

            Audio.playSound(FileOption.subdirectoryPath + "sounds\\" + textBoxImageName.Text + ".wav");
            buttonPlayAudio.Hide();
            buttonStopAudio.Show();
        }

        private void buttonStopRecording_Click(object sender, EventArgs e)
        {
            Audio.stopRecording();
            buttonStopRecording.Hide();
            buttonPlayAudio.Show();
            buttonDeleteRecord.Show();
        }



        private void buttonStopAudio_Click(object sender, EventArgs e)
        {

            buttonPlayAudio.Show();
            buttonStopAudio.Hide();
            Audio.stopSound();
        }

        private void buttonFree_Click(object sender, EventArgs e)
        {
            Shape.selectedShape = "free";

        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            buttonStopAudio.Hide();
            buttonPlayAudio.Hide();
            buttonStopRecording.Hide();
            buttonRecording.Show();
            buttonDeleteRecord.Hide();
            Audio.stopRecording();
            Audio.stopSound();
            FileOption.delete("sounds\\", textBoxImageName.Text, "wav");
        }

        private void buttonRect_Click(object sender, EventArgs e)
        {
            Shape.selectedShape = "rectangle";
            pictureBoxEnter.Cursor = Cursors.Cross;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Shape.selectedShape = "circle";
            pictureBoxEnter.Cursor = Cursors.Cross;
        }

        private void buttonNavNew_Click(object sender, EventArgs e)
        {
            panelLayoutNew.Show();
            panelLayoutDisplay.Hide();
            panelLayoutCompare.Hide();
        }

        private void buttonClearDrow_Click(object sender, EventArgs e)
        {
            Shape.rectangles.Clear();
            Shape.circles.Clear();
            pictureBoxEnter.Refresh();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            if (Shape.rectangles.Count == 1)
            {
                Bitmap bmp = Shape.cutRectangle(pictureBoxEnter.Image, Shape.rectangles[0]);
                bmp = (Bitmap)ImageOption.resizeImage(bmp);
                pictureBoxEnter.Width = bmp.Width;
                pictureBoxEnter.Height = bmp.Height;
                pictureBoxEnter.Image = bmp;
                Shape.rectangles.Clear();
            }

        }

        private void buttonSaveReport_Click(object sender, EventArgs e)
        {
            if (textBoxImageName.Text.Length > 0)
            {
                FileOption.CreateDocument(FileOption.subdirectoryPath + "reports\\" + textBoxImageName.Text + ".pdf", textBoxPatientName.Text, textBoxPatientAge.Text, textBoxDiagnosis.Text, textBoxDoctorName.Text, textBoxDoctorRecommendation.Text);
                textBoxPatientName.Clear();
                textBoxPatientAge.Clear();
                textBoxDiagnosis.Clear();
                textBoxDoctorName.Clear();
                textBoxDoctorRecommendation.Clear();
            }



        }

        private void pictureBoxOuter_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxNote.Parent = pictureBoxOuter;
            buttonAddNote.Parent = pictureBoxOuter;
            ImageOption.updateNoteLocation(e.Location, textBoxNote, buttonAddNote);

            textBoxNote.Show();
            buttonAddNote.Show();
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            if (textBoxNote.Text.Length > 0)
            {
                ImageOption.addTextOnImage(pictureBoxOuter, textBoxNote);
                textBoxNote.Hide();
                buttonAddNote.Hide();
            }
        }





        private void buttonCompress_Click(object sender, EventArgs e)
        {


            Compress.create(textBoxImageName.Text);
            buttonCompress.Hide();

        }

        private void buttonNavCompare_Click(object sender, EventArgs e)
        {

            panelLayoutNew.Hide();
            panelLayoutDisplay.Hide();
            panelLayoutCompare.Show();
        }

        private void buttonFourier_Click(object sender, EventArgs e)
        {
            Fourier.FourierTransform(pictureBoxEnter, pictureBoxOuter);
            panelOuterOption.Show();
            panelOuterOptionReport.Show();
        }

        private void buttonUploadCompare1_Click(object sender, EventArgs e)
        {
            ImageOption.upload(pictureBoxCompare1);
            labelResultCompare.Text = "";
            if (pictureBoxCompare2.Image != null) buttonCompare.Show();
        }

        private void buttonUploadCompare2_Click(object sender, EventArgs e)
        {
            ImageOption.upload(pictureBoxCompare2);
            labelResultCompare.Text = "";
            if (pictureBoxCompare1.Image != null) buttonCompare.Show();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {

            labelResultCompare.Text = ImageCompare.compare(pictureBoxCompare1, pictureBoxCompare2);
            buttonCompare.Hide();
        }

        private void buttonTelegram_Click(object sender, EventArgs e)
        {
            Telegram telegram = new Telegram();
            telegram.run();
            buttonTelegram.Hide();

        }

        private void buttonSearchSize_Click(object sender, EventArgs e)
        {
            string sizeText = textBoxSearchSize.Text;

            if (int.TryParse(sizeText, out int size))
            {

                Console.WriteLine(size);
                SearchImagesBySize(size);
            }
            else
            {
                MessageBox.Show("Please enter a valid size.");
            }
        }
        private void SearchImagesBySize(int sizeKB)
        {

            string[] files = FileOption.SearchBySize("images\\", sizeKB);

            DisplaySearchResults(files);
        }
        private void DisplaySearchResults(string[] files)
        {
            panelLayoutNew.Hide();
            panelLayoutDisplay.Show();
            flowLayoutPanelData.Controls.Clear();

            for (int i = 0; i < files.Length; i++)

            {

                Bitmap image = new Bitmap(files[i]);
                new DataCard(flowLayoutPanelData, image, Path.GetFileNameWithoutExtension(files[i]));
            }
        }

        private void buttonSearchDate_Click(object sender, EventArgs e)
        {
            string dateText = textBoxSearchDate.Text;
            if (DateTime.TryParse(dateText, out DateTime date))
            {
                SearchImagesByDate(date);
            }
            else
            {
                MessageBox.Show("Please enter a valid date.");
            }
        }
        private void SearchImagesByDate(DateTime date)
        {
            string[] files = FileOption.SearchByDate("images\\", date);
            DisplaySearchResults(files);
        }
    }
}
