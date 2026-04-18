namespace Floppy_Dude
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
            this.floppyDude = new System.Windows.Forms.PictureBox();
            this.skyCloud = new System.Windows.Forms.PictureBox();
            this.groundGrass = new System.Windows.Forms.PictureBox();
            this.brick1 = new System.Windows.Forms.PictureBox();
            this.brick2 = new System.Windows.Forms.PictureBox();
            this.brick3 = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.floppyDude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundGrass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).BeginInit();
            this.SuspendLayout();
            // 
            // floppyDude
            // 
            this.floppyDude.Image = ((System.Drawing.Image)(resources.GetObject("floppyDude.Image")));
            this.floppyDude.Location = new System.Drawing.Point(94, 173);
            this.floppyDude.Name = "floppyDude";
            this.floppyDude.Size = new System.Drawing.Size(53, 97);
            this.floppyDude.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.floppyDude.TabIndex = 0;
            this.floppyDude.TabStop = false;
            // 
            // skyCloud
            // 
            this.skyCloud.Image = ((System.Drawing.Image)(resources.GetObject("skyCloud.Image")));
            this.skyCloud.Location = new System.Drawing.Point(-615, -36);
            this.skyCloud.Name = "skyCloud";
            this.skyCloud.Size = new System.Drawing.Size(2445, 108);
            this.skyCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skyCloud.TabIndex = 1;
            this.skyCloud.TabStop = false;
            // 
            // groundGrass
            // 
            this.groundGrass.Image = ((System.Drawing.Image)(resources.GetObject("groundGrass.Image")));
            this.groundGrass.Location = new System.Drawing.Point(0, 566);
            this.groundGrass.Name = "groundGrass";
            this.groundGrass.Size = new System.Drawing.Size(1171, 65);
            this.groundGrass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundGrass.TabIndex = 5;
            this.groundGrass.TabStop = false;
            // 
            // brick1
            // 
            this.brick1.Image = ((System.Drawing.Image)(resources.GetObject("brick1.Image")));
            this.brick1.Location = new System.Drawing.Point(463, 90);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(32, 113);
            this.brick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick1.TabIndex = 8;
            this.brick1.TabStop = false;
            // 
            // brick2
            // 
            this.brick2.Image = ((System.Drawing.Image)(resources.GetObject("brick2.Image")));
            this.brick2.Location = new System.Drawing.Point(661, 420);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(32, 113);
            this.brick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick2.TabIndex = 9;
            this.brick2.TabStop = false;
            // 
            // brick3
            // 
            this.brick3.Image = ((System.Drawing.Image)(resources.GetObject("brick3.Image")));
            this.brick3.Location = new System.Drawing.Point(863, 231);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(32, 113);
            this.brick3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick3.TabIndex = 10;
            this.brick3.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(13, 13);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(63, 19);
            this.scoreLabel.TabIndex = 11;
            this.scoreLabel.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1171, 629);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.groundGrass);
            this.Controls.Add(this.skyCloud);
            this.Controls.Add(this.floppyDude);
            this.Name = "Form1";
            this.Text = "Floppy Dude";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.floppyDude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundGrass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floppyDude;
        private System.Windows.Forms.PictureBox skyCloud;
        private System.Windows.Forms.PictureBox groundGrass;
        private System.Windows.Forms.PictureBox brick1;
        private System.Windows.Forms.PictureBox brick2;
        private System.Windows.Forms.PictureBox brick3;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}

