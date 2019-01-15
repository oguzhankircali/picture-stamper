namespace Budala.PictureStamper
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.btnJustDoIt = new System.Windows.Forms.Button();
            this.pbTicket = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tmrTicket = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.lnkChangePicture = new System.Windows.Forms.LinkLabel();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.lnkBackDefault = new System.Windows.Forms.LinkLabel();
            this.lblDestinationFolder = new System.Windows.Forms.Label();
            this.bwTicket = new System.ComponentModel.BackgroundWorker();
            this.lnkDestinationLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticket Preview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(393, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Tickets: ";
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Location = new System.Drawing.Point(576, 138);
            this.txtNumberOfTickets.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(261, 22);
            this.txtNumberOfTickets.TabIndex = 3;
            // 
            // btnJustDoIt
            // 
            this.btnJustDoIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnJustDoIt.Location = new System.Drawing.Point(399, 244);
            this.btnJustDoIt.Margin = new System.Windows.Forms.Padding(4);
            this.btnJustDoIt.Name = "btnJustDoIt";
            this.btnJustDoIt.Size = new System.Drawing.Size(440, 66);
            this.btnJustDoIt.TabIndex = 4;
            this.btnJustDoIt.Text = "Just do it!";
            this.btnJustDoIt.UseVisualStyleBackColor = true;
            this.btnJustDoIt.Click += new System.EventHandler(this.btnJustDoIt_Click);
            // 
            // pbTicket
            // 
            this.pbTicket.Location = new System.Drawing.Point(59, 410);
            this.pbTicket.Margin = new System.Windows.Forms.Padding(4);
            this.pbTicket.Name = "pbTicket";
            this.pbTicket.Size = new System.Drawing.Size(780, 28);
            this.pbTicket.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Location = new System.Drawing.Point(59, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 165);
            this.panel1.TabIndex = 6;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(296, 165);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // tmrTicket
            // 
            this.tmrTicket.Tick += new System.EventHandler(this.tmrTicket_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(393, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Font Color: ";
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Location = new System.Drawing.Point(767, 187);
            this.btnSelectColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(72, 30);
            this.btnSelectColor.TabIndex = 8;
            this.btnSelectColor.Text = "Select";
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblColor.ForeColor = System.Drawing.Color.Gray;
            this.lblColor.Location = new System.Drawing.Point(572, 192);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(108, 20);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Default Color";
            // 
            // lnkChangePicture
            // 
            this.lnkChangePicture.AutoSize = true;
            this.lnkChangePicture.Location = new System.Drawing.Point(55, 314);
            this.lnkChangePicture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkChangePicture.Name = "lnkChangePicture";
            this.lnkChangePicture.Size = new System.Drawing.Size(105, 17);
            this.lnkChangePicture.TabIndex = 10;
            this.lnkChangePicture.TabStop = true;
            this.lnkChangePicture.Text = "Change Picture";
            this.lnkChangePicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChangePicture_LinkClicked);
            // 
            // ofdPicture
            // 
            this.ofdPicture.FileName = "openFileDialog1";
            // 
            // lnkBackDefault
            // 
            this.lnkBackDefault.AutoSize = true;
            this.lnkBackDefault.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkBackDefault.Location = new System.Drawing.Point(247, 314);
            this.lnkBackDefault.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkBackDefault.Name = "lnkBackDefault";
            this.lnkBackDefault.Size = new System.Drawing.Size(104, 17);
            this.lnkBackDefault.TabIndex = 11;
            this.lnkBackDefault.TabStop = true;
            this.lnkBackDefault.Text = "Back to Default";
            this.lnkBackDefault.Visible = false;
            this.lnkBackDefault.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBackDefault_LinkClicked);
            // 
            // lblDestinationFolder
            // 
            this.lblDestinationFolder.AutoSize = true;
            this.lblDestinationFolder.Location = new System.Drawing.Point(189, 380);
            this.lblDestinationFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinationFolder.Name = "lblDestinationFolder";
            this.lblDestinationFolder.Size = new System.Drawing.Size(46, 17);
            this.lblDestinationFolder.TabIndex = 13;
            this.lblDestinationFolder.Text = "label4";
            // 
            // bwTicket
            // 
            this.bwTicket.WorkerSupportsCancellation = true;
            this.bwTicket.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwTicket_DoWork);
            this.bwTicket.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwTicket_ProgressChanged);
            this.bwTicket.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwTicket_RunWorkerCompleted);
            // 
            // lnkDestinationLabel
            // 
            this.lnkDestinationLabel.AutoSize = true;
            this.lnkDestinationLabel.Location = new System.Drawing.Point(55, 380);
            this.lnkDestinationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkDestinationLabel.Name = "lnkDestinationLabel";
            this.lnkDestinationLabel.Size = new System.Drawing.Size(131, 17);
            this.lnkDestinationLabel.TabIndex = 14;
            this.lnkDestinationLabel.TabStop = true;
            this.lnkDestinationLabel.Text = "Destination Folder: ";
            this.lnkDestinationLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDestinationLabel_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(47, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(467, 66);
            this.label4.TabIndex = 15;
            this.label4.Text = "Picture Stamper";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnkDestinationLabel);
            this.Controls.Add(this.lblDestinationFolder);
            this.Controls.Add(this.lnkBackDefault);
            this.Controls.Add(this.lnkChangePicture);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnSelectColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbTicket);
            this.Controls.Add(this.btnJustDoIt);
            this.Controls.Add(this.txtNumberOfTickets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Picture Stamper by Budala";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberOfTickets;
        private System.Windows.Forms.Button btnJustDoIt;
        private System.Windows.Forms.ProgressBar pbTicket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.LinkLabel lnkChangePicture;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.LinkLabel lnkBackDefault;
        private System.Windows.Forms.Label lblDestinationFolder;
        private System.ComponentModel.BackgroundWorker bwTicket;
        private System.Windows.Forms.LinkLabel lnkDestinationLabel;
        private System.Windows.Forms.Label label4;
    }
}

