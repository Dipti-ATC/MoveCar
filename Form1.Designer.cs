
namespace MoveCar
{
    partial class MoveCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveCar));
            this.pbxRaceTrack = new System.Windows.Forms.PictureBox();
            this.pbxCar1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRaceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxRaceTrack
            // 
            this.pbxRaceTrack.Image = ((System.Drawing.Image)(resources.GetObject("pbxRaceTrack.Image")));
            this.pbxRaceTrack.Location = new System.Drawing.Point(1, 12);
            this.pbxRaceTrack.Name = "pbxRaceTrack";
            this.pbxRaceTrack.Size = new System.Drawing.Size(626, 190);
            this.pbxRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRaceTrack.TabIndex = 0;
            this.pbxRaceTrack.TabStop = false;
            // 
            // pbxCar1
            // 
            this.pbxCar1.BackColor = System.Drawing.Color.Red;
            this.pbxCar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCar1.Image = ((System.Drawing.Image)(resources.GetObject("pbxCar1.Image")));
            this.pbxCar1.Location = new System.Drawing.Point(1, 12);
            this.pbxCar1.Name = "pbxCar1";
            this.pbxCar1.Size = new System.Drawing.Size(79, 66);
            this.pbxCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCar1.TabIndex = 1;
            this.pbxCar1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.Location = new System.Drawing.Point(242, 243);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 47);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MoveCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 354);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbxCar1);
            this.Controls.Add(this.pbxRaceTrack);
            this.Name = "MoveCar";
            this.Text = "Move Car";
            ((System.ComponentModel.ISupportInitialize)(this.pbxRaceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxRaceTrack;
        private System.Windows.Forms.PictureBox pbxCar1;
        private System.Windows.Forms.Button btnStart;
    }
}

