namespace RaptorsQuizA1HumzaAli
{
    partial class Form3
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
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPlayer = new System.Windows.Forms.TextBox();
            this.txtBoxPoints = new System.Windows.Forms.TextBox();
            this.btnAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(342, 98);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "Points";
            // 
            // txtBoxPlayer
            // 
            this.txtBoxPlayer.BackColor = System.Drawing.Color.Black;
            this.txtBoxPlayer.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPlayer.ForeColor = System.Drawing.Color.White;
            this.txtBoxPlayer.Location = new System.Drawing.Point(360, 6);
            this.txtBoxPlayer.Name = "txtBoxPlayer";
            this.txtBoxPlayer.ReadOnly = true;
            this.txtBoxPlayer.Size = new System.Drawing.Size(428, 107);
            this.txtBoxPlayer.TabIndex = 2;
            this.txtBoxPlayer.TextChanged += new System.EventHandler(this.txtBoxPlayer_TextChanged);
            // 
            // txtBoxPoints
            // 
            this.txtBoxPoints.BackColor = System.Drawing.Color.Black;
            this.txtBoxPoints.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPoints.ForeColor = System.Drawing.Color.White;
            this.txtBoxPoints.Location = new System.Drawing.Point(360, 119);
            this.txtBoxPoints.Name = "txtBoxPoints";
            this.txtBoxPoints.ReadOnly = true;
            this.txtBoxPoints.Size = new System.Drawing.Size(428, 107);
            this.txtBoxPoints.TabIndex = 3;
            // 
            // btnAgain
            // 
            this.btnAgain.BackColor = System.Drawing.Color.DimGray;
            this.btnAgain.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgain.Location = new System.Drawing.Point(12, 273);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(776, 121);
            this.btnAgain.TabIndex = 4;
            this.btnAgain.Text = "Play Again";
            this.btnAgain.UseVisualStyleBackColor = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.txtBoxPoints);
            this.Controls.Add(this.txtBoxPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form3";
            this.Text = "Toronto Raptors Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label label1;
        private TextBox txtBoxPlayer;
        private TextBox txtBoxPoints;
        private Button btnAgain;
    }
}