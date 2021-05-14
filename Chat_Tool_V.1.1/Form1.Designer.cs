
namespace Chat_Tool_V._1._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tel = new System.Windows.Forms.TextBox();
            this.schreiben = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bttn_copy = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(12, 12);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(120, 23);
            this.tel.TabIndex = 7;
            this.tel.Text = "004961088227320";
            // 
            // schreiben
            // 
            this.schreiben.Location = new System.Drawing.Point(138, 12);
            this.schreiben.Name = "schreiben";
            this.schreiben.Size = new System.Drawing.Size(115, 23);
            this.schreiben.TabIndex = 6;
            this.schreiben.Text = "Link generieren";
            this.schreiben.UseVisualStyleBackColor = true;
            this.schreiben.Click += new System.EventHandler(this.schreiben_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(64, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(237, 63);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // bttn_copy
            // 
            this.bttn_copy.Location = new System.Drawing.Point(132, 113);
            this.bttn_copy.Name = "bttn_copy";
            this.bttn_copy.Size = new System.Drawing.Size(100, 23);
            this.bttn_copy.TabIndex = 12;
            this.bttn_copy.Text = "Link kopieren";
            this.bttn_copy.UseVisualStyleBackColor = true;
            this.bttn_copy.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(259, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 19);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Browser öffnen";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "V.1.1 by Tom Scheele";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bttn_copy);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.schreiben);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WhatsApp Link-Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Button schreiben;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bttn_copy;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}

