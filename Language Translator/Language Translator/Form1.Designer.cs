namespace Language_Translator
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.italianButton = new System.Windows.Forms.Button();
            this.spanishButton = new System.Windows.Forms.Button();
            this.germanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.instructionLabel.Location = new System.Drawing.Point(240, 158);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(354, 20);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Select a language and I will say Good Morning";
            this.instructionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Location = new System.Drawing.Point(243, 189);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(278, 23);
            this.translationLabel.TabIndex = 1;
            this.translationLabel.Click += new System.EventHandler(this.translationLabel_Click);
            // 
            // italianButton
            // 
            this.italianButton.Location = new System.Drawing.Point(243, 228);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(75, 23);
            this.italianButton.TabIndex = 2;
            this.italianButton.Text = "Italian";
            this.italianButton.UseVisualStyleBackColor = true;
            this.italianButton.Click += new System.EventHandler(this.italianButton_Click);
            // 
            // spanishButton
            // 
            this.spanishButton.Location = new System.Drawing.Point(348, 228);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(75, 23);
            this.spanishButton.TabIndex = 3;
            this.spanishButton.Text = "Spanish";
            this.spanishButton.UseVisualStyleBackColor = true;
            this.spanishButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // germanButton
            // 
            this.germanButton.Location = new System.Drawing.Point(446, 228);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(75, 23);
            this.germanButton.TabIndex = 4;
            this.germanButton.Text = "German";
            this.germanButton.UseVisualStyleBackColor = true;
            this.germanButton.Click += new System.EventHandler(this.germanButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.germanButton);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.italianButton);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Language Translator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Button italianButton;
        private System.Windows.Forms.Button spanishButton;
        private System.Windows.Forms.Button germanButton;
    }
}

