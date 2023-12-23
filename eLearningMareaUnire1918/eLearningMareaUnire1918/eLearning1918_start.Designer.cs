
namespace eLearningMareaUnire1918
{
    partial class eLearning1918_start
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.auto_manualButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platforma eLearning dedicata Marii Uniri de la 1918";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(615, 487);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 64);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Aceasta platforma eLearnig este dedicata Marii Uniri de la 1918.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.auto_manualButton);
            this.groupBox1.Controls.Add(this.previousButton);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 430);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SlideShow";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 347);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(463, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 3;
            // 
            // auto_manualButton
            // 
            this.auto_manualButton.Location = new System.Drawing.Point(168, 386);
            this.auto_manualButton.Name = "auto_manualButton";
            this.auto_manualButton.Size = new System.Drawing.Size(146, 38);
            this.auto_manualButton.TabIndex = 6;
            this.auto_manualButton.Text = "Auto";
            this.auto_manualButton.UseVisualStyleBackColor = true;
            this.auto_manualButton.Click += new System.EventHandler(this.auto_manualButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Enabled = false;
            this.previousButton.Location = new System.Drawing.Point(6, 386);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(124, 38);
            this.previousButton.TabIndex = 5;
            this.previousButton.Text = "Inapoi";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(345, 386);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(124, 38);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Inainte";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eLearningMareaUnire1918.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // eLearning1918_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "eLearning1918_start";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.eLearning1918_start_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button auto_manualButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Timer timer;
    }
}

