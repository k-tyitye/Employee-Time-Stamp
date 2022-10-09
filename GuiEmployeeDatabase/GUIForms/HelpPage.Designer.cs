namespace GuiEmployeeDatabase
{
    partial class HelpPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(90, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(510, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Return to Home Screen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logo
            // 
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo.Image = global::GuiEmployeeDatabase.Properties.Resources.Screenshot_2022_10_01_140311;
            this.Logo.Location = new System.Drawing.Point(245, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(203, 135);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 9;
            this.Logo.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(17, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(650, 2);
            this.label4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(17, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(650, 2);
            this.label3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(168, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 67);
            this.label1.TabIndex = 13;
            this.label1.Text = "Type your UserName into the UserName box and your Password in the Password box an" +
    "d hit Sign In to login and record your time stamp.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(168, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 67);
            this.label2.TabIndex = 14;
            this.label2.Text = "Click the buttons under each field to recover the UserName and/or Password.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(165, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "How to Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(165, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "To recover UserName or Password";
            // 
            // HelpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 603);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Name = "HelpPage";
            this.Text = "Employee Solutions Time Stamp";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private PictureBox Logo;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
    }
}