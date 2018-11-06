namespace SMTP
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.RichTextBox();
            this.Send_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SMTPServ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.ListBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message";
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(76, 13);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(165, 20);
            this.From.TabIndex = 4;
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(76, 66);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(165, 20);
            this.To.TabIndex = 5;
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(76, 92);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(399, 20);
            this.Subject.TabIndex = 6;
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.SystemColors.Window;
            this.Message.Location = new System.Drawing.Point(76, 118);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(399, 121);
            this.Message.TabIndex = 7;
            this.Message.Text = "";
            // 
            // Send_btn
            // 
            this.Send_btn.Location = new System.Drawing.Point(400, 245);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(75, 23);
            this.Send_btn.TabIndex = 8;
            this.Send_btn.Text = "Send";
            this.Send_btn.UseVisualStyleBackColor = true;
            this.Send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "SMTP Server";
            // 
            // SMTPServ
            // 
            this.SMTPServ.Location = new System.Drawing.Point(334, 13);
            this.SMTPServ.Name = "SMTPServ";
            this.SMTPServ.Size = new System.Drawing.Size(141, 20);
            this.SMTPServ.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Port";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(334, 39);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(70, 20);
            this.Port.TabIndex = 14;
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(12, 274);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(463, 69);
            this.Status.TabIndex = 15;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(76, 39);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(165, 20);
            this.Pass.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(9, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 349);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SMTPServ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SMTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.RichTextBox Message;
        private System.Windows.Forms.Button Send_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SMTPServ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.ListBox Status;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label8;
    }
}

