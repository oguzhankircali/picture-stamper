using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budala.PictureStamper
{
    public partial class Form1 : Form
    {
        int decimalPointNumber = 4;
        int totalPublishedTicketCount;
        int totalTicketCount;
        string resourceImagePath;
        Color ticketFontColor;
        string directoryPath;
        bool isFinished;


        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            bwTicket.DoWork += bwTicket_DoWork;
            bwTicket.ProgressChanged += bwTicket_ProgressChanged;
            bwTicket.WorkerReportsProgress = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshTicketForm();
        }

        private void RefreshTicketForm()
        {
            ofdPicture.Reset();
            totalTicketCount = 50;
            totalPublishedTicketCount = 0;
            ticketFontColor = Color.Black;
            lblColor.Text = ticketFontColor.Name;
            bwTicket.Dispose();
            pbTicket.Value = 0;
            isFinished = false;

            //DIRECTORY PATH
            SetPublishDirectory();

            Application.DoEvents();
        }

        private void SetPublishDirectory()
        {
            directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "oguzhan");
            if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
            lblDestinationFolder.Text = directoryPath;
        }

        private void tmrTicket_Tick(object sender, EventArgs e)
        {

        }

        #region PROCESS

        private void btnJustDoIt_Click(object sender, EventArgs e)
        {
            if (btnJustDoIt.Text == Properties.Resources.btnJustDoIt)
            {
                if (!String.IsNullOrEmpty(txtNumberOfTickets.Text))
                {
                    if (int.TryParse(txtNumberOfTickets.Text, out totalTicketCount))
                    {
                        pbTicket.Value = 0;
                        isFinished = false;
                        totalPublishedTicketCount = 0;
                        SetPublishDirectory();

                        if (!bwTicket.IsBusy)
                        {
                            bwTicket.RunWorkerAsync();
                            btnJustDoIt.Text = Properties.Resources.btnStopIt;
                        }

                    }
                    else
                        MessageBox.Show("Please, enter a number characters");
                }
                else
                    MessageBox.Show("Please, enter number of tickets");
            }
            else
            {
                RefreshTicketForm();
                MessageBox.Show("Process has been corrupted by the user.");

            }
        }

        public Bitmap WaterMarkToImage(string ImagePath, string watermark)
        {
            Bitmap bmp;
            if (!String.IsNullOrEmpty(ofdPicture.FileName)) bmp = new Bitmap(ImagePath);
            else bmp = new Bitmap(Budala.PictureStamper.Properties.Resources.ticket);


            Graphics graphicsObject;
            int x, y;
            try
            {
                //create graphics object from bitmap
                graphicsObject = Graphics.FromImage(bmp);
            }
            catch (Exception e)
            {

                Bitmap bmpNew = new Bitmap(bmp.Width, bmp.Height);
                graphicsObject = Graphics.FromImage(bmpNew);

                graphicsObject.DrawImage(bmp, new Rectangle(0, 0, 100, 70), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);

                bmp = bmpNew;
            }

            int startsize = (bmp.Width / watermark.Length);//get the font size with respect to length of the string

            //x and y cordinates to draw a string
            x = 300;
            y = bmp.Height / 2 - 85;

            //System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical); -> draws a vertical string for watermark
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.NoWrap);

            int red = ticketFontColor.ToArgb();
            //drawing string on Image
            //Color c = Color.FromArgb(255, 255, 255, 255);
            graphicsObject.DrawString(watermark, new Font("Verdana", 40, FontStyle.Bold), new SolidBrush(Color.FromArgb(255, ticketFontColor)), x, y, drawFormat);

            //return a water marked image



            return (bmp);
        }

        private string GetImageName(int number)
        {
            string zeroString = String.Empty;
            string numberString = number.ToString();

            int zeroCount = decimalPointNumber - numberString.ToCharArray().Count();
            for (int i = 1; i < zeroCount + 1; i++)
                zeroString += "0";

            return zeroString + numberString;

        }

        #endregion

        #region BUTTONS

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ticketFontColor = colorDialog1.Color;
                lblColor.Text = ticketFontColor.Name;
            }
        }

        private void lnkChangePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ofdPicture.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lnkBackDefault.Visible = true;
                resourceImagePath = ofdPicture.FileName;
                pbImage.Image = new Bitmap(ofdPicture.FileName);
            }
        }

        private void lnkBackDefault_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdPicture.Reset();
            pbImage.Image = Budala.PictureStamper.Properties.Resources.ticket;
            lnkBackDefault.Visible = false;
        }

        private void lnkDestinationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                directoryPath = lblDestinationFolder.Text = fbd.SelectedPath;
        }

        #endregion

        #region BACKGROUND WORKER

        private void bwTicket_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnJustDoIt.Text = Properties.Resources.btnJustDoIt;
        }

        private void bwTicket_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                if (!isFinished) 
                {
                    for (int i = 0; i < totalTicketCount; i++)
                    {
                        System.Drawing.Bitmap bmp = WaterMarkToImage(resourceImagePath, GetImageName(i));
                        bmp.Save(Path.Combine(directoryPath, (GetImageName(i + 1) + ".png")), System.Drawing.Imaging.ImageFormat.Png);
                        totalPublishedTicketCount += 1;

                        if (totalPublishedTicketCount % 10000 == 0)
                            System.Threading.Thread.Sleep(1000); //Sleep time

                        decimal a = ((decimal)totalPublishedTicketCount / (decimal)totalTicketCount) * (decimal)100;
                        pbTicket.Value = a > 100 ? 100 : (int)a;
                        bwTicket.ReportProgress(pbTicket.Value);


                        //FINISH MESSAGE
                        if (pbTicket.Value == 100)
                        {
                            tmrTicket.Stop();
                            if (bwTicket.IsBusy) bwTicket.CancelAsync();

                            isFinished = true;

                            MessageBox.Show("Your all tickets have been published successfully.");
                            break;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured. Say this message to Oğuzhan: " + ex.Message);
            }


        }

        private void bwTicket_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            pbTicket.Value = e.ProgressPercentage;
        }

        #endregion

    }
}
