namespace MainScreen
{
    partial class FormVisitorMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisitorMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMBA = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelVisitorMenu = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panelFourButton = new System.Windows.Forms.Panel();
            this.buttonPlayers = new System.Windows.Forms.Button();
            this.buttonTeams = new System.Windows.Forms.Button();
            this.buttonPhotos = new System.Windows.Forms.Button();
            this.buttonMatchups = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panelFourButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.labelVisitorMenu);
            this.panel1.Controls.Add(this.labelMBA);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 0;
            // 
            // labelMBA
            // 
            this.labelMBA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMBA.AutoSize = true;
            this.labelMBA.Location = new System.Drawing.Point(44, 28);
            this.labelMBA.Name = "labelMBA";
            this.labelMBA.Size = new System.Drawing.Size(127, 13);
            this.labelMBA.TabIndex = 1;
            this.labelMBA.Text = "MBA  Menegment system";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(38, 64);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelVisitorMenu
            // 
            this.labelVisitorMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVisitorMenu.AutoSize = true;
            this.labelVisitorMenu.Location = new System.Drawing.Point(336, 26);
            this.labelVisitorMenu.Name = "labelVisitorMenu";
            this.labelVisitorMenu.Size = new System.Drawing.Size(65, 13);
            this.labelVisitorMenu.TabIndex = 3;
            this.labelVisitorMenu.Text = "Visitor Menu";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(702, 21);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 422);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(800, 28);
            this.panelInfo.TabIndex = 1;
            // 
            // labelInfo
            // 
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelInfo.Location = new System.Drawing.Point(0, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(800, 28);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "The current season is 2016–2017, and the NBA already has a history of 71 years";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFourButton
            // 
            this.panelFourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFourButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFourButton.Controls.Add(this.buttonPhotos);
            this.panelFourButton.Controls.Add(this.buttonMatchups);
            this.panelFourButton.Controls.Add(this.buttonPlayers);
            this.panelFourButton.Controls.Add(this.buttonTeams);
            this.panelFourButton.Location = new System.Drawing.Point(148, 141);
            this.panelFourButton.Name = "panelFourButton";
            this.panelFourButton.Size = new System.Drawing.Size(513, 217);
            this.panelFourButton.TabIndex = 5;
            // 
            // buttonPlayers
            // 
            this.buttonPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlayers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlayers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPlayers.Location = new System.Drawing.Point(255, 26);
            this.buttonPlayers.Name = "buttonPlayers";
            this.buttonPlayers.Size = new System.Drawing.Size(149, 71);
            this.buttonPlayers.TabIndex = 1;
            this.buttonPlayers.Text = "Players";
            this.buttonPlayers.UseVisualStyleBackColor = false;
            this.buttonPlayers.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonTeams
            // 
            this.buttonTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTeams.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTeams.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTeams.Location = new System.Drawing.Point(92, 26);
            this.buttonTeams.Name = "buttonTeams";
            this.buttonTeams.Size = new System.Drawing.Size(143, 71);
            this.buttonTeams.TabIndex = 0;
            this.buttonTeams.Text = "Teams";
            this.buttonTeams.UseVisualStyleBackColor = false;
            // 
            // buttonPhotos
            // 
            this.buttonPhotos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPhotos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPhotos.Location = new System.Drawing.Point(255, 115);
            this.buttonPhotos.Name = "buttonPhotos";
            this.buttonPhotos.Size = new System.Drawing.Size(149, 71);
            this.buttonPhotos.TabIndex = 3;
            this.buttonPhotos.Text = "Photos";
            this.buttonPhotos.UseVisualStyleBackColor = false;
            this.buttonPhotos.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMatchups
            // 
            this.buttonMatchups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMatchups.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMatchups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatchups.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMatchups.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMatchups.Location = new System.Drawing.Point(92, 115);
            this.buttonMatchups.Name = "buttonMatchups";
            this.buttonMatchups.Size = new System.Drawing.Size(143, 71);
            this.buttonMatchups.TabIndex = 2;
            this.buttonMatchups.Text = "Matchups";
            this.buttonMatchups.UseVisualStyleBackColor = false;
            // 
            // FormVisitorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFourButton);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panel1);
            this.Name = "FormVisitorMain";
            this.Text = "visitorMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelFourButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMBA;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelVisitorMenu;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panelFourButton;
        private System.Windows.Forms.Button buttonPhotos;
        private System.Windows.Forms.Button buttonMatchups;
        private System.Windows.Forms.Button buttonPlayers;
        private System.Windows.Forms.Button buttonTeams;
    }
}