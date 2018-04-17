using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESCUENTOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Valor_Compra_Leave(object sender, EventArgs e)
        {
            int desc = 0;
            int valorCompra = int.Parse(txt_Valor_Compra.Text);

            if (valorCompra < 100000)
            {
                desc = 0;
                lbl_Descuento_Obtenido.Text = desc.ToString() + "%";
                lbl_Valor_Descuento.Text = "Ninguno";
                lbl_Total_Con_Descuento.Text = valorCompra.ToString();
            }
            else if (valorCompra > 100000 || valorCompra < 200000)
            {
                desc = 5;
                lbl_Descuento_Obtenido.Text = desc.ToString() + "%";
                lbl_Valor_Descuento.Text = ((desc * valorCompra) / 100).ToString();
                lbl_Total_Con_Descuento.Text = (valorCompra - int.Parse(lbl_Valor_Descuento.Text)).ToString();
            }
            if (valorCompra > 200000)
            {
                desc = 10;
                lbl_Descuento_Obtenido.Text = desc.ToString() + "%";
                lbl_Valor_Descuento.Text = ((desc * valorCompra) / 100).ToString();
                lbl_Total_Con_Descuento.Text = (valorCompra - int.Parse(lbl_Valor_Descuento.Text)).ToString();
            }

            

        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("COMPRA REGISTRADA CON EL DESCUENTO OBTENIDO");
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
