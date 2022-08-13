namespace LuckySpinner
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAttempt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(19, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Guess Numbers";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(119, 232);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 26);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(198, 112);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(97, 20);
            this.txtNum.TabIndex = 2;
            this.txtNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuess_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your guessed number";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(69, 179);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(27, 29);
            this.lblNum1.TabIndex = 4;
            this.lblNum1.Text = "#";
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum3.Location = new System.Drawing.Point(203, 179);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(27, 29);
            this.lblNum3.TabIndex = 5;
            this.lblNum3.Text = "#";
            this.lblNum3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(137, 179);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(27, 29);
            this.lblNum2.TabIndex = 6;
            this.lblNum2.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "No of attempts:";
            // 
            // lblAttempt
            // 
            this.lblAttempt.AutoSize = true;
            this.lblAttempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempt.ForeColor = System.Drawing.Color.Red;
            this.lblAttempt.Location = new System.Drawing.Point(195, 281);
            this.lblAttempt.Name = "lblAttempt";
            this.lblAttempt.Size = new System.Drawing.Size(15, 16);
            this.lblAttempt.TabIndex = 8;
            this.lblAttempt.Text = "3";
            this.lblAttempt.Click += new System.EventHandler(this.lblAttempt_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(340, 306);
            this.Controls.Add(this.lblAttempt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Lucky Spinner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAttempt;
        private System.Windows.Forms.Timer timer1;
    }
}

