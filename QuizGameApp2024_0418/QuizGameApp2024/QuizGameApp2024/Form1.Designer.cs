namespace QuizGameApp2024
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.lblyourscore = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.picBoxCorrect = new System.Windows.Forms.PictureBox();
            this.picBoxIncorrect = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.lblPresentation = new System.Windows.Forms.Label();
            this.lblPresent2 = new System.Windows.Forms.Label();
            this.picMathlady = new System.Windows.Forms.PictureBox();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIncorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathlady)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::QuizGameApp2024.Properties.Resources._2quiz_button;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(242, 164);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(684, 242);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Linen;
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion.Font = new System.Drawing.Font("Yu Gothic UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(84, 46);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(985, 136);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Visible = false;
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2.Location = new System.Drawing.Point(335, 214);
            this.btnAnswer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(222, 120);
            this.btnAnswer2.TabIndex = 3;
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.Visible = false;
            this.btnAnswer2.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer3.Location = new System.Drawing.Point(593, 214);
            this.btnAnswer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(222, 120);
            this.btnAnswer3.TabIndex = 4;
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.Visible = false;
            this.btnAnswer3.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(846, 407);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(251, 75);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer1.Location = new System.Drawing.Point(84, 214);
            this.btnAnswer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(222, 120);
            this.btnAnswer1.TabIndex = 7;
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.Visible = false;
            this.btnAnswer1.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // lblyourscore
            // 
            this.lblyourscore.BackColor = System.Drawing.Color.Gold;
            this.lblyourscore.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyourscore.Location = new System.Drawing.Point(97, 403);
            this.lblyourscore.Name = "lblyourscore";
            this.lblyourscore.Size = new System.Drawing.Size(167, 36);
            this.lblyourscore.TabIndex = 8;
            this.lblyourscore.Text = "Your score:";
            this.lblyourscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblyourscore.Visible = false;
            // 
            // lblPoints
            // 
            this.lblPoints.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(97, 441);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(167, 41);
            this.lblPoints.TabIndex = 9;
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPoints.Visible = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAnswer.Location = new System.Drawing.Point(480, 350);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(200, 64);
            this.lblAnswer.TabIndex = 10;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswer.Visible = false;
            // 
            // picBoxCorrect
            // 
            this.picBoxCorrect.Image = global::QuizGameApp2024.Properties.Resources.blow_mind_mind_blown;
            this.picBoxCorrect.Location = new System.Drawing.Point(394, 428);
            this.picBoxCorrect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxCorrect.Name = "picBoxCorrect";
            this.picBoxCorrect.Size = new System.Drawing.Size(380, 238);
            this.picBoxCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCorrect.TabIndex = 11;
            this.picBoxCorrect.TabStop = false;
            this.picBoxCorrect.Visible = false;
            // 
            // picBoxIncorrect
            // 
            this.picBoxIncorrect.Image = global::QuizGameApp2024.Properties.Resources.noplease;
            this.picBoxIncorrect.Location = new System.Drawing.Point(452, 426);
            this.picBoxIncorrect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxIncorrect.Name = "picBoxIncorrect";
            this.picBoxIncorrect.Size = new System.Drawing.Size(258, 239);
            this.picBoxIncorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxIncorrect.TabIndex = 12;
            this.picBoxIncorrect.TabStop = false;
            this.picBoxIncorrect.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(95, 535);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 77);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.LightPink;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.clearBtn.Location = new System.Drawing.Point(846, 407);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(251, 79);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Play Again";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Visible = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click_1);
            // 
            // lblPresentation
            // 
            this.lblPresentation.BackColor = System.Drawing.Color.LightPink;
            this.lblPresentation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPresentation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPresentation.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblPresentation.Location = new System.Drawing.Point(350, 395);
            this.lblPresentation.Name = "lblPresentation";
            this.lblPresentation.Size = new System.Drawing.Size(454, 58);
            this.lblPresentation.TabIndex = 15;
            this.lblPresentation.Text = "Created by Choo && Daiana";
            this.lblPresentation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPresent2
            // 
            this.lblPresent2.BackColor = System.Drawing.Color.LightPink;
            this.lblPresent2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPresent2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPresent2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblPresent2.Location = new System.Drawing.Point(480, 453);
            this.lblPresent2.Name = "lblPresent2";
            this.lblPresent2.Size = new System.Drawing.Size(200, 54);
            this.lblPresent2.TabIndex = 16;
            this.lblPresent2.Text = "Have fun!";
            this.lblPresent2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMathlady
            // 
            this.picMathlady.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picMathlady.Image = global::QuizGameApp2024.Properties.Resources.mathlady;
            this.picMathlady.Location = new System.Drawing.Point(452, 29);
            this.picMathlady.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMathlady.Name = "picMathlady";
            this.picMathlady.Size = new System.Drawing.Size(248, 161);
            this.picMathlady.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMathlady.TabIndex = 17;
            this.picMathlady.TabStop = false;
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer4.Location = new System.Drawing.Point(846, 214);
            this.btnAnswer4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(222, 120);
            this.btnAnswer4.TabIndex = 5;
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.Visible = false;
            this.btnAnswer4.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::QuizGameApp2024.Properties.Resources.hand_drawn_question_mark_pattern_23_2149416651;
            this.ClientSize = new System.Drawing.Size(1164, 755);
            this.Controls.Add(this.picMathlady);
            this.Controls.Add(this.lblPresent2);
            this.Controls.Add(this.lblPresentation);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picBoxIncorrect);
            this.Controls.Add(this.picBoxCorrect);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblyourscore);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnStart);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Quiz Game";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIncorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathlady)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Label lblyourscore;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.PictureBox picBoxCorrect;
        private System.Windows.Forms.PictureBox picBoxIncorrect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button clearBtn;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPresentation;
        private System.Windows.Forms.Label lblPresent2;
        private System.Windows.Forms.PictureBox picMathlady;
        private System.Windows.Forms.Button btnAnswer4;
    }
}

