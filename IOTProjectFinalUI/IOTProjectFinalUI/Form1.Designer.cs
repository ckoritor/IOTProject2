namespace IOTProjectFinalUI
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
            this.onButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // onButton
            // 
            this.onButton.BackColor = System.Drawing.Color.Lime;
            this.onButton.Location = new System.Drawing.Point(45, 133);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(210, 75);
            this.onButton.TabIndex = 0;
            this.onButton.Text = "ON";
            this.onButton.UseVisualStyleBackColor = false;
            this.onButton.Click += new System.EventHandler(this.onButtonClick);
            // 
            // offButton
            // 
            this.offButton.BackColor = System.Drawing.Color.Red;
            this.offButton.Location = new System.Drawing.Point(347, 133);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(210, 75);
            this.offButton.TabIndex = 1;
            this.offButton.Text = "OFF";
            this.offButton.UseVisualStyleBackColor = false;
            this.offButton.Click += new System.EventHandler(this.offButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 359);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.onButton);
            this.Name = "Form1";
            this.Text = "Easy Heat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Button offButton;
    }
}

