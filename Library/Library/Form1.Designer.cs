namespace Library
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.IncButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(96, 64);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CounterLabel.Location = new System.Drawing.Point(81, 18);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(24, 25);
            this.CounterLabel.TabIndex = 1;
            this.CounterLabel.Text = "0";
            // 
            // IncButton
            // 
            this.IncButton.Location = new System.Drawing.Point(15, 64);
            this.IncButton.Name = "IncButton";
            this.IncButton.Size = new System.Drawing.Size(75, 23);
            this.IncButton.TabIndex = 2;
            this.IncButton.Text = "Increase";
            this.IncButton.UseVisualStyleBackColor = true;
            this.IncButton.Click += new System.EventHandler(this.IncButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 107);
            this.Controls.Add(this.IncButton);
            this.Controls.Add(this.CounterLabel);
            this.Controls.Add(this.ClearButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.Button IncButton;
    }
}

