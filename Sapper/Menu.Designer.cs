namespace SapperGame
{
    partial class MenuSapper
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
            this.startButton = new System.Windows.Forms.Button();
            this.dimension = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numRowsBox = new System.Windows.Forms.TextBox();
            this.percentage = new System.Windows.Forms.TextBox();
            this.exitGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeRadio9x9 = new System.Windows.Forms.RadioButton();
            this.sizeRadio16x16 = new System.Windows.Forms.RadioButton();
            this.radioButton16x32 = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomSize = new System.Windows.Forms.RadioButton();
            this.numCollsBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.radioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(31, 193);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(140, 55);
            this.startButton.TabIndex = 0;
            this.startButton.TabStop = false;
            this.startButton.Tag = "1";
            this.startButton.Text = "START GAME!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // dimension
            // 
            this.dimension.AutoSize = true;
            this.dimension.Location = new System.Drawing.Point(38, 201);
            this.dimension.Name = "dimension";
            this.dimension.Size = new System.Drawing.Size(0, 13);
            this.dimension.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pct. of bomb:";
            // 
            // numRowsBox
            // 
            this.numRowsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRowsBox.Location = new System.Drawing.Point(116, 101);
            this.numRowsBox.Name = "numRowsBox";
            this.numRowsBox.Size = new System.Drawing.Size(20, 20);
            this.numRowsBox.TabIndex = 3;
            this.numRowsBox.Text = "24";
            this.numRowsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // percentage
            // 
            this.percentage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.percentage.Location = new System.Drawing.Point(128, 9);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(43, 20);
            this.percentage.TabIndex = 4;
            this.percentage.Text = "20";
            this.percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitGame
            // 
            this.exitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitGame.Location = new System.Drawing.Point(31, 254);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(140, 55);
            this.exitGame.TabIndex = 6;
            this.exitGame.Text = "EXIT";
            this.exitGame.UseVisualStyleBackColor = true;
            this.exitGame.Click += new System.EventHandler(this.exitGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "%";
            // 
            // sizeRadio9x9
            // 
            this.sizeRadio9x9.AutoSize = true;
            this.sizeRadio9x9.Checked = true;
            this.sizeRadio9x9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeRadio9x9.Location = new System.Drawing.Point(21, 25);
            this.sizeRadio9x9.Name = "sizeRadio9x9";
            this.sizeRadio9x9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sizeRadio9x9.Size = new System.Drawing.Size(51, 19);
            this.sizeRadio9x9.TabIndex = 8;
            this.sizeRadio9x9.TabStop = true;
            this.sizeRadio9x9.Text = "9 x 9";
            this.sizeRadio9x9.UseVisualStyleBackColor = true;
            // 
            // sizeRadio16x16
            // 
            this.sizeRadio16x16.AutoSize = true;
            this.sizeRadio16x16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeRadio16x16.Location = new System.Drawing.Point(21, 50);
            this.sizeRadio16x16.Name = "sizeRadio16x16";
            this.sizeRadio16x16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sizeRadio16x16.Size = new System.Drawing.Size(65, 19);
            this.sizeRadio16x16.TabIndex = 10;
            this.sizeRadio16x16.Text = "16 x 16";
            this.sizeRadio16x16.UseVisualStyleBackColor = true;
            // 
            // radioButton16x32
            // 
            this.radioButton16x32.AutoSize = true;
            this.radioButton16x32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton16x32.Location = new System.Drawing.Point(21, 75);
            this.radioButton16x32.Name = "radioButton16x32";
            this.radioButton16x32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton16x32.Size = new System.Drawing.Size(65, 19);
            this.radioButton16x32.TabIndex = 11;
            this.radioButton16x32.Text = "16 x 32";
            this.radioButton16x32.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomSize
            // 
            this.radioButtonCustomSize.AutoSize = true;
            this.radioButtonCustomSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCustomSize.Location = new System.Drawing.Point(21, 100);
            this.radioButtonCustomSize.Name = "radioButtonCustomSize";
            this.radioButtonCustomSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonCustomSize.Size = new System.Drawing.Size(96, 20);
            this.radioButtonCustomSize.TabIndex = 12;
            this.radioButtonCustomSize.Text = "custom size";
            this.radioButtonCustomSize.UseVisualStyleBackColor = true;
            // 
            // numCollsBox
            // 
            this.numCollsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCollsBox.Location = new System.Drawing.Point(142, 101);
            this.numCollsBox.Name = "numCollsBox";
            this.numCollsBox.Size = new System.Drawing.Size(20, 20);
            this.numCollsBox.TabIndex = 14;
            this.numCollsBox.Text = "54";
            this.numCollsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "(max 24 x 54)";
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.sizeRadio9x9);
            this.radioGroupBox.Controls.Add(this.numRowsBox);
            this.radioGroupBox.Controls.Add(this.label5);
            this.radioGroupBox.Controls.Add(this.sizeRadio16x16);
            this.radioGroupBox.Controls.Add(this.label1);
            this.radioGroupBox.Controls.Add(this.radioButton16x32);
            this.radioGroupBox.Controls.Add(this.numCollsBox);
            this.radioGroupBox.Controls.Add(this.radioButtonCustomSize);
            this.radioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroupBox.Location = new System.Drawing.Point(12, 35);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(174, 142);
            this.radioGroupBox.TabIndex = 18;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "Choose a size:";
            // 
            // MenuSapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 321);
            this.Controls.Add(this.radioGroupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dimension);
            this.Controls.Add(this.startButton);
            this.Name = "MenuSapper";
            this.Text = "Sapper";
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label dimension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numRowsBox;
        private System.Windows.Forms.TextBox percentage;
        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton sizeRadio9x9;
        private System.Windows.Forms.RadioButton sizeRadio16x16;
        private System.Windows.Forms.RadioButton radioButton16x32;
        private System.Windows.Forms.RadioButton radioButtonCustomSize;
        private System.Windows.Forms.TextBox numCollsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox radioGroupBox;
    }
}

