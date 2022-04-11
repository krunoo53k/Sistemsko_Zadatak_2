namespace Sistemsko_Zad_2
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
            this.notepadButton = new System.Windows.Forms.Button();
            this.paintButton = new System.Windows.Forms.Button();
            this.cmdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notepadButton
            // 
            this.notepadButton.Location = new System.Drawing.Point(12, 73);
            this.notepadButton.Name = "notepadButton";
            this.notepadButton.Size = new System.Drawing.Size(75, 58);
            this.notepadButton.TabIndex = 0;
            this.notepadButton.Text = "notepad";
            this.notepadButton.UseVisualStyleBackColor = true;
            this.notepadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // paintButton
            // 
            this.paintButton.Location = new System.Drawing.Point(126, 73);
            this.paintButton.Name = "paintButton";
            this.paintButton.Size = new System.Drawing.Size(75, 58);
            this.paintButton.TabIndex = 1;
            this.paintButton.Text = "paint";
            this.paintButton.UseVisualStyleBackColor = true;
            this.paintButton.Click += new System.EventHandler(this.paintButton_Click);
            // 
            // cmdButton
            // 
            this.cmdButton.Location = new System.Drawing.Point(235, 73);
            this.cmdButton.Name = "cmdButton";
            this.cmdButton.Size = new System.Drawing.Size(75, 58);
            this.cmdButton.TabIndex = 2;
            this.cmdButton.Text = "CMD";
            this.cmdButton.UseVisualStyleBackColor = true;
            this.cmdButton.Click += new System.EventHandler(this.cmdButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 175);
            this.Controls.Add(this.cmdButton);
            this.Controls.Add(this.paintButton);
            this.Controls.Add(this.notepadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button notepadButton;
        private System.Windows.Forms.Button paintButton;
        private System.Windows.Forms.Button cmdButton;
    }
}

