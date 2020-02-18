namespace prjPalíndromoPOO
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
            this.btn_Veri = new System.Windows.Forms.Button();
            this.txt_pergunta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Veri
            // 
            this.btn_Veri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Veri.Location = new System.Drawing.Point(92, 207);
            this.btn_Veri.Name = "btn_Veri";
            this.btn_Veri.Size = new System.Drawing.Size(174, 81);
            this.btn_Veri.TabIndex = 0;
            this.btn_Veri.Text = "Verifica";
            this.btn_Veri.UseVisualStyleBackColor = true;
            this.btn_Veri.Click += new System.EventHandler(this.btn_Veri_Click);
            // 
            // txt_pergunta
            // 
            this.txt_pergunta.Location = new System.Drawing.Point(92, 114);
            this.txt_pergunta.Name = "txt_pergunta";
            this.txt_pergunta.Size = new System.Drawing.Size(174, 20);
            this.txt_pergunta.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(348, 329);
            this.Controls.Add(this.txt_pergunta);
            this.Controls.Add(this.btn_Veri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Veri;
        private System.Windows.Forms.TextBox txt_pergunta;
    }
}

