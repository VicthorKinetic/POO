namespace prjFormExercicio5
{
    partial class Maior
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
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.lbl_display = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Veri
            // 
            this.btn_Veri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Veri.Location = new System.Drawing.Point(91, 85);
            this.btn_Veri.Name = "btn_Veri";
            this.btn_Veri.Size = new System.Drawing.Size(142, 93);
            this.btn_Veri.TabIndex = 0;
            this.btn_Veri.Text = "Efetuar";
            this.btn_Veri.UseVisualStyleBackColor = true;
            this.btn_Veri.Click += new System.EventHandler(this.btn_Veri_Click);
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(22, 7);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(94, 24);
            this.lbl_n1.TabIndex = 1;
            this.lbl_n1.Text = "Número 1";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(22, 213);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(131, 24);
            this.lbl_Resultado.TabIndex = 3;
            this.lbl_Resultado.Text = "Maior Número";
            // 
            // lbl_display
            // 
            this.lbl_display.AutoSize = true;
            this.lbl_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display.Location = new System.Drawing.Point(169, 213);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(60, 24);
            this.lbl_display.TabIndex = 4;
            this.lbl_display.Text = "label4";
            this.lbl_display.Visible = false;
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(122, 12);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(146, 20);
            this.txtbox1.TabIndex = 5;
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(122, 40);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(146, 20);
            this.txtbox2.TabIndex = 7;
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.Location = new System.Drawing.Point(22, 35);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(94, 24);
            this.lbl_n2.TabIndex = 6;
            this.lbl_n2.Text = "Número 2";
            // 
            // Maior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 263);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.btn_Veri);
            this.Name = "Maior";
            this.Text = "Número Maior";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Veri;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Label lbl_n2;
    }
}

