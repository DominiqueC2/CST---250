namespace WhackAMole
{
    partial class FrmStopwatch
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
            components = new System.ComponentModel.Container();
            lblTimeElapsed = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnReset = new Button();
            tmrStopwatch = new System.Windows.Forms.Timer(components);
            btnTarget = new Button();
            label1 = new Label();
            lblScore = new Label();
            btnDecoy = new Button();
            SuspendLayout();
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.AutoSize = true;
            lblTimeElapsed.Location = new Point(59, 9);
            lblTimeElapsed.Name = "lblTimeElapsed";
            lblTimeElapsed.Size = new Size(38, 15);
            lblTimeElapsed.TabIndex = 0;
            lblTimeElapsed.Text = "label1";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(24, 807);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStartClickEH;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(126, 807);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += BtnStopClickEH;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(224, 807);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnResetClickEH;
            // 
            // tmrStopwatch
            // 
            tmrStopwatch.Interval = 1000;
            tmrStopwatch.Tick += TmrStopwatchIickEH;
            // 
            // btnTarget
            // 
            btnTarget.BackColor = Color.Green;
            btnTarget.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTarget.Location = new Point(190, 290);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(140, 100);
            btnTarget.TabIndex = 4;
            btnTarget.Text = "Target";
            btnTarget.UseVisualStyleBackColor = false;
            btnTarget.Click += BtnTargetClickEH;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 5;
            label1.Text = "Timer:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(15, 36);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(38, 15);
            lblScore.TabIndex = 7;
            lblScore.Text = "label3";
            // 
            // btnDecoy
            // 
            btnDecoy.BackColor = Color.Red;
            btnDecoy.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecoy.Location = new Point(467, 290);
            btnDecoy.Name = "btnDecoy";
            btnDecoy.Size = new Size(140, 100);
            btnDecoy.TabIndex = 8;
            btnDecoy.Text = "Nope";
            btnDecoy.UseVisualStyleBackColor = false;
            btnDecoy.Click += btnDecoyClickEH;
            // 
            // FrmStopwatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(988, 854);
            Controls.Add(btnDecoy);
            Controls.Add(lblScore);
            Controls.Add(label1);
            Controls.Add(btnTarget);
            Controls.Add(btnReset);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblTimeElapsed);
            Name = "FrmStopwatch";
            Text = "Stopwatch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimeElapsed;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private System.Windows.Forms.Timer tmrStopwatch;
        private Button btnTarget;
        private Label label1;
        private Label lblScore;
        private Button btnDecoy;
    }
}
