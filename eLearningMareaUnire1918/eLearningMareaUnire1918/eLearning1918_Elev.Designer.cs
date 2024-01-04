namespace eLearningMareaUnire1918
{
    partial class eLearning1918_Elev
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ansButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.itemtypeLabel = new System.Windows.Forms.Label();
            this.paneltype1 = new System.Windows.Forms.Panel();
            this.paneltype2 = new System.Windows.Forms.Panel();
            this.paneltype3 = new System.Windows.Forms.Panel();
            this.paneltype4 = new System.Windows.Forms.Panel();
            this.rBTrue = new System.Windows.Forms.RadioButton();
            this.rBFalse = new System.Windows.Forms.RadioButton();
            this.cB4 = new System.Windows.Forms.CheckBox();
            this.cB3 = new System.Windows.Forms.CheckBox();
            this.cB2 = new System.Windows.Forms.CheckBox();
            this.cB1 = new System.Windows.Forms.CheckBox();
            this.rB4 = new System.Windows.Forms.RadioButton();
            this.rB3 = new System.Windows.Forms.RadioButton();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.type1TB = new System.Windows.Forms.TextBox();
            this.questionBox = new System.Windows.Forms.RichTextBox();
            this.punctajLabel = new System.Windows.Forms.Label();
            this.testStartButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.paneltype1.SuspendLayout();
            this.paneltype2.SuspendLayout();
            this.paneltype3.SuspendLayout();
            this.paneltype4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elev";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabPage4);
            this.tabs.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(3, 38);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(790, 398);
            this.tabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ansButton);
            this.tabPage1.Controls.Add(this.nextButton);
            this.tabPage1.Controls.Add(this.itemtypeLabel);
            this.tabPage1.Controls.Add(this.questionBox);
            this.tabPage1.Controls.Add(this.punctajLabel);
            this.tabPage1.Controls.Add(this.testStartButton);
            this.tabPage1.Controls.Add(this.paneltype1);
            this.tabPage1.Controls.Add(this.paneltype4);
            this.tabPage1.Controls.Add(this.paneltype2);
            this.tabPage1.Controls.Add(this.paneltype3);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teste";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ansButton
            // 
            this.ansButton.Enabled = false;
            this.ansButton.Location = new System.Drawing.Point(319, 315);
            this.ansButton.Name = "ansButton";
            this.ansButton.Size = new System.Drawing.Size(97, 39);
            this.ansButton.TabIndex = 5;
            this.ansButton.Text = "Raspunde";
            this.ansButton.UseVisualStyleBackColor = true;
            this.ansButton.Click += new System.EventHandler(this.ansButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(623, 315);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(97, 39);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Urmatorul";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // itemtypeLabel
            // 
            this.itemtypeLabel.AutoSize = true;
            this.itemtypeLabel.Location = new System.Drawing.Point(25, 45);
            this.itemtypeLabel.Name = "itemtypeLabel";
            this.itemtypeLabel.Size = new System.Drawing.Size(68, 18);
            this.itemtypeLabel.TabIndex = 0;
            this.itemtypeLabel.Text = "Tip item:";
            // 
            // paneltype1
            // 
            this.paneltype1.BackColor = System.Drawing.Color.Silver;
            this.paneltype1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltype1.Controls.Add(this.label3);
            this.paneltype1.Controls.Add(this.type1TB);
            this.paneltype1.Location = new System.Drawing.Point(23, 175);
            this.paneltype1.Name = "paneltype1";
            this.paneltype1.Size = new System.Drawing.Size(732, 132);
            this.paneltype1.TabIndex = 3;
            this.paneltype1.Visible = false;
            // 
            // paneltype2
            // 
            this.paneltype2.BackColor = System.Drawing.Color.Silver;
            this.paneltype2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltype2.Controls.Add(this.rB4);
            this.paneltype2.Controls.Add(this.rB3);
            this.paneltype2.Controls.Add(this.rB2);
            this.paneltype2.Controls.Add(this.rB1);
            this.paneltype2.Location = new System.Drawing.Point(25, 174);
            this.paneltype2.Name = "paneltype2";
            this.paneltype2.Size = new System.Drawing.Size(732, 132);
            this.paneltype2.TabIndex = 4;
            this.paneltype2.Visible = false;
            // 
            // paneltype3
            // 
            this.paneltype3.BackColor = System.Drawing.Color.Silver;
            this.paneltype3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltype3.Controls.Add(this.cB4);
            this.paneltype3.Controls.Add(this.cB3);
            this.paneltype3.Controls.Add(this.cB2);
            this.paneltype3.Controls.Add(this.cB1);
            this.paneltype3.Location = new System.Drawing.Point(23, 175);
            this.paneltype3.Name = "paneltype3";
            this.paneltype3.Size = new System.Drawing.Size(732, 132);
            this.paneltype3.TabIndex = 7;
            // 
            // paneltype4
            // 
            this.paneltype4.BackColor = System.Drawing.Color.Silver;
            this.paneltype4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltype4.Controls.Add(this.rBTrue);
            this.paneltype4.Controls.Add(this.rBFalse);
            this.paneltype4.Location = new System.Drawing.Point(23, 174);
            this.paneltype4.Name = "paneltype4";
            this.paneltype4.Size = new System.Drawing.Size(732, 132);
            this.paneltype4.TabIndex = 8;
            this.paneltype4.Visible = false;
            // 
            // rBTrue
            // 
            this.rBTrue.AutoSize = true;
            this.rBTrue.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTrue.Location = new System.Drawing.Point(32, 32);
            this.rBTrue.Name = "rBTrue";
            this.rBTrue.Size = new System.Drawing.Size(125, 29);
            this.rBTrue.TabIndex = 1;
            this.rBTrue.TabStop = true;
            this.rBTrue.Text = "Adevarat";
            this.rBTrue.UseVisualStyleBackColor = true;
            // 
            // rBFalse
            // 
            this.rBFalse.AutoSize = true;
            this.rBFalse.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBFalse.Location = new System.Drawing.Point(34, 81);
            this.rBFalse.Name = "rBFalse";
            this.rBFalse.Size = new System.Drawing.Size(76, 29);
            this.rBFalse.TabIndex = 0;
            this.rBFalse.TabStop = true;
            this.rBFalse.Text = "Fals";
            this.rBFalse.UseVisualStyleBackColor = true;
            // 
            // cB4
            // 
            this.cB4.AutoSize = true;
            this.cB4.Location = new System.Drawing.Point(24, 95);
            this.cB4.Name = "cB4";
            this.cB4.Size = new System.Drawing.Size(95, 22);
            this.cB4.TabIndex = 3;
            this.cB4.Text = "checkBox4";
            this.cB4.UseVisualStyleBackColor = true;
            // 
            // cB3
            // 
            this.cB3.AutoSize = true;
            this.cB3.Location = new System.Drawing.Point(24, 67);
            this.cB3.Name = "cB3";
            this.cB3.Size = new System.Drawing.Size(95, 22);
            this.cB3.TabIndex = 2;
            this.cB3.Text = "checkBox3";
            this.cB3.UseVisualStyleBackColor = true;
            // 
            // cB2
            // 
            this.cB2.AutoSize = true;
            this.cB2.Location = new System.Drawing.Point(24, 40);
            this.cB2.Name = "cB2";
            this.cB2.Size = new System.Drawing.Size(95, 22);
            this.cB2.TabIndex = 1;
            this.cB2.Text = "checkBox2";
            this.cB2.UseVisualStyleBackColor = true;
            // 
            // cB1
            // 
            this.cB1.AutoSize = true;
            this.cB1.Location = new System.Drawing.Point(24, 12);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(95, 22);
            this.cB1.TabIndex = 0;
            this.cB1.Text = "checkBox1";
            this.cB1.UseVisualStyleBackColor = true;
            // 
            // rB4
            // 
            this.rB4.AutoSize = true;
            this.rB4.Location = new System.Drawing.Point(24, 95);
            this.rB4.Name = "rB4";
            this.rB4.Size = new System.Drawing.Size(111, 22);
            this.rB4.TabIndex = 6;
            this.rB4.TabStop = true;
            this.rB4.Text = "radioButton4";
            this.rB4.UseVisualStyleBackColor = true;
            // 
            // rB3
            // 
            this.rB3.AutoSize = true;
            this.rB3.Location = new System.Drawing.Point(24, 67);
            this.rB3.Name = "rB3";
            this.rB3.Size = new System.Drawing.Size(111, 22);
            this.rB3.TabIndex = 5;
            this.rB3.TabStop = true;
            this.rB3.Text = "radioButton3";
            this.rB3.UseVisualStyleBackColor = true;
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(24, 39);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(111, 22);
            this.rB2.TabIndex = 4;
            this.rB2.TabStop = true;
            this.rB2.Text = "radioButton2";
            this.rB2.UseVisualStyleBackColor = true;
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Location = new System.Drawing.Point(24, 11);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(111, 22);
            this.rB1.TabIndex = 3;
            this.rB1.TabStop = true;
            this.rB1.Text = "radioButton1";
            this.rB1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Raspuns:";
            // 
            // type1TB
            // 
            this.type1TB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type1TB.Location = new System.Drawing.Point(166, 45);
            this.type1TB.Name = "type1TB";
            this.type1TB.Size = new System.Drawing.Size(512, 33);
            this.type1TB.TabIndex = 1;
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(23, 65);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(733, 96);
            this.questionBox.TabIndex = 2;
            this.questionBox.Text = "";
            // 
            // punctajLabel
            // 
            this.punctajLabel.AutoSize = true;
            this.punctajLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punctajLabel.Location = new System.Drawing.Point(19, 14);
            this.punctajLabel.Name = "punctajLabel";
            this.punctajLabel.Size = new System.Drawing.Size(98, 24);
            this.punctajLabel.TabIndex = 1;
            this.punctajLabel.Text = "Punctaj: 1";
            // 
            // testStartButton
            // 
            this.testStartButton.BackColor = System.Drawing.Color.RosyBrown;
            this.testStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.testStartButton.Location = new System.Drawing.Point(659, 14);
            this.testStartButton.Name = "testStartButton";
            this.testStartButton.Size = new System.Drawing.Size(96, 41);
            this.testStartButton.TabIndex = 0;
            this.testStartButton.Text = "Start test";
            this.testStartButton.UseVisualStyleBackColor = false;
            this.testStartButton.Click += new System.EventHandler(this.testStartButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Carnet de note";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(782, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grafic note";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(782, 367);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Iesire";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 449);
            this.panel1.TabIndex = 2;
            // 
            // eLearning1918_Elev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "eLearning1918_Elev";
            this.Text = "eLearning1918_Elev";
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.paneltype1.ResumeLayout(false);
            this.paneltype1.PerformLayout();
            this.paneltype2.ResumeLayout(false);
            this.paneltype2.PerformLayout();
            this.paneltype3.ResumeLayout(false);
            this.paneltype3.PerformLayout();
            this.paneltype4.ResumeLayout(false);
            this.paneltype4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox questionBox;
        private System.Windows.Forms.Label punctajLabel;
        private System.Windows.Forms.Button testStartButton;
        private System.Windows.Forms.Panel paneltype1;
        private System.Windows.Forms.Button ansButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox type1TB;
        private System.Windows.Forms.Label itemtypeLabel;
        private System.Windows.Forms.Panel paneltype2;
        private System.Windows.Forms.RadioButton rB4;
        private System.Windows.Forms.RadioButton rB3;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.Panel paneltype3;
        private System.Windows.Forms.Panel paneltype4;
        private System.Windows.Forms.RadioButton rBTrue;
        private System.Windows.Forms.RadioButton rBFalse;
        private System.Windows.Forms.CheckBox cB4;
        private System.Windows.Forms.CheckBox cB3;
        private System.Windows.Forms.CheckBox cB2;
        private System.Windows.Forms.CheckBox cB1;
    }
}