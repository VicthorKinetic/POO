namespace prjFormExercicio2
{
    partial class Aresta
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
            this.lbl_Aresta = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.lbl_display = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
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
            // lbl_Aresta
            // 
            this.lbl_Aresta.AutoSize = true;
            this.lbl_Aresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aresta.Location = new System.Drawing.Point(55, 29);
            this.lbl_Aresta.Name = "lbl_Aresta";
            this.lbl_Aresta.Size = new System.Drawing.Size(63, 24);
            this.lbl_Aresta.TabIndex = 1;
            this.lbl_Aresta.Text = "Aresta";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(46, 213);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(94, 24);
            this.lbl_Resultado.TabIndex = 3;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // lbl_display
            // 
            this.lbl_display.AutoSize = true;
            this.lbl_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display.Location = new System.Drawing.Point(190, 213);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(60, 24);
            this.lbl_display.TabIndex = 4;
            this.lbl_display.Text = "label4";
            this.lbl_display.Visible = false;
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(124, 33);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(146, 20);
            this.txtbox1.TabIndex = 5;
            // 
            // Aresta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 263);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.lbl_Aresta);
            this.Controls.Add(this.btn_Veri);
            this.Name = "Aresta";
            this.Text = "Área Aresta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Veri;
        private System.Windows.Forms.Label lbl_Aresta;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.TextBox txtbox1;
    }
}

