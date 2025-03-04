namespace XAMPP_FixAriaError
{
    partial class frmAriaRepair
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
            this.lblMain1 = new System.Windows.Forms.Label();
            this.lblXAMPPv1 = new System.Windows.Forms.Label();
            this.lblXAMPPVersion = new System.Windows.Forms.Label();
            this.lblXAMPPl1 = new System.Windows.Forms.Label();
            this.lblXAMPPLocation = new System.Windows.Forms.Label();
            this.btnEditLocation = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.fbdInstallFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblMain1
            // 
            this.lblMain1.AutoSize = true;
            this.lblMain1.Location = new System.Drawing.Point(15, 11);
            this.lblMain1.Name = "lblMain1";
            this.lblMain1.Size = new System.Drawing.Size(590, 48);
            this.lblMain1.TabIndex = 0;
            this.lblMain1.Text = "Op de één of andere vreemde manier loopt het mis bij de opstart van MySQL (MariaD" +
    "B) in XAMPP.\r\n\r\nDit programma biedt mogelijk een oplossing.";
            // 
            // lblXAMPPv1
            // 
            this.lblXAMPPv1.AutoSize = true;
            this.lblXAMPPv1.Location = new System.Drawing.Point(15, 102);
            this.lblXAMPPv1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXAMPPv1.Name = "lblXAMPPv1";
            this.lblXAMPPv1.Size = new System.Drawing.Size(191, 16);
            this.lblXAMPPv1.TabIndex = 1;
            this.lblXAMPPv1.Text = "Gedetecteerde XAMPP-versie:";
            // 
            // lblXAMPPVersion
            // 
            this.lblXAMPPVersion.AutoSize = true;
            this.lblXAMPPVersion.Location = new System.Drawing.Point(263, 102);
            this.lblXAMPPVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXAMPPVersion.Name = "lblXAMPPVersion";
            this.lblXAMPPVersion.Size = new System.Drawing.Size(79, 16);
            this.lblXAMPPVersion.TabIndex = 2;
            this.lblXAMPPVersion.Text = "<<version>>";
            // 
            // lblXAMPPl1
            // 
            this.lblXAMPPl1.AutoSize = true;
            this.lblXAMPPl1.Location = new System.Drawing.Point(16, 132);
            this.lblXAMPPl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXAMPPl1.Name = "lblXAMPPl1";
            this.lblXAMPPl1.Size = new System.Drawing.Size(194, 16);
            this.lblXAMPPl1.TabIndex = 3;
            this.lblXAMPPl1.Text = "Gedetecteerde XAMPP-locatie:";
            // 
            // lblXAMPPLocation
            // 
            this.lblXAMPPLocation.AutoSize = true;
            this.lblXAMPPLocation.Location = new System.Drawing.Point(263, 132);
            this.lblXAMPPLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXAMPPLocation.Name = "lblXAMPPLocation";
            this.lblXAMPPLocation.Size = new System.Drawing.Size(82, 16);
            this.lblXAMPPLocation.TabIndex = 4;
            this.lblXAMPPLocation.Text = "<<location>>";
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Location = new System.Drawing.Point(600, 119);
            this.btnEditLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(43, 39);
            this.btnEditLocation.TabIndex = 5;
            this.btnEditLocation.TabStop = false;
            this.btnEditLocation.Text = "✏️";
            this.btnEditLocation.UseVisualStyleBackColor = true;
            this.btnEditLocation.Click += new System.EventHandler(this.btnEditLocation_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Enabled = false;
            this.btnRepair.Location = new System.Drawing.Point(231, 276);
            this.btnRepair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(267, 62);
            this.btnRepair.TabIndex = 6;
            this.btnRepair.Text = "Repareer de Aria-fout";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // fbdInstallFolder
            // 
            this.fbdInstallFolder.Description = "Selecteer de map waarin xampp-control.exe zich bevindt. Dit is de hoofdmap van de" +
    " XAMPP-installatie.";
            this.fbdInstallFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fbdInstallFolder.SelectedPath = "C:\\";
            this.fbdInstallFolder.ShowNewFolderButton = false;
            this.fbdInstallFolder.HelpRequest += new System.EventHandler(this.fbdInstallFolder_HelpRequest);
            // 
            // frmAriaRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 432);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.btnEditLocation);
            this.Controls.Add(this.lblXAMPPLocation);
            this.Controls.Add(this.lblXAMPPl1);
            this.Controls.Add(this.lblXAMPPVersion);
            this.Controls.Add(this.lblXAMPPv1);
            this.Controls.Add(this.lblMain1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(726, 479);
            this.MinimumSize = new System.Drawing.Size(726, 479);
            this.Name = "frmAriaRepair";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XAMPP - Repareer de \'aria\'-fout";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAriaRepair_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain1;
        private System.Windows.Forms.Label lblXAMPPv1;
        private System.Windows.Forms.Label lblXAMPPVersion;
        private System.Windows.Forms.Label lblXAMPPl1;
        private System.Windows.Forms.Label lblXAMPPLocation;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.FolderBrowserDialog fbdInstallFolder;
    }
}

