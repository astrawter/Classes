namespace AlexandriaStrawter_CE02
{
    partial class Stats
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
            this.goodTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.evilTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Good Character Count";
            // 
            // goodTextBox
            // 
            this.goodTextBox.Location = new System.Drawing.Point(179, 33);
            this.goodTextBox.Name = "goodTextBox";
            this.goodTextBox.ReadOnly = true;
            this.goodTextBox.Size = new System.Drawing.Size(80, 22);
            this.goodTextBox.TabIndex = 2;
            this.goodTextBox.Text = "0";
            this.goodTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Evil Character Count";
            // 
            // evilTextBox
            // 
            this.evilTextBox.Location = new System.Drawing.Point(179, 70);
            this.evilTextBox.Name = "evilTextBox";
            this.evilTextBox.ReadOnly = true;
            this.evilTextBox.Size = new System.Drawing.Size(80, 22);
            this.evilTextBox.TabIndex = 4;
            this.evilTextBox.Text = "0";
            this.evilTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 113);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.evilTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goodTextBox);
            this.Name = "Stats";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox goodTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox evilTextBox;
    }
}