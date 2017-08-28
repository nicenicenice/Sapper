namespace SapperGame
{
    partial class Sapper
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
            this.hideFocusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hideFocusButton
            // 
            this.hideFocusButton.Location = new System.Drawing.Point(120, 305);
            this.hideFocusButton.Name = "hideFocusButton";
            this.hideFocusButton.Size = new System.Drawing.Size(0, 0);
            this.hideFocusButton.TabIndex = 1;
            this.hideFocusButton.Text = "button1";
            this.hideFocusButton.UseVisualStyleBackColor = true;
            // 
            // Sapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(169, 133);
            this.Controls.Add(this.hideFocusButton);
            this.Name = "Sapper";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.Text = "Sapper";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button hideFocusButton;
    }
}