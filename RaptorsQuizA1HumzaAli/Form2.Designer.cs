namespace RaptorsQuizA1HumzaAli
{
    partial class Form2
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
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.txtBoxQuestion = new System.Windows.Forms.TextBox();
            this.btn5050 = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.txtBoxPlayer = new System.Windows.Forms.TextBox();
            this.txtBoxPoints = new System.Windows.Forms.TextBox();
            this.lblQuestionsPoints = new System.Windows.Forms.Label();
            this.lblQ7 = new System.Windows.Forms.Label();
            this.lblQ5 = new System.Windows.Forms.Label();
            this.lblQ6 = new System.Windows.Forms.Label();
            this.lblQ4 = new System.Windows.Forms.Label();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBoxTimer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.Black;
            this.btnOption1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOption1.ForeColor = System.Drawing.Color.White;
            this.btnOption1.Location = new System.Drawing.Point(40, 12);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(250, 82);
            this.btnOption1.TabIndex = 0;
            this.btnOption1.Tag = "1";
            this.btnOption1.Text = "button1";
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.Black;
            this.btnOption2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOption2.ForeColor = System.Drawing.Color.White;
            this.btnOption2.Location = new System.Drawing.Point(40, 356);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(250, 82);
            this.btnOption2.TabIndex = 1;
            this.btnOption2.Tag = "2";
            this.btnOption2.Text = "button2";
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // btnOption3
            // 
            this.btnOption3.BackColor = System.Drawing.Color.Black;
            this.btnOption3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOption3.ForeColor = System.Drawing.Color.White;
            this.btnOption3.Location = new System.Drawing.Point(296, 12);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(250, 82);
            this.btnOption3.TabIndex = 2;
            this.btnOption3.Tag = "3";
            this.btnOption3.Text = "button3";
            this.btnOption3.UseVisualStyleBackColor = false;
            this.btnOption3.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // btnOption4
            // 
            this.btnOption4.BackColor = System.Drawing.Color.Black;
            this.btnOption4.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOption4.ForeColor = System.Drawing.Color.White;
            this.btnOption4.Location = new System.Drawing.Point(296, 356);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(250, 82);
            this.btnOption4.TabIndex = 3;
            this.btnOption4.Tag = "4";
            this.btnOption4.Text = "button4";
            this.btnOption4.UseVisualStyleBackColor = false;
            this.btnOption4.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // txtBoxQuestion
            // 
            this.txtBoxQuestion.BackColor = System.Drawing.Color.Black;
            this.txtBoxQuestion.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxQuestion.ForeColor = System.Drawing.Color.White;
            this.txtBoxQuestion.Location = new System.Drawing.Point(40, 100);
            this.txtBoxQuestion.Multiline = true;
            this.txtBoxQuestion.Name = "txtBoxQuestion";
            this.txtBoxQuestion.ReadOnly = true;
            this.txtBoxQuestion.Size = new System.Drawing.Size(506, 48);
            this.txtBoxQuestion.TabIndex = 4;
            this.txtBoxQuestion.Text = "Question Placeholder";
            this.txtBoxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn5050
            // 
            this.btn5050.BackColor = System.Drawing.Color.Black;
            this.btn5050.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5050.ForeColor = System.Drawing.Color.White;
            this.btn5050.Location = new System.Drawing.Point(40, 311);
            this.btn5050.Name = "btn5050";
            this.btn5050.Size = new System.Drawing.Size(250, 39);
            this.btn5050.TabIndex = 5;
            this.btn5050.Tag = "5";
            this.btn5050.Text = "50:50";
            this.btn5050.UseVisualStyleBackColor = false;
            this.btn5050.Click += new System.EventHandler(this.btn5050_Click);
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.Black;
            this.btnHint.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHint.ForeColor = System.Drawing.Color.White;
            this.btnHint.Location = new System.Drawing.Point(296, 311);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(250, 39);
            this.btnHint.TabIndex = 6;
            this.btnHint.Tag = "6";
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // txtBoxPlayer
            // 
            this.txtBoxPlayer.BackColor = System.Drawing.Color.Black;
            this.txtBoxPlayer.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPlayer.ForeColor = System.Drawing.Color.White;
            this.txtBoxPlayer.Location = new System.Drawing.Point(552, 12);
            this.txtBoxPlayer.Name = "txtBoxPlayer";
            this.txtBoxPlayer.ReadOnly = true;
            this.txtBoxPlayer.Size = new System.Drawing.Size(236, 32);
            this.txtBoxPlayer.TabIndex = 7;
            this.txtBoxPlayer.Text = "Player Placeholder";
            this.txtBoxPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxPoints
            // 
            this.txtBoxPoints.BackColor = System.Drawing.Color.Black;
            this.txtBoxPoints.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPoints.ForeColor = System.Drawing.Color.White;
            this.txtBoxPoints.Location = new System.Drawing.Point(552, 50);
            this.txtBoxPoints.Name = "txtBoxPoints";
            this.txtBoxPoints.ReadOnly = true;
            this.txtBoxPoints.Size = new System.Drawing.Size(236, 32);
            this.txtBoxPoints.TabIndex = 8;
            this.txtBoxPoints.Text = "Points PlaceHolder";
            this.txtBoxPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuestionsPoints
            // 
            this.lblQuestionsPoints.AutoSize = true;
            this.lblQuestionsPoints.BackColor = System.Drawing.Color.Black;
            this.lblQuestionsPoints.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuestionsPoints.ForeColor = System.Drawing.Color.White;
            this.lblQuestionsPoints.Location = new System.Drawing.Point(588, 97);
            this.lblQuestionsPoints.Name = "lblQuestionsPoints";
            this.lblQuestionsPoints.Size = new System.Drawing.Size(157, 35);
            this.lblQuestionsPoints.TabIndex = 9;
            this.lblQuestionsPoints.Text = "Q# POINTS";
            this.lblQuestionsPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQ7
            // 
            this.lblQ7.AutoSize = true;
            this.lblQ7.BackColor = System.Drawing.Color.Black;
            this.lblQ7.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ7.ForeColor = System.Drawing.Color.White;
            this.lblQ7.Location = new System.Drawing.Point(588, 132);
            this.lblQ7.Name = "lblQ7";
            this.lblQ7.Padding = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblQ7.Size = new System.Drawing.Size(157, 35);
            this.lblQ7.TabIndex = 10;
            this.lblQ7.Text = "Q7 1000";
            this.lblQ7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQ5
            // 
            this.lblQ5.AutoSize = true;
            this.lblQ5.BackColor = System.Drawing.Color.Black;
            this.lblQ5.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ5.ForeColor = System.Drawing.Color.White;
            this.lblQ5.Location = new System.Drawing.Point(588, 202);
            this.lblQ5.Name = "lblQ5";
            this.lblQ5.Padding = new System.Windows.Forms.Padding(19, 0, 35, 0);
            this.lblQ5.Size = new System.Drawing.Size(157, 35);
            this.lblQ5.TabIndex = 11;
            this.lblQ5.Text = "Q5 500";
            this.lblQ5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQ6
            // 
            this.lblQ6.AutoSize = true;
            this.lblQ6.BackColor = System.Drawing.Color.Black;
            this.lblQ6.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ6.ForeColor = System.Drawing.Color.White;
            this.lblQ6.Location = new System.Drawing.Point(588, 167);
            this.lblQ6.Name = "lblQ6";
            this.lblQ6.Padding = new System.Windows.Forms.Padding(19, 0, 36, 0);
            this.lblQ6.Size = new System.Drawing.Size(157, 35);
            this.lblQ6.TabIndex = 12;
            this.lblQ6.Text = "Q6 750";
            this.lblQ6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQ4
            // 
            this.lblQ4.AutoSize = true;
            this.lblQ4.BackColor = System.Drawing.Color.Black;
            this.lblQ4.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ4.ForeColor = System.Drawing.Color.White;
            this.lblQ4.Location = new System.Drawing.Point(588, 237);
            this.lblQ4.Name = "lblQ4";
            this.lblQ4.Padding = new System.Windows.Forms.Padding(19, 0, 37, 0);
            this.lblQ4.Size = new System.Drawing.Size(157, 35);
            this.lblQ4.TabIndex = 13;
            this.lblQ4.Text = "Q4 250";
            this.lblQ4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQ3
            // 
            this.lblQ3.AutoSize = true;
            this.lblQ3.BackColor = System.Drawing.Color.Black;
            this.lblQ3.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ3.ForeColor = System.Drawing.Color.White;
            this.lblQ3.Location = new System.Drawing.Point(588, 272);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Padding = new System.Windows.Forms.Padding(19, 0, 44, 0);
            this.lblQ3.Size = new System.Drawing.Size(157, 35);
            this.lblQ3.TabIndex = 14;
            this.lblQ3.Text = "Q3 125";
            this.lblQ3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.BackColor = System.Drawing.Color.Black;
            this.lblQ2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ2.ForeColor = System.Drawing.Color.White;
            this.lblQ2.Location = new System.Drawing.Point(588, 307);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Padding = new System.Windows.Forms.Padding(19, 0, 38, 0);
            this.lblQ2.Size = new System.Drawing.Size(157, 35);
            this.lblQ2.TabIndex = 15;
            this.lblQ2.Text = "Q2 100";
            this.lblQ2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.BackColor = System.Drawing.Color.Black;
            this.lblQ1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ1.ForeColor = System.Drawing.Color.White;
            this.lblQ1.Location = new System.Drawing.Point(588, 342);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Padding = new System.Windows.Forms.Padding(19, 0, 54, 0);
            this.lblQ1.Size = new System.Drawing.Size(157, 35);
            this.lblQ1.TabIndex = 16;
            this.lblQ1.Text = "Q1 50";
            this.lblQ1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtBoxTimer
            // 
            this.txtBoxTimer.BackColor = System.Drawing.Color.Black;
            this.txtBoxTimer.Font = new System.Drawing.Font("Showcard Gothic", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTimer.ForeColor = System.Drawing.Color.White;
            this.txtBoxTimer.Location = new System.Drawing.Point(40, 158);
            this.txtBoxTimer.Name = "txtBoxTimer";
            this.txtBoxTimer.ReadOnly = true;
            this.txtBoxTimer.Size = new System.Drawing.Size(506, 142);
            this.txtBoxTimer.TabIndex = 17;
            this.txtBoxTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxTimer.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxTimer);
            this.Controls.Add(this.lblQ1);
            this.Controls.Add(this.lblQ2);
            this.Controls.Add(this.lblQ3);
            this.Controls.Add(this.lblQ4);
            this.Controls.Add(this.lblQ6);
            this.Controls.Add(this.lblQ5);
            this.Controls.Add(this.lblQ7);
            this.Controls.Add(this.lblQuestionsPoints);
            this.Controls.Add(this.txtBoxPoints);
            this.Controls.Add(this.txtBoxPlayer);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btn5050);
            this.Controls.Add(this.txtBoxQuestion);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.Name = "Form2";
            this.Text = "Toronto Raptors Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOption1;
        private Button btnOption2;
        private Button btnOption3;
        private Button btnOption4;
        private TextBox txtBoxQuestion;
        private Button btn5050;
        private Button btnHint;
        private TextBox txtBoxPlayer;
        private TextBox txtBoxPoints;
        private Label lblQuestionsPoints;
        private Label lblQ7;
        private Label lblQ5;
        private Label lblQ6;
        private Label lblQ4;
        private Label lblQ3;
        private Label lblQ2;
        private Label lblQ1;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtBoxTimer;
    }
}