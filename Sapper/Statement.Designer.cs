namespace SapperGame
{
    partial class Statement
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
            this.restartGame = new System.Windows.Forms.Button();
            this.startNewGame = new System.Windows.Forms.Button();
            this.exitGame = new System.Windows.Forms.Button();
            this.resultGameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultClearedBombsLabel = new System.Windows.Forms.Label();
            this.resultTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // restartGame
            // 
            this.restartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartGame.Location = new System.Drawing.Point(12, 84);
            this.restartGame.Name = "restartGame";
            this.restartGame.Size = new System.Drawing.Size(126, 42);
            this.restartGame.TabIndex = 0;
            this.restartGame.Text = "Restart";
            this.restartGame.UseVisualStyleBackColor = true;
            this.restartGame.Click += new System.EventHandler(this.restartGame_Click);
            // 
            // startNewGame
            // 
            this.startNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startNewGame.Location = new System.Drawing.Point(144, 84);
            this.startNewGame.Name = "startNewGame";
            this.startNewGame.Size = new System.Drawing.Size(126, 42);
            this.startNewGame.TabIndex = 1;
            this.startNewGame.Text = "Start new game";
            this.startNewGame.UseVisualStyleBackColor = true;
            this.startNewGame.Click += new System.EventHandler(this.startNewGame_Click);
            // 
            // exitGame
            // 
            this.exitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGame.Location = new System.Drawing.Point(13, 132);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(257, 38);
            this.exitGame.TabIndex = 2;
            this.exitGame.Text = "Exit";
            this.exitGame.UseVisualStyleBackColor = true;
            this.exitGame.Click += new System.EventHandler(this.exitGame_Click);
            // 
            // resultGameLabel
            // 
            this.resultGameLabel.AutoSize = true;
            this.resultGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultGameLabel.Location = new System.Drawing.Point(87, 9);
            this.resultGameLabel.Name = "resultGameLabel";
            this.resultGameLabel.Size = new System.Drawing.Size(108, 20);
            this.resultGameLabel.TabIndex = 3;
            this.resultGameLabel.Text = "Ha-ha, looser!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of bombs neutralized:";
            // 
            // resultClearedBombsLabel
            // 
            this.resultClearedBombsLabel.AutoSize = true;
            this.resultClearedBombsLabel.Location = new System.Drawing.Point(182, 39);
            this.resultClearedBombsLabel.Name = "resultClearedBombsLabel";
            this.resultClearedBombsLabel.Size = new System.Drawing.Size(13, 13);
            this.resultClearedBombsLabel.TabIndex = 6;
            this.resultClearedBombsLabel.Text = "0";
            // 
            // resultTimeLabel
            // 
            this.resultTimeLabel.AutoSize = true;
            this.resultTimeLabel.Location = new System.Drawing.Point(46, 54);
            this.resultTimeLabel.Name = "resultTimeLabel";
            this.resultTimeLabel.Size = new System.Drawing.Size(13, 13);
            this.resultTimeLabel.TabIndex = 7;
            this.resultTimeLabel.Text = "0";
            // 
            // Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 181);
            this.Controls.Add(this.resultTimeLabel);
            this.Controls.Add(this.resultClearedBombsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultGameLabel);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.startNewGame);
            this.Controls.Add(this.restartGame);
            this.Name = "Statement";
            this.Text = "BOOM!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restartGame;
        private System.Windows.Forms.Button startNewGame;
        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.Label resultGameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultClearedBombsLabel;
        private System.Windows.Forms.Label resultTimeLabel;
    }
}