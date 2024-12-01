namespace MyTime
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Array2_1 = new Button();
            Array3_1 = new Button();
            Array2_2 = new Button();
            Array2_3 = new Button();
            Array3_2 = new Button();
            Array3_3 = new Button();
            Start = new Button();
            checkBot = new CheckBox();
            groupBox1 = new GroupBox();
            radioEasy = new RadioButton();
            radioHard = new RadioButton();
            Array1_3 = new Button();
            Array1_2 = new Button();
            Array1_1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Array2_1
            // 
            Array2_1.Enabled = false;
            Array2_1.Location = new Point(12, 183);
            Array2_1.Name = "Array2_1";
            Array2_1.Size = new Size(138, 122);
            Array2_1.TabIndex = 1;
            Array2_1.Tag = "GameButton";
            Array2_1.UseVisualStyleBackColor = true;
            Array2_1.Click += Button_Click;
            // 
            // Array3_1
            // 
            Array3_1.Enabled = false;
            Array3_1.Location = new Point(12, 311);
            Array3_1.Name = "Array3_1";
            Array3_1.Size = new Size(138, 122);
            Array3_1.TabIndex = 2;
            Array3_1.Tag = "GameButton";
            Array3_1.UseVisualStyleBackColor = true;
            Array3_1.Click += Button_Click;
            // 
            // Array2_2
            // 
            Array2_2.Enabled = false;
            Array2_2.Location = new Point(156, 183);
            Array2_2.Name = "Array2_2";
            Array2_2.Size = new Size(138, 122);
            Array2_2.TabIndex = 5;
            Array2_2.Tag = "GameButton";
            Array2_2.UseVisualStyleBackColor = true;
            Array2_2.Click += Button_Click;
            // 
            // Array2_3
            // 
            Array2_3.Enabled = false;
            Array2_3.Location = new Point(300, 183);
            Array2_3.Name = "Array2_3";
            Array2_3.Size = new Size(138, 122);
            Array2_3.TabIndex = 6;
            Array2_3.Tag = "GameButton";
            Array2_3.UseVisualStyleBackColor = true;
            Array2_3.Click += Button_Click;
            // 
            // Array3_2
            // 
            Array3_2.Enabled = false;
            Array3_2.Location = new Point(156, 311);
            Array3_2.Name = "Array3_2";
            Array3_2.Size = new Size(138, 122);
            Array3_2.TabIndex = 7;
            Array3_2.Tag = "GameButton";
            Array3_2.UseVisualStyleBackColor = true;
            Array3_2.Click += Button_Click;
            // 
            // Array3_3
            // 
            Array3_3.Enabled = false;
            Array3_3.Location = new Point(300, 311);
            Array3_3.Name = "Array3_3";
            Array3_3.Size = new Size(138, 122);
            Array3_3.TabIndex = 8;
            Array3_3.Tag = "GameButton";
            Array3_3.UseVisualStyleBackColor = true;
            Array3_3.Click += Button_Click;
            // 
            // Start
            // 
            Start.Location = new Point(465, 55);
            Start.Name = "Start";
            Start.Size = new Size(202, 57);
            Start.TabIndex = 9;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // checkBot
            // 
            checkBot.AutoSize = true;
            checkBot.Location = new Point(465, 129);
            checkBot.Name = "checkBot";
            checkBot.Size = new Size(69, 19);
            checkBot.TabIndex = 10;
            checkBot.Text = "First Bot";
            checkBot.UseVisualStyleBackColor = true;
            checkBot.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioEasy);
            groupBox1.Controls.Add(radioHard);
            groupBox1.Location = new Point(465, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Difficulty level";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioEasy
            // 
            radioEasy.AutoSize = true;
            radioEasy.Location = new Point(15, 43);
            radioEasy.Name = "radioEasy";
            radioEasy.Size = new Size(48, 19);
            radioEasy.TabIndex = 12;
            radioEasy.TabStop = true;
            radioEasy.Text = "Easy";
            radioEasy.UseVisualStyleBackColor = true;
            radioEasy.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioHard
            // 
            radioHard.AutoSize = true;
            radioHard.Location = new Point(15, 68);
            radioHard.Name = "radioHard";
            radioHard.Size = new Size(51, 19);
            radioHard.TabIndex = 13;
            radioHard.TabStop = true;
            radioHard.Text = "Hard";
            radioHard.UseVisualStyleBackColor = true;
            radioHard.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Array1_3
            // 
            Array1_3.Enabled = false;
            Array1_3.Location = new Point(300, 55);
            Array1_3.Name = "Array1_3";
            Array1_3.Size = new Size(138, 122);
            Array1_3.TabIndex = 14;
            Array1_3.Tag = "GameButton";
            Array1_3.UseVisualStyleBackColor = true;
            Array1_3.Click += Button_Click;
            // 
            // Array1_2
            // 
            Array1_2.Enabled = false;
            Array1_2.Location = new Point(156, 55);
            Array1_2.Name = "Array1_2";
            Array1_2.Size = new Size(138, 122);
            Array1_2.TabIndex = 13;
            Array1_2.Tag = "GameButton";
            Array1_2.UseVisualStyleBackColor = true;
            Array1_2.Click += Button_Click;
            // 
            // Array1_1
            // 
            Array1_1.Enabled = false;
            Array1_1.Location = new Point(12, 55);
            Array1_1.Name = "Array1_1";
            Array1_1.Size = new Size(138, 122);
            Array1_1.TabIndex = 12;
            Array1_1.Tag = "GameButton";
            Array1_1.UseVisualStyleBackColor = true;
            Array1_1.Click += Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 463);
            Controls.Add(Array1_3);
            Controls.Add(Array1_2);
            Controls.Add(Array1_1);
            Controls.Add(groupBox1);
            Controls.Add(checkBot);
            Controls.Add(Start);
            Controls.Add(Array3_3);
            Controls.Add(Array3_2);
            Controls.Add(Array2_3);
            Controls.Add(Array2_2);
            Controls.Add(Array3_1);
            Controls.Add(Array2_1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Array2_1;
        private Button Array3_1;
        private Button Array2_2;
        private Button Array2_3;
        private Button Array3_2;
        private Button Array3_3;
        private CheckBox checkBot;
        private GroupBox groupBox1;
        private RadioButton radioEasy;
        private RadioButton radioHard;
        private Button Array1_3;
        private Button Array1_2;
        private Button Array1_1;
        private Button Start;
    }
}
