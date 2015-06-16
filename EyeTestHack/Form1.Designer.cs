namespace EyeTestHack
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbCapturedImage = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnCaptureAndShow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(43, 32);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(52, 20);
            this.txtX.TabIndex = 0;
            this.txtX.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(121, 32);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(52, 20);
            this.txtY.TabIndex = 1;
            this.txtY.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(267, 32);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(68, 20);
            this.txtWidth.TabIndex = 2;
            this.txtWidth.Text = "1366";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(385, 32);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(68, 20);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Text = "768";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtHeight);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtX);
            this.panel1.Controls.Add(this.txtY);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtWidth);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 58);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Set proper values to clip the exact area of testing.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.pbCapturedImage);
            this.panel2.Location = new System.Drawing.Point(12, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 318);
            this.panel2.TabIndex = 3;
            // 
            // pbCapturedImage
            // 
            this.pbCapturedImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbCapturedImage.InitialImage = null;
            this.pbCapturedImage.Location = new System.Drawing.Point(3, 3);
            this.pbCapturedImage.Name = "pbCapturedImage";
            this.pbCapturedImage.Size = new System.Drawing.Size(475, 312);
            this.pbCapturedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCapturedImage.TabIndex = 0;
            this.pbCapturedImage.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(12, 393);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(139, 23);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnCaptureAndShow
            // 
            this.btnCaptureAndShow.Location = new System.Drawing.Point(354, 393);
            this.btnCaptureAndShow.Name = "btnCaptureAndShow";
            this.btnCaptureAndShow.Size = new System.Drawing.Size(139, 23);
            this.btnCaptureAndShow.TabIndex = 1;
            this.btnCaptureAndShow.Text = "Capture and Show";
            this.btnCaptureAndShow.UseVisualStyleBackColor = true;
            this.btnCaptureAndShow.Click += new System.EventHandler(this.btnCaptureAndShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 431);
            this.Controls.Add(this.btnCaptureAndShow);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(521, 470);
            this.MinimumSize = new System.Drawing.Size(521, 470);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "EyeTestHack";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbCapturedImage;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnCaptureAndShow;
        private System.Windows.Forms.Label label5;
    }
}

