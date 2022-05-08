namespace The_Cosmic_Isles
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
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.picCosmicTitle = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCosmicTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Image = global::The_Cosmic_Isles.Properties.Resources.cosmic_isles_logo_with_background;
            this.picTitle.Location = new System.Drawing.Point(-4, -6);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(745, 456);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // picCosmicTitle
            // 
            this.picCosmicTitle.BackColor = System.Drawing.Color.Transparent;
            this.picCosmicTitle.Image = global::The_Cosmic_Isles.Properties.Resources.summer_cosmic;
            this.picCosmicTitle.Location = new System.Drawing.Point(747, 40);
            this.picCosmicTitle.Name = "picCosmicTitle";
            this.picCosmicTitle.Size = new System.Drawing.Size(674, 657);
            this.picCosmicTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCosmicTitle.TabIndex = 1;
            this.picCosmicTitle.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNewGame.FlatAppearance.BorderSize = 5;
            this.btnNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Hotel Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Magenta;
            this.btnNewGame.Location = new System.Drawing.Point(193, 456);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(335, 64);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSettings.FlatAppearance.BorderSize = 5;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Hotel Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Magenta;
            this.btnSettings.Location = new System.Drawing.Point(193, 526);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(335, 64);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.FlatAppearance.BorderSize = 5;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Hotel Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Magenta;
            this.btnExit.Location = new System.Drawing.Point(193, 596);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(335, 64);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Cosmic_Isles.Properties.Resources.title_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 689);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.picCosmicTitle);
            this.Controls.Add(this.picTitle);
            this.Name = "Form1";
            this.Text = "The Cosmic Isles";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCosmicTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picCosmicTitle;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExit;
    }
}

