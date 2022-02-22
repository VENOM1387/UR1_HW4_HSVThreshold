
namespace HSV_Detection
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
            this.sourceImage = new System.Windows.Forms.PictureBox();
            this.hPictureBox = new System.Windows.Forms.PictureBox();
            this.sPictureBox = new System.Windows.Forms.PictureBox();
            this.vPictureBox = new System.Windows.Forms.PictureBox();
            this.yellowLine = new System.Windows.Forms.PictureBox();
            this.redLine = new System.Windows.Forms.PictureBox();
            this.hUpperBar = new System.Windows.Forms.TrackBar();
            this.hLowerBar = new System.Windows.Forms.TrackBar();
            this.sUpperBar = new System.Windows.Forms.TrackBar();
            this.sLowerBar = new System.Windows.Forms.TrackBar();
            this.vUpperBar = new System.Windows.Forms.TrackBar();
            this.vLowerBar = new System.Windows.Forms.TrackBar();
            this.yellowPixels = new System.Windows.Forms.Label();
            this.redPixels = new System.Windows.Forms.Label();
            this.binaryPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.thresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.custom = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hMn = new System.Windows.Forms.Label();
            this.hMx = new System.Windows.Forms.Label();
            this.sMn = new System.Windows.Forms.Label();
            this.sMx = new System.Windows.Forms.Label();
            this.vMn = new System.Windows.Forms.Label();
            this.vMx = new System.Windows.Forms.Label();
            this.customPixels = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUpperBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hLowerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUpperBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLowerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUpperBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLowerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custom)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceImage
            // 
            this.sourceImage.Location = new System.Drawing.Point(12, 12);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(298, 239);
            this.sourceImage.TabIndex = 0;
            this.sourceImage.TabStop = false;
            // 
            // hPictureBox
            // 
            this.hPictureBox.Location = new System.Drawing.Point(398, 12);
            this.hPictureBox.Name = "hPictureBox";
            this.hPictureBox.Size = new System.Drawing.Size(298, 239);
            this.hPictureBox.TabIndex = 1;
            this.hPictureBox.TabStop = false;
            // 
            // sPictureBox
            // 
            this.sPictureBox.Location = new System.Drawing.Point(750, 12);
            this.sPictureBox.Name = "sPictureBox";
            this.sPictureBox.Size = new System.Drawing.Size(298, 239);
            this.sPictureBox.TabIndex = 2;
            this.sPictureBox.TabStop = false;
            // 
            // vPictureBox
            // 
            this.vPictureBox.Location = new System.Drawing.Point(1103, 12);
            this.vPictureBox.Name = "vPictureBox";
            this.vPictureBox.Size = new System.Drawing.Size(298, 239);
            this.vPictureBox.TabIndex = 3;
            this.vPictureBox.TabStop = false;
            // 
            // yellowLine
            // 
            this.yellowLine.Location = new System.Drawing.Point(750, 434);
            this.yellowLine.Name = "yellowLine";
            this.yellowLine.Size = new System.Drawing.Size(298, 239);
            this.yellowLine.TabIndex = 4;
            this.yellowLine.TabStop = false;
            // 
            // redLine
            // 
            this.redLine.Location = new System.Drawing.Point(1116, 434);
            this.redLine.Name = "redLine";
            this.redLine.Size = new System.Drawing.Size(298, 239);
            this.redLine.TabIndex = 5;
            this.redLine.TabStop = false;
            // 
            // hUpperBar
            // 
            this.hUpperBar.Location = new System.Drawing.Point(411, 279);
            this.hUpperBar.Maximum = 255;
            this.hUpperBar.Name = "hUpperBar";
            this.hUpperBar.Size = new System.Drawing.Size(285, 56);
            this.hUpperBar.TabIndex = 6;
            this.hUpperBar.Scroll += new System.EventHandler(this.hUpperBar_Scroll);
            // 
            // hLowerBar
            // 
            this.hLowerBar.Location = new System.Drawing.Point(411, 341);
            this.hLowerBar.Maximum = 179;
            this.hLowerBar.Name = "hLowerBar";
            this.hLowerBar.Size = new System.Drawing.Size(285, 56);
            this.hLowerBar.TabIndex = 7;
            this.hLowerBar.Scroll += new System.EventHandler(this.hLowerBar_Scroll);
            // 
            // sUpperBar
            // 
            this.sUpperBar.Location = new System.Drawing.Point(763, 279);
            this.sUpperBar.Maximum = 255;
            this.sUpperBar.Name = "sUpperBar";
            this.sUpperBar.Size = new System.Drawing.Size(285, 56);
            this.sUpperBar.TabIndex = 8;
            this.sUpperBar.Scroll += new System.EventHandler(this.sUpperBar_Scroll);
            // 
            // sLowerBar
            // 
            this.sLowerBar.Location = new System.Drawing.Point(763, 341);
            this.sLowerBar.Maximum = 255;
            this.sLowerBar.Name = "sLowerBar";
            this.sLowerBar.Size = new System.Drawing.Size(285, 56);
            this.sLowerBar.TabIndex = 9;
            this.sLowerBar.Scroll += new System.EventHandler(this.sLowerBar_Scroll);
            // 
            // vUpperBar
            // 
            this.vUpperBar.Location = new System.Drawing.Point(1116, 279);
            this.vUpperBar.Maximum = 255;
            this.vUpperBar.Name = "vUpperBar";
            this.vUpperBar.Size = new System.Drawing.Size(285, 56);
            this.vUpperBar.TabIndex = 10;
            this.vUpperBar.Scroll += new System.EventHandler(this.vUpperBar_Scroll);
            // 
            // vLowerBar
            // 
            this.vLowerBar.Location = new System.Drawing.Point(1116, 341);
            this.vLowerBar.Maximum = 255;
            this.vLowerBar.Name = "vLowerBar";
            this.vLowerBar.Size = new System.Drawing.Size(285, 56);
            this.vLowerBar.TabIndex = 11;
            this.vLowerBar.Scroll += new System.EventHandler(this.vLowerBar_Scroll);
            // 
            // yellowPixels
            // 
            this.yellowPixels.AutoSize = true;
            this.yellowPixels.Location = new System.Drawing.Point(750, 697);
            this.yellowPixels.Name = "yellowPixels";
            this.yellowPixels.Size = new System.Drawing.Size(48, 17);
            this.yellowPixels.TabIndex = 12;
            this.yellowPixels.Text = "Yellow";
            // 
            // redPixels
            // 
            this.redPixels.AutoSize = true;
            this.redPixels.Location = new System.Drawing.Point(1113, 697);
            this.redPixels.Name = "redPixels";
            this.redPixels.Size = new System.Drawing.Size(34, 17);
            this.redPixels.TabIndex = 13;
            this.redPixels.Text = "Red";
            // 
            // binaryPictureBox
            // 
            this.binaryPictureBox.Location = new System.Drawing.Point(15, 279);
            this.binaryPictureBox.Name = "binaryPictureBox";
            this.binaryPictureBox.Size = new System.Drawing.Size(298, 239);
            this.binaryPictureBox.TabIndex = 14;
            this.binaryPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Raw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Binary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "H";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(750, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1103, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(750, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Yellow";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1113, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Red";
            // 
            // thresholdTrackBar
            // 
            this.thresholdTrackBar.Location = new System.Drawing.Point(18, 538);
            this.thresholdTrackBar.Maximum = 255;
            this.thresholdTrackBar.Name = "thresholdTrackBar";
            this.thresholdTrackBar.Size = new System.Drawing.Size(295, 56);
            this.thresholdTrackBar.TabIndex = 22;
            this.thresholdTrackBar.Scroll += new System.EventHandler(this.thresholdTrackBar_Scroll);
            // 
            // custom
            // 
            this.custom.Location = new System.Drawing.Point(398, 434);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(298, 239);
            this.custom.TabIndex = 23;
            this.custom.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Custom";
            // 
            // hMn
            // 
            this.hMn.AutoSize = true;
            this.hMn.Location = new System.Drawing.Point(359, 279);
            this.hMn.Name = "hMn";
            this.hMn.Size = new System.Drawing.Size(38, 17);
            this.hMn.TabIndex = 25;
            this.hMn.Text = "hMin";
            // 
            // hMx
            // 
            this.hMx.AutoSize = true;
            this.hMx.Location = new System.Drawing.Point(351, 341);
            this.hMx.Name = "hMx";
            this.hMx.Size = new System.Drawing.Size(41, 17);
            this.hMx.TabIndex = 26;
            this.hMx.Text = "hMax";
            // 
            // sMn
            // 
            this.sMn.AutoSize = true;
            this.sMn.Location = new System.Drawing.Point(713, 288);
            this.sMn.Name = "sMn";
            this.sMn.Size = new System.Drawing.Size(37, 17);
            this.sMn.TabIndex = 27;
            this.sMn.Text = "sMin";
            // 
            // sMx
            // 
            this.sMx.AutoSize = true;
            this.sMx.Location = new System.Drawing.Point(713, 352);
            this.sMx.Name = "sMx";
            this.sMx.Size = new System.Drawing.Size(40, 17);
            this.sMx.TabIndex = 28;
            this.sMx.Text = "sMax";
            // 
            // vMn
            // 
            this.vMn.AutoSize = true;
            this.vMn.Location = new System.Drawing.Point(1066, 288);
            this.vMn.Name = "vMn";
            this.vMn.Size = new System.Drawing.Size(37, 17);
            this.vMn.TabIndex = 29;
            this.vMn.Text = "vMin";
            // 
            // vMx
            // 
            this.vMx.AutoSize = true;
            this.vMx.Location = new System.Drawing.Point(1066, 341);
            this.vMx.Name = "vMx";
            this.vMx.Size = new System.Drawing.Size(40, 17);
            this.vMx.TabIndex = 30;
            this.vMx.Text = "vMax";
            // 
            // customPixels
            // 
            this.customPixels.AutoSize = true;
            this.customPixels.Location = new System.Drawing.Point(395, 697);
            this.customPixels.Name = "customPixels";
            this.customPixels.Size = new System.Drawing.Size(55, 17);
            this.customPixels.TabIndex = 31;
            this.customPixels.Text = "Custom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 763);
            this.Controls.Add(this.customPixels);
            this.Controls.Add(this.vMx);
            this.Controls.Add(this.vMn);
            this.Controls.Add(this.sMx);
            this.Controls.Add(this.sMn);
            this.Controls.Add(this.hMx);
            this.Controls.Add(this.hMn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.thresholdTrackBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.binaryPictureBox);
            this.Controls.Add(this.redPixels);
            this.Controls.Add(this.yellowPixels);
            this.Controls.Add(this.vLowerBar);
            this.Controls.Add(this.vUpperBar);
            this.Controls.Add(this.sLowerBar);
            this.Controls.Add(this.sUpperBar);
            this.Controls.Add(this.hLowerBar);
            this.Controls.Add(this.hUpperBar);
            this.Controls.Add(this.redLine);
            this.Controls.Add(this.yellowLine);
            this.Controls.Add(this.vPictureBox);
            this.Controls.Add(this.sPictureBox);
            this.Controls.Add(this.hPictureBox);
            this.Controls.Add(this.sourceImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUpperBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hLowerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUpperBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLowerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUpperBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLowerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourceImage;
        private System.Windows.Forms.PictureBox hPictureBox;
        private System.Windows.Forms.PictureBox sPictureBox;
        private System.Windows.Forms.PictureBox vPictureBox;
        private System.Windows.Forms.PictureBox yellowLine;
        private System.Windows.Forms.PictureBox redLine;
        private System.Windows.Forms.TrackBar hUpperBar;
        private System.Windows.Forms.TrackBar hLowerBar;
        private System.Windows.Forms.TrackBar sUpperBar;
        private System.Windows.Forms.TrackBar sLowerBar;
        private System.Windows.Forms.TrackBar vUpperBar;
        private System.Windows.Forms.TrackBar vLowerBar;
        private System.Windows.Forms.Label yellowPixels;
        private System.Windows.Forms.Label redPixels;
        private System.Windows.Forms.PictureBox binaryPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar thresholdTrackBar;
        private System.Windows.Forms.PictureBox custom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label hMn;
        private System.Windows.Forms.Label hMx;
        private System.Windows.Forms.Label sMn;
        private System.Windows.Forms.Label sMx;
        private System.Windows.Forms.Label vMn;
        private System.Windows.Forms.Label vMx;
        private System.Windows.Forms.Label customPixels;
    }
}

