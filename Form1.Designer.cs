namespace Bot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butonTus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mailText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butonTus
            // 
            this.butonTus.Location = new System.Drawing.Point(260, 305);
            this.butonTus.Name = "butonTus";
            this.butonTus.Size = new System.Drawing.Size(121, 32);
            this.butonTus.TabIndex = 0;
            this.butonTus.Text = "Log In";
            this.butonTus.UseVisualStyleBackColor = true;
            this.butonTus.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(260, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Facebook Login Bot";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mailText
            // 
            this.mailText.Location = new System.Drawing.Point(142, 155);
            this.mailText.Name = "mailText";
            this.mailText.Size = new System.Drawing.Size(239, 27);
            this.mailText.TabIndex = 4;
            this.mailText.TextChanged += new System.EventHandler(this.mailText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mail/Phone:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(142, 215);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(239, 27);
            this.textPass.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mailText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butonTus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button butonTus;
        private Label label2;
        private TextBox mailText;
        private Label label3;
        private Label label4;
        private TextBox textPass;
    }
}