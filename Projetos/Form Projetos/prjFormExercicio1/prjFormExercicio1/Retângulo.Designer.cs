namespace prjFormExercicio1
{
    partial class Retângulo
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
            this.btn_Efetuar = new System.Windows.Forms.Button();
            this.lbl_base = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_display = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Efetuar
            // 
            this.btn_Efetuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Efetuar.Location = new System.Drawing.Point(117, 186);
            this.btn_Efetuar.Name = "btn_Efetuar";
            this.btn_Efetuar.Size = new System.Drawing.Size(160, 60);
            this.btn_Efetuar.TabIndex = 0;
            this.btn_Efetuar.Text = "Efetuar";
            this.btn_Efetuar.UseVisualStyleBackColor = true;
            this.btn_Efetuar.Click += new System.EventHandler(this.btn_Efetuar_Click);
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_base.Location = new System.Drawing.Point(81, 55);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(52, 24);
            this.lbl_base.TabIndex = 1;
            this.lbl_base.Text = "Base";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altura.Location = new System.Drawing.Point(81, 115);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(58, 24);
            this.lbl_altura.TabIndex = 2;
            this.lbl_altura.Text = "Altura";
            // 
            // lbl_display
            // 
            this.lbl_display.AutoSize = true;
            this.lbl_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display.Location = new System.Drawing.Point(197, 329);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(60, 24);
            this.lbl_display.TabIndex = 3;
            this.lbl_display.Text = "label3";
            this.lbl_display.Visible = false;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(92, 329);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(99, 24);
            this.lbl_resultado.TabIndex = 4;
            this.lbl_resultado.Text = "Resultado:";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(146, 59);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(171, 20);
            this.txtbox1.TabIndex = 5;
            this.txtbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox1_KeyPress);
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(146, 115);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(171, 20);
            this.txtbox2.TabIndex = 6;
            this.txtbox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox2_KeyPress);
            // 
            // Retângulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 379);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_base);
            this.Controls.Add(this.btn_Efetuar);
            this.Name = "Retângulo";
            this.Text = "Área";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Efetuar;
        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
    }
}

