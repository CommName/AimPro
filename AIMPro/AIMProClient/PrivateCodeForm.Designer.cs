namespace AIMProClient
{
    partial class PrivateCodeForm
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
            this.privatePanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.privatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // privatePanel
            // 
            this.privatePanel.Controls.Add(this.textBox1);
            this.privatePanel.Controls.Add(this.label4);
            this.privatePanel.Controls.Add(this.button2);
            this.privatePanel.Location = new System.Drawing.Point(12, 12);
            this.privatePanel.Name = "privatePanel";
            this.privatePanel.Size = new System.Drawing.Size(262, 87);
            this.privatePanel.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter key for private room";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Join Private Room";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PrivateCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 111);
            this.Controls.Add(this.privatePanel);
            this.Name = "PrivateCodeForm";
            this.Text = "PrivateCodeForm";
            this.privatePanel.ResumeLayout(false);
            this.privatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel privatePanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}