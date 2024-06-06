namespace XRay
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelNavbar = new Panel();
            buttonSearchDate = new Button();
            buttonSearchSize = new Button();
            textBoxSearchDate = new TextBox();
            textBoxSearchSize = new TextBox();
            buttonTelegram = new Button();
            buttonNavDisplay = new Button();
            buttonNavCompare = new Button();
            buttonNavNew = new Button();
            panelLayoutNew = new Panel();
            buttonCompress = new Button();
            buttonAddNote = new Button();
            textBoxNote = new TextBox();
            panelRecordingOption = new Panel();
            buttonRecording = new Button();
            buttonStopAudio = new Button();
            buttonDeleteRecord = new Button();
            buttonStopRecording = new Button();
            labelAudioDescription = new Label();
            buttonPlayAudio = new Button();
            panelOuterOptionReport = new Panel();
            textBoxDoctorRecommendation = new TextBox();
            label5 = new Label();
            textBoxDoctorName = new TextBox();
            label4 = new Label();
            textBoxDiagnosis = new TextBox();
            label3 = new Label();
            textBoxPatientAge = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxPatientName = new TextBox();
            buttonSaveReport = new Button();
            panelOuterOption = new Panel();
            labelImageName = new Label();
            buttonSave = new Button();
            textBoxImageName = new TextBox();
            panelImageOption = new Panel();
            buttonFourier = new Button();
            buttonCut = new Button();
            buttonRainbow = new Button();
            buttonSpring = new Button();
            buttonNormal = new Button();
            buttonCool = new Button();
            buttonJet = new Button();
            buttonHot = new Button();
            buttonSpectrum = new Button();
            buttonDelete = new Button();
            panelDrowOption = new Panel();
            buttonClearDrow = new Button();
            buttonFree = new Button();
            buttonCircle = new Button();
            buttonRect = new Button();
            labelDrow = new Label();
            pictureBoxOuter = new PictureBox();
            pictureBoxEnter = new PictureBox();
            buttonUpload = new Button();
            panelLayoutCompare = new Panel();
            labelResultCompare = new Label();
            buttonCompare = new Button();
            buttonUploadCompare2 = new Button();
            buttonUploadCompare1 = new Button();
            pictureBoxCompare2 = new PictureBox();
            pictureBoxCompare1 = new PictureBox();
            panelLayoutDisplay = new Panel();
            flowLayoutPanelData = new FlowLayoutPanel();
            panelNavbar.SuspendLayout();
            panelLayoutNew.SuspendLayout();
            panelRecordingOption.SuspendLayout();
            panelOuterOptionReport.SuspendLayout();
            panelOuterOption.SuspendLayout();
            panelImageOption.SuspendLayout();
            panelDrowOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOuter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnter).BeginInit();
            panelLayoutCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompare2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompare1).BeginInit();
            panelLayoutDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.Controls.Add(buttonSearchDate);
            panelNavbar.Controls.Add(buttonSearchSize);
            panelNavbar.Controls.Add(textBoxSearchDate);
            panelNavbar.Controls.Add(textBoxSearchSize);
            panelNavbar.Controls.Add(buttonTelegram);
            panelNavbar.Controls.Add(buttonNavDisplay);
            panelNavbar.Controls.Add(buttonNavCompare);
            panelNavbar.Controls.Add(buttonNavNew);
            panelNavbar.Location = new Point(12, 12);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1160, 50);
            panelNavbar.TabIndex = 0;
            // 
            // buttonSearchDate
            // 
            buttonSearchDate.Location = new Point(808, 14);
            buttonSearchDate.Name = "buttonSearchDate";
            buttonSearchDate.Size = new Size(97, 23);
            buttonSearchDate.TabIndex = 7;
            buttonSearchDate.Text = "Search Date";
            buttonSearchDate.UseVisualStyleBackColor = true;
            buttonSearchDate.Click += buttonSearchDate_Click;
            // 
            // buttonSearchSize
            // 
            buttonSearchSize.Location = new Point(559, 15);
            buttonSearchSize.Name = "buttonSearchSize";
            buttonSearchSize.Size = new Size(96, 23);
            buttonSearchSize.TabIndex = 6;
            buttonSearchSize.Text = "Search Size";
            buttonSearchSize.UseVisualStyleBackColor = true;
            buttonSearchSize.Click += buttonSearchSize_Click;
            // 
            // textBoxSearchDate
            // 
            textBoxSearchDate.Location = new Point(681, 15);
            textBoxSearchDate.Name = "textBoxSearchDate";
            textBoxSearchDate.PlaceholderText = "mm/dd/yyyy";
            textBoxSearchDate.Size = new Size(121, 23);
            textBoxSearchDate.TabIndex = 5;
            // 
            // textBoxSearchSize
            // 
            textBoxSearchSize.Location = new Point(432, 15);
            textBoxSearchSize.Name = "textBoxSearchSize";
            textBoxSearchSize.PlaceholderText = "Enter Size";
            textBoxSearchSize.Size = new Size(121, 23);
            textBoxSearchSize.TabIndex = 4;
            // 
            // buttonTelegram
            // 
            buttonTelegram.Location = new Point(1079, 3);
            buttonTelegram.Name = "buttonTelegram";
            buttonTelegram.Size = new Size(75, 44);
            buttonTelegram.TabIndex = 3;
            buttonTelegram.Text = "Telegram";
            buttonTelegram.UseVisualStyleBackColor = true;
            buttonTelegram.Click += buttonTelegram_Click;
            // 
            // buttonNavDisplay
            // 
            buttonNavDisplay.Location = new Point(165, 3);
            buttonNavDisplay.Name = "buttonNavDisplay";
            buttonNavDisplay.Size = new Size(75, 44);
            buttonNavDisplay.TabIndex = 2;
            buttonNavDisplay.Text = "Display";
            buttonNavDisplay.UseVisualStyleBackColor = true;
            buttonNavDisplay.Click += buttonNavDisplay_Click;
            // 
            // buttonNavCompare
            // 
            buttonNavCompare.Location = new Point(84, 3);
            buttonNavCompare.Name = "buttonNavCompare";
            buttonNavCompare.Size = new Size(75, 44);
            buttonNavCompare.TabIndex = 1;
            buttonNavCompare.Text = "Compare";
            buttonNavCompare.UseVisualStyleBackColor = true;
            buttonNavCompare.Click += buttonNavCompare_Click;
            // 
            // buttonNavNew
            // 
            buttonNavNew.Location = new Point(3, 3);
            buttonNavNew.Name = "buttonNavNew";
            buttonNavNew.Size = new Size(75, 44);
            buttonNavNew.TabIndex = 0;
            buttonNavNew.Text = "New";
            buttonNavNew.UseVisualStyleBackColor = true;
            buttonNavNew.Click += buttonNavNew_Click;
            // 
            // panelLayoutNew
            // 
            panelLayoutNew.Controls.Add(buttonCompress);
            panelLayoutNew.Controls.Add(buttonAddNote);
            panelLayoutNew.Controls.Add(textBoxNote);
            panelLayoutNew.Controls.Add(panelRecordingOption);
            panelLayoutNew.Controls.Add(panelOuterOptionReport);
            panelLayoutNew.Controls.Add(panelOuterOption);
            panelLayoutNew.Controls.Add(panelImageOption);
            panelLayoutNew.Controls.Add(panelDrowOption);
            panelLayoutNew.Controls.Add(pictureBoxOuter);
            panelLayoutNew.Controls.Add(pictureBoxEnter);
            panelLayoutNew.Controls.Add(buttonUpload);
            panelLayoutNew.Location = new Point(12, 68);
            panelLayoutNew.Name = "panelLayoutNew";
            panelLayoutNew.Size = new Size(1160, 531);
            panelLayoutNew.TabIndex = 0;
            // 
            // buttonCompress
            // 
            buttonCompress.BackColor = SystemColors.Control;
            buttonCompress.BackgroundImage = Properties.Resources.compress;
            buttonCompress.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCompress.Location = new Point(749, 462);
            buttonCompress.Name = "buttonCompress";
            buttonCompress.Size = new Size(62, 56);
            buttonCompress.TabIndex = 14;
            buttonCompress.UseVisualStyleBackColor = false;
            buttonCompress.Click += buttonCompress_Click;
            // 
            // buttonAddNote
            // 
            buttonAddNote.Location = new Point(871, 70);
            buttonAddNote.Name = "buttonAddNote";
            buttonAddNote.Size = new Size(75, 23);
            buttonAddNote.TabIndex = 10;
            buttonAddNote.Text = "Add Text";
            buttonAddNote.UseVisualStyleBackColor = true;
            buttonAddNote.Visible = false;
            buttonAddNote.Click += buttonAddNote_Click;
            // 
            // textBoxNote
            // 
            textBoxNote.Location = new Point(871, 39);
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(100, 23);
            textBoxNote.TabIndex = 9;
            textBoxNote.Visible = false;
            // 
            // panelRecordingOption
            // 
            panelRecordingOption.Controls.Add(buttonRecording);
            panelRecordingOption.Controls.Add(buttonStopAudio);
            panelRecordingOption.Controls.Add(buttonDeleteRecord);
            panelRecordingOption.Controls.Add(buttonStopRecording);
            panelRecordingOption.Controls.Add(labelAudioDescription);
            panelRecordingOption.Controls.Add(buttonPlayAudio);
            panelRecordingOption.Location = new Point(828, 429);
            panelRecordingOption.Name = "panelRecordingOption";
            panelRecordingOption.Size = new Size(199, 99);
            panelRecordingOption.TabIndex = 8;
            panelRecordingOption.Visible = false;
            // 
            // buttonRecording
            // 
            buttonRecording.BackColor = SystemColors.Control;
            buttonRecording.BackgroundImage = Properties.Resources.recording;
            buttonRecording.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRecording.Location = new Point(3, 30);
            buttonRecording.Name = "buttonRecording";
            buttonRecording.Size = new Size(62, 56);
            buttonRecording.TabIndex = 0;
            buttonRecording.UseVisualStyleBackColor = false;
            buttonRecording.Click += buttonRecording_Click;
            // 
            // buttonStopAudio
            // 
            buttonStopAudio.BackColor = SystemColors.Control;
            buttonStopAudio.BackgroundImage = Properties.Resources.stop;
            buttonStopAudio.BackgroundImageLayout = ImageLayout.Stretch;
            buttonStopAudio.Location = new Point(3, 30);
            buttonStopAudio.Name = "buttonStopAudio";
            buttonStopAudio.Size = new Size(62, 56);
            buttonStopAudio.TabIndex = 12;
            buttonStopAudio.UseVisualStyleBackColor = false;
            buttonStopAudio.Visible = false;
            buttonStopAudio.Click += buttonStopAudio_Click;
            // 
            // buttonDeleteRecord
            // 
            buttonDeleteRecord.BackColor = SystemColors.Control;
            buttonDeleteRecord.BackgroundImage = Properties.Resources.delete;
            buttonDeleteRecord.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDeleteRecord.Location = new Point(134, 30);
            buttonDeleteRecord.Name = "buttonDeleteRecord";
            buttonDeleteRecord.Size = new Size(62, 56);
            buttonDeleteRecord.TabIndex = 13;
            buttonDeleteRecord.UseVisualStyleBackColor = false;
            buttonDeleteRecord.Visible = false;
            buttonDeleteRecord.Click += buttonDeleteRecord_Click;
            // 
            // buttonStopRecording
            // 
            buttonStopRecording.BackColor = SystemColors.Control;
            buttonStopRecording.BackgroundImage = Properties.Resources.stop;
            buttonStopRecording.BackgroundImageLayout = ImageLayout.Stretch;
            buttonStopRecording.Location = new Point(3, 30);
            buttonStopRecording.Name = "buttonStopRecording";
            buttonStopRecording.Size = new Size(62, 56);
            buttonStopRecording.TabIndex = 10;
            buttonStopRecording.UseVisualStyleBackColor = false;
            buttonStopRecording.Visible = false;
            buttonStopRecording.Click += buttonStopRecording_Click;
            // 
            // labelAudioDescription
            // 
            labelAudioDescription.AutoSize = true;
            labelAudioDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAudioDescription.Location = new Point(29, 3);
            labelAudioDescription.Name = "labelAudioDescription";
            labelAudioDescription.Size = new Size(148, 21);
            labelAudioDescription.TabIndex = 8;
            labelAudioDescription.Text = "Audio Description";
            // 
            // buttonPlayAudio
            // 
            buttonPlayAudio.BackColor = SystemColors.Control;
            buttonPlayAudio.BackgroundImage = Properties.Resources.play;
            buttonPlayAudio.BackgroundImageLayout = ImageLayout.Stretch;
            buttonPlayAudio.Location = new Point(3, 30);
            buttonPlayAudio.Name = "buttonPlayAudio";
            buttonPlayAudio.Size = new Size(62, 56);
            buttonPlayAudio.TabIndex = 9;
            buttonPlayAudio.UseVisualStyleBackColor = false;
            buttonPlayAudio.Visible = false;
            buttonPlayAudio.Click += buttonPlayAudio_Click;
            // 
            // panelOuterOptionReport
            // 
            panelOuterOptionReport.Controls.Add(textBoxDoctorRecommendation);
            panelOuterOptionReport.Controls.Add(label5);
            panelOuterOptionReport.Controls.Add(textBoxDoctorName);
            panelOuterOptionReport.Controls.Add(label4);
            panelOuterOptionReport.Controls.Add(textBoxDiagnosis);
            panelOuterOptionReport.Controls.Add(label3);
            panelOuterOptionReport.Controls.Add(textBoxPatientAge);
            panelOuterOptionReport.Controls.Add(label2);
            panelOuterOptionReport.Controls.Add(label1);
            panelOuterOptionReport.Controls.Add(textBoxPatientName);
            panelOuterOptionReport.Controls.Add(buttonSaveReport);
            panelOuterOptionReport.Location = new Point(432, 3);
            panelOuterOptionReport.Name = "panelOuterOptionReport";
            panelOuterOptionReport.Size = new Size(419, 420);
            panelOuterOptionReport.TabIndex = 7;
            panelOuterOptionReport.Visible = false;
            // 
            // textBoxDoctorRecommendation
            // 
            textBoxDoctorRecommendation.Location = new Point(19, 305);
            textBoxDoctorRecommendation.Multiline = true;
            textBoxDoctorRecommendation.Name = "textBoxDoctorRecommendation";
            textBoxDoctorRecommendation.Size = new Size(380, 78);
            textBoxDoctorRecommendation.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(94, 281);
            label5.Name = "label5";
            label5.Size = new Size(209, 21);
            label5.TabIndex = 18;
            label5.Text = "Doctor's recommendation";
            // 
            // textBoxDoctorName
            // 
            textBoxDoctorName.Location = new Point(154, 236);
            textBoxDoctorName.Name = "textBoxDoctorName";
            textBoxDoctorName.Size = new Size(245, 23);
            textBoxDoctorName.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(19, 236);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 16;
            label4.Text = "Doctor Name";
            // 
            // textBoxDiagnosis
            // 
            textBoxDiagnosis.Location = new Point(19, 129);
            textBoxDiagnosis.Multiline = true;
            textBoxDiagnosis.Name = "textBoxDiagnosis";
            textBoxDiagnosis.Size = new Size(380, 78);
            textBoxDiagnosis.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(109, 96);
            label3.Name = "label3";
            label3.Size = new Size(194, 21);
            label3.TabIndex = 14;
            label3.Text = "Diagnosis of the disease";
            // 
            // textBoxPatientAge
            // 
            textBoxPatientAge.Location = new Point(154, 57);
            textBoxPatientAge.Name = "textBoxPatientAge";
            textBoxPatientAge.Size = new Size(245, 23);
            textBoxPatientAge.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 12;
            label2.Text = "Patient Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 11;
            label1.Text = "Patient Name";
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.Location = new Point(154, 21);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.Size = new Size(245, 23);
            textBoxPatientName.TabIndex = 10;
            // 
            // buttonSaveReport
            // 
            buttonSaveReport.Location = new Point(64, 392);
            buttonSaveReport.Name = "buttonSaveReport";
            buttonSaveReport.Size = new Size(292, 25);
            buttonSaveReport.TabIndex = 9;
            buttonSaveReport.Text = "Save Report";
            buttonSaveReport.UseVisualStyleBackColor = true;
            buttonSaveReport.Click += buttonSaveReport_Click;
            // 
            // panelOuterOption
            // 
            panelOuterOption.Controls.Add(labelImageName);
            panelOuterOption.Controls.Add(buttonSave);
            panelOuterOption.Controls.Add(textBoxImageName);
            panelOuterOption.Location = new Point(1033, 429);
            panelOuterOption.Name = "panelOuterOption";
            panelOuterOption.Size = new Size(121, 99);
            panelOuterOption.TabIndex = 6;
            panelOuterOption.Visible = false;
            // 
            // labelImageName
            // 
            labelImageName.AutoSize = true;
            labelImageName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelImageName.Location = new Point(3, 3);
            labelImageName.Name = "labelImageName";
            labelImageName.Size = new Size(108, 21);
            labelImageName.TabIndex = 7;
            labelImageName.Text = "Image Name";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(3, 61);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(108, 25);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxImageName
            // 
            textBoxImageName.Location = new Point(3, 30);
            textBoxImageName.Name = "textBoxImageName";
            textBoxImageName.Size = new Size(108, 23);
            textBoxImageName.TabIndex = 5;
            // 
            // panelImageOption
            // 
            panelImageOption.Controls.Add(buttonFourier);
            panelImageOption.Controls.Add(buttonCut);
            panelImageOption.Controls.Add(buttonRainbow);
            panelImageOption.Controls.Add(buttonSpring);
            panelImageOption.Controls.Add(buttonNormal);
            panelImageOption.Controls.Add(buttonCool);
            panelImageOption.Controls.Add(buttonJet);
            panelImageOption.Controls.Add(buttonHot);
            panelImageOption.Controls.Add(buttonSpectrum);
            panelImageOption.Controls.Add(buttonDelete);
            panelImageOption.Location = new Point(309, 3);
            panelImageOption.Name = "panelImageOption";
            panelImageOption.Size = new Size(100, 420);
            panelImageOption.TabIndex = 4;
            panelImageOption.Visible = false;
            // 
            // buttonFourier
            // 
            buttonFourier.Location = new Point(3, 312);
            buttonFourier.Name = "buttonFourier";
            buttonFourier.Size = new Size(94, 25);
            buttonFourier.TabIndex = 9;
            buttonFourier.Text = "Fourier";
            buttonFourier.UseVisualStyleBackColor = true;
            buttonFourier.Click += buttonFourier_Click;
            // 
            // buttonCut
            // 
            buttonCut.Location = new Point(3, 281);
            buttonCut.Name = "buttonCut";
            buttonCut.Size = new Size(94, 25);
            buttonCut.TabIndex = 8;
            buttonCut.Text = "Cut";
            buttonCut.UseVisualStyleBackColor = true;
            buttonCut.Click += buttonCut_Click;
            // 
            // buttonRainbow
            // 
            buttonRainbow.Location = new Point(3, 220);
            buttonRainbow.Name = "buttonRainbow";
            buttonRainbow.Size = new Size(94, 25);
            buttonRainbow.TabIndex = 7;
            buttonRainbow.Text = "Rainbow";
            buttonRainbow.UseVisualStyleBackColor = true;
            buttonRainbow.Click += buttonRainbow_Click;
            // 
            // buttonSpring
            // 
            buttonSpring.Location = new Point(3, 189);
            buttonSpring.Name = "buttonSpring";
            buttonSpring.Size = new Size(94, 25);
            buttonSpring.TabIndex = 6;
            buttonSpring.Text = "Spring";
            buttonSpring.UseVisualStyleBackColor = true;
            buttonSpring.Click += buttonSpring_Click;
            // 
            // buttonNormal
            // 
            buttonNormal.Location = new Point(3, 251);
            buttonNormal.Name = "buttonNormal";
            buttonNormal.Size = new Size(94, 25);
            buttonNormal.TabIndex = 5;
            buttonNormal.Text = "Normal";
            buttonNormal.UseVisualStyleBackColor = true;
            buttonNormal.Click += buttonNormal_Click;
            // 
            // buttonCool
            // 
            buttonCool.Location = new Point(3, 158);
            buttonCool.Name = "buttonCool";
            buttonCool.Size = new Size(94, 25);
            buttonCool.TabIndex = 4;
            buttonCool.Text = "Cool";
            buttonCool.UseVisualStyleBackColor = true;
            buttonCool.Click += buttonCool_Click;
            // 
            // buttonJet
            // 
            buttonJet.Location = new Point(3, 127);
            buttonJet.Name = "buttonJet";
            buttonJet.Size = new Size(94, 25);
            buttonJet.TabIndex = 3;
            buttonJet.Text = "Jet";
            buttonJet.UseVisualStyleBackColor = true;
            buttonJet.Click += buttonJet_Click;
            // 
            // buttonHot
            // 
            buttonHot.Location = new Point(3, 96);
            buttonHot.Name = "buttonHot";
            buttonHot.Size = new Size(94, 25);
            buttonHot.TabIndex = 2;
            buttonHot.Text = "Hot";
            buttonHot.UseVisualStyleBackColor = true;
            buttonHot.Click += buttonHot_Click;
            // 
            // buttonSpectrum
            // 
            buttonSpectrum.Location = new Point(3, 65);
            buttonSpectrum.Name = "buttonSpectrum";
            buttonSpectrum.Size = new Size(94, 25);
            buttonSpectrum.TabIndex = 1;
            buttonSpectrum.Text = "Spectrum";
            buttonSpectrum.UseVisualStyleBackColor = true;
            buttonSpectrum.Click += buttonSpectrum_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = Properties.Resources.delete;
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.Location = new Point(10, 3);
            buttonDelete.Margin = new Padding(10, 3, 10, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(80, 56);
            buttonDelete.TabIndex = 0;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panelDrowOption
            // 
            panelDrowOption.BorderStyle = BorderStyle.FixedSingle;
            panelDrowOption.Controls.Add(buttonClearDrow);
            panelDrowOption.Controls.Add(buttonFree);
            panelDrowOption.Controls.Add(buttonCircle);
            panelDrowOption.Controls.Add(buttonRect);
            panelDrowOption.Controls.Add(labelDrow);
            panelDrowOption.Location = new Point(3, 431);
            panelDrowOption.Name = "panelDrowOption";
            panelDrowOption.Size = new Size(300, 97);
            panelDrowOption.TabIndex = 3;
            panelDrowOption.Visible = false;
            // 
            // buttonClearDrow
            // 
            buttonClearDrow.Location = new Point(205, 67);
            buttonClearDrow.Name = "buttonClearDrow";
            buttonClearDrow.Size = new Size(90, 25);
            buttonClearDrow.TabIndex = 4;
            buttonClearDrow.Text = "Clear";
            buttonClearDrow.UseVisualStyleBackColor = true;
            buttonClearDrow.Click += buttonClearDrow_Click;
            // 
            // buttonFree
            // 
            buttonFree.Location = new Point(205, 30);
            buttonFree.Name = "buttonFree";
            buttonFree.Size = new Size(90, 25);
            buttonFree.TabIndex = 3;
            buttonFree.Text = "Free";
            buttonFree.UseVisualStyleBackColor = true;
            buttonFree.Click += buttonFree_Click;
            // 
            // buttonCircle
            // 
            buttonCircle.Location = new Point(105, 30);
            buttonCircle.Name = "buttonCircle";
            buttonCircle.Size = new Size(90, 25);
            buttonCircle.TabIndex = 2;
            buttonCircle.Text = "Circle";
            buttonCircle.UseVisualStyleBackColor = true;
            buttonCircle.Click += buttonCircle_Click;
            // 
            // buttonRect
            // 
            buttonRect.Location = new Point(3, 30);
            buttonRect.Name = "buttonRect";
            buttonRect.Size = new Size(90, 25);
            buttonRect.TabIndex = 1;
            buttonRect.Text = "Rectangular";
            buttonRect.UseVisualStyleBackColor = true;
            buttonRect.Click += buttonRect_Click;
            // 
            // labelDrow
            // 
            labelDrow.AutoSize = true;
            labelDrow.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDrow.Location = new Point(81, 0);
            labelDrow.Name = "labelDrow";
            labelDrow.Size = new Size(139, 21);
            labelDrow.TabIndex = 0;
            labelDrow.Text = "Drawing Options";
            labelDrow.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBoxOuter
            // 
            pictureBoxOuter.Location = new Point(857, 3);
            pictureBoxOuter.Name = "pictureBoxOuter";
            pictureBoxOuter.Size = new Size(300, 420);
            pictureBoxOuter.TabIndex = 2;
            pictureBoxOuter.TabStop = false;
            pictureBoxOuter.MouseUp += pictureBoxOuter_MouseUp;
            // 
            // pictureBoxEnter
            // 
            pictureBoxEnter.Location = new Point(3, 3);
            pictureBoxEnter.Name = "pictureBoxEnter";
            pictureBoxEnter.Size = new Size(300, 420);
            pictureBoxEnter.TabIndex = 1;
            pictureBoxEnter.TabStop = false;
            pictureBoxEnter.MouseDown += pictureBoxEnter_MouseDown;
            pictureBoxEnter.MouseUp += pictureBoxEnter_MouseUp;
            // 
            // buttonUpload
            // 
            buttonUpload.BackColor = SystemColors.Window;
            buttonUpload.BackgroundImage = Properties.Resources.upload;
            buttonUpload.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUpload.Location = new Point(451, 113);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(228, 196);
            buttonUpload.TabIndex = 0;
            buttonUpload.UseVisualStyleBackColor = false;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // panelLayoutCompare
            // 
            panelLayoutCompare.Controls.Add(labelResultCompare);
            panelLayoutCompare.Controls.Add(buttonCompare);
            panelLayoutCompare.Controls.Add(buttonUploadCompare2);
            panelLayoutCompare.Controls.Add(buttonUploadCompare1);
            panelLayoutCompare.Controls.Add(pictureBoxCompare2);
            panelLayoutCompare.Controls.Add(pictureBoxCompare1);
            panelLayoutCompare.Location = new Point(12, 68);
            panelLayoutCompare.Name = "panelLayoutCompare";
            panelLayoutCompare.Size = new Size(1160, 528);
            panelLayoutCompare.TabIndex = 15;
            panelLayoutCompare.Visible = false;
            // 
            // labelResultCompare
            // 
            labelResultCompare.AutoSize = true;
            labelResultCompare.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelResultCompare.Location = new Point(871, 223);
            labelResultCompare.Name = "labelResultCompare";
            labelResultCompare.Size = new Size(0, 28);
            labelResultCompare.TabIndex = 5;
            // 
            // buttonCompare
            // 
            buttonCompare.Location = new Point(732, 225);
            buttonCompare.Name = "buttonCompare";
            buttonCompare.Size = new Size(99, 23);
            buttonCompare.TabIndex = 4;
            buttonCompare.Text = "Compare";
            buttonCompare.UseVisualStyleBackColor = true;
            buttonCompare.Visible = false;
            buttonCompare.Click += buttonCompare_Click;
            // 
            // buttonUploadCompare2
            // 
            buttonUploadCompare2.Location = new Point(468, 22);
            buttonUploadCompare2.Name = "buttonUploadCompare2";
            buttonUploadCompare2.Size = new Size(112, 23);
            buttonUploadCompare2.TabIndex = 3;
            buttonUploadCompare2.Text = "Upload 2";
            buttonUploadCompare2.UseVisualStyleBackColor = true;
            buttonUploadCompare2.Click += buttonUploadCompare2_Click;
            // 
            // buttonUploadCompare1
            // 
            buttonUploadCompare1.Location = new Point(109, 24);
            buttonUploadCompare1.Name = "buttonUploadCompare1";
            buttonUploadCompare1.Size = new Size(115, 23);
            buttonUploadCompare1.TabIndex = 2;
            buttonUploadCompare1.Text = "Upload 1";
            buttonUploadCompare1.UseVisualStyleBackColor = true;
            buttonUploadCompare1.Click += buttonUploadCompare1_Click;
            // 
            // pictureBoxCompare2
            // 
            pictureBoxCompare2.Location = new Point(379, 53);
            pictureBoxCompare2.Name = "pictureBoxCompare2";
            pictureBoxCompare2.Size = new Size(300, 420);
            pictureBoxCompare2.TabIndex = 1;
            pictureBoxCompare2.TabStop = false;
            // 
            // pictureBoxCompare1
            // 
            pictureBoxCompare1.Location = new Point(22, 53);
            pictureBoxCompare1.Name = "pictureBoxCompare1";
            pictureBoxCompare1.Size = new Size(300, 420);
            pictureBoxCompare1.TabIndex = 0;
            pictureBoxCompare1.TabStop = false;
            // 
            // panelLayoutDisplay
            // 
            panelLayoutDisplay.Controls.Add(flowLayoutPanelData);
            panelLayoutDisplay.Location = new Point(12, 74);
            panelLayoutDisplay.Name = "panelLayoutDisplay";
            panelLayoutDisplay.Size = new Size(1160, 531);
            panelLayoutDisplay.TabIndex = 1;
            panelLayoutDisplay.Visible = false;
            // 
            // flowLayoutPanelData
            // 
            flowLayoutPanelData.AutoScroll = true;
            flowLayoutPanelData.Location = new Point(7, 3);
            flowLayoutPanelData.Name = "flowLayoutPanelData";
            flowLayoutPanelData.Size = new Size(1147, 490);
            flowLayoutPanelData.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 611);
            Controls.Add(panelLayoutCompare);
            Controls.Add(panelLayoutDisplay);
            Controls.Add(panelLayoutNew);
            Controls.Add(panelNavbar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panelLayoutNew.ResumeLayout(false);
            panelLayoutNew.PerformLayout();
            panelRecordingOption.ResumeLayout(false);
            panelRecordingOption.PerformLayout();
            panelOuterOptionReport.ResumeLayout(false);
            panelOuterOptionReport.PerformLayout();
            panelOuterOption.ResumeLayout(false);
            panelOuterOption.PerformLayout();
            panelImageOption.ResumeLayout(false);
            panelDrowOption.ResumeLayout(false);
            panelDrowOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOuter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnter).EndInit();
            panelLayoutCompare.ResumeLayout(false);
            panelLayoutCompare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompare2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompare1).EndInit();
            panelLayoutDisplay.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private Button buttonNavCompare;
        private Button buttonNavNew;
        private Panel panelLayoutNew;
        private Button buttonUpload;
        private PictureBox pictureBoxEnter;
        private PictureBox pictureBoxOuter;
        private Panel panelDrowOption;
        private Label labelDrow;
        private Button buttonRect;
        private Button buttonCircle;
        private Button buttonFree;
        private Panel panelImageOption;
        private Button buttonCool;
        private Button buttonJet;
        private Button buttonHot;
        private Button buttonSpectrum;
        private Button buttonDelete;
        private TextBox textBoxImageName;
        private Panel panelOuterOption;
        private Button buttonSave;
        private Label labelImageName;
        private Button buttonNormal;
        private Button buttonNavDisplay;
        private Panel panelLayoutDisplay;
        private FlowLayoutPanel flowLayoutPanelData;
        private Label labelAudioDescription;
        private Button buttonRecording;
        private Panel panelOuterOptionReport;
        private Button buttonPlayAudio;
        private Button buttonStopRecording;
        private Button buttonStopAudio;
        private Panel panelRecordingOption;
        private Button buttonDeleteRecord;
        private Button buttonClearDrow;
        private Button buttonRainbow;
        private Button buttonSpring;
        private Button buttonCut;
        private Button buttonSaveReport;
        private TextBox textBoxPatientName;
        private Label label1;
        private TextBox textBoxPatientAge;
        private Label label2;
        private TextBox textBoxDiagnosis;
        private Label label3;
        private Label label4;
        private TextBox textBoxDoctorRecommendation;
        private Label label5;
        private TextBox textBoxDoctorName;
        private Button buttonAddNote;
        private TextBox textBoxNote;
        private Button buttonCompress;
        private Button buttonFourier;
        private Panel panelLayoutCompare;
        private PictureBox pictureBoxCompare2;
        private PictureBox pictureBoxCompare1;
        private Button buttonCompare;
        private Button buttonUploadCompare2;
        private Button buttonUploadCompare1;
        private Label labelResultCompare;
        private Button buttonTelegram;
        private TextBox textBoxSearchSize;
        private TextBox textBoxSearchDate;
        private Button buttonSearchDate;
        private Button buttonSearchSize;
    }
}