namespace JoyPad
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rMotorSlider = new System.Windows.Forms.TrackBar();
            this.lMotorSlider = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lMotorLabel = new System.Windows.Forms.Label();
            this.rMotorLabel = new System.Windows.Forms.Label();
            this.padPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rMotorSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMotorSlider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.padPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // rMotorSlider
            // 
            this.rMotorSlider.Location = new System.Drawing.Point(6, 19);
            this.rMotorSlider.Maximum = 65535;
            this.rMotorSlider.Name = "rMotorSlider";
            this.rMotorSlider.Size = new System.Drawing.Size(104, 34);
            this.rMotorSlider.TabIndex = 16;
            this.rMotorSlider.TickFrequency = 100;
            this.rMotorSlider.Scroll += new System.EventHandler(this.rMotorSlider_Scroll);
            // 
            // lMotorSlider
            // 
            this.lMotorSlider.Location = new System.Drawing.Point(6, 51);
            this.lMotorSlider.Maximum = 65535;
            this.lMotorSlider.Name = "lMotorSlider";
            this.lMotorSlider.Size = new System.Drawing.Size(104, 34);
            this.lMotorSlider.TabIndex = 16;
            this.lMotorSlider.TickFrequency = 100;
            this.lMotorSlider.Scroll += new System.EventHandler(this.lMotorSlider_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lMotorLabel);
            this.groupBox1.Controls.Add(this.rMotorLabel);
            this.groupBox1.Controls.Add(this.rMotorSlider);
            this.groupBox1.Controls.Add(this.lMotorSlider);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motors";
            // 
            // lMotorLabel
            // 
            this.lMotorLabel.AutoSize = true;
            this.lMotorLabel.Location = new System.Drawing.Point(116, 55);
            this.lMotorLabel.Name = "lMotorLabel";
            this.lMotorLabel.Size = new System.Drawing.Size(33, 13);
            this.lMotorLabel.TabIndex = 18;
            this.lMotorLabel.Text = "L: 0%";
            // 
            // rMotorLabel
            // 
            this.rMotorLabel.AutoSize = true;
            this.rMotorLabel.Location = new System.Drawing.Point(116, 24);
            this.rMotorLabel.Name = "rMotorLabel";
            this.rMotorLabel.Size = new System.Drawing.Size(35, 13);
            this.rMotorLabel.TabIndex = 18;
            this.rMotorLabel.Text = "R: 0%";
            // 
            // padPicture
            // 
            this.padPicture.Image = global::JoyPad.Properties.Resources._360_controller_s;
            this.padPicture.Location = new System.Drawing.Point(218, 12);
            this.padPicture.Name = "padPicture";
            this.padPicture.Size = new System.Drawing.Size(506, 400);
            this.padPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.padPicture.TabIndex = 18;
            this.padPicture.TabStop = false;
            this.padPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.padPicture_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.padPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rMotorSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMotorSlider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.padPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar rMotorSlider;
        private System.Windows.Forms.TrackBar lMotorSlider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lMotorLabel;
        private System.Windows.Forms.Label rMotorLabel;
        private System.Windows.Forms.PictureBox padPicture;
    }
}

