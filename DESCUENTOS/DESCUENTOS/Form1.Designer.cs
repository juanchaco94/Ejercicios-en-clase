namespace DESCUENTOS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Valor_Compra = new System.Windows.Forms.TextBox();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.lbl_Descuento_Obtenido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Valor_Descuento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Total_Con_Descuento = new System.Windows.Forms.Label();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VALOR COMPRA";
            // 
            // txt_Valor_Compra
            // 
            this.txt_Valor_Compra.Location = new System.Drawing.Point(163, 23);
            this.txt_Valor_Compra.Name = "txt_Valor_Compra";
            this.txt_Valor_Compra.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor_Compra.TabIndex = 1;
            this.txt_Valor_Compra.Leave += new System.EventHandler(this.txt_Valor_Compra_Leave);
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Location = new System.Drawing.Point(24, 60);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(74, 13);
            this.lbl_Descuento.TabIndex = 2;
            this.lbl_Descuento.Text = "DESCUENTO";
            // 
            // lbl_Descuento_Obtenido
            // 
            this.lbl_Descuento_Obtenido.AutoSize = true;
            this.lbl_Descuento_Obtenido.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Descuento_Obtenido.Location = new System.Drawing.Point(176, 60);
            this.lbl_Descuento_Obtenido.Name = "lbl_Descuento_Obtenido";
            this.lbl_Descuento_Obtenido.Size = new System.Drawing.Size(0, 13);
            this.lbl_Descuento_Obtenido.TabIndex = 2;
            this.lbl_Descuento_Obtenido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "VALOR DEL DESCUENTO";
            // 
            // lbl_Valor_Descuento
            // 
            this.lbl_Valor_Descuento.AutoSize = true;
            this.lbl_Valor_Descuento.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Valor_Descuento.Location = new System.Drawing.Point(176, 92);
            this.lbl_Valor_Descuento.Name = "lbl_Valor_Descuento";
            this.lbl_Valor_Descuento.Size = new System.Drawing.Size(0, 13);
            this.lbl_Valor_Descuento.TabIndex = 2;
            this.lbl_Valor_Descuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL";
            // 
            // lbl_Total_Con_Descuento
            // 
            this.lbl_Total_Con_Descuento.AutoSize = true;
            this.lbl_Total_Con_Descuento.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Total_Con_Descuento.Location = new System.Drawing.Point(176, 125);
            this.lbl_Total_Con_Descuento.Name = "lbl_Total_Con_Descuento";
            this.lbl_Total_Con_Descuento.Size = new System.Drawing.Size(0, 13);
            this.lbl_Total_Con_Descuento.TabIndex = 2;
            this.lbl_Total_Con_Descuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.Location = new System.Drawing.Point(27, 174);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(75, 23);
            this.btn_Comprar.TabIndex = 3;
            this.btn_Comprar.Text = "COMPRAR";
            this.btn_Comprar.UseVisualStyleBackColor = true;
            this.btn_Comprar.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(188, 174);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.lbl_Total_Con_Descuento);
            this.Controls.Add(this.lbl_Valor_Descuento);
            this.Controls.Add(this.lbl_Descuento_Obtenido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Descuento);
            this.Controls.Add(this.txt_Valor_Compra);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Valor_Compra;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.Label lbl_Descuento_Obtenido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Valor_Descuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Total_Con_Descuento;
        private System.Windows.Forms.Button btn_Comprar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}

