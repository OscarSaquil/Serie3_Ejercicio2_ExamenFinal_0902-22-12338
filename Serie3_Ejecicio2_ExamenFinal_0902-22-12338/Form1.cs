using Entidad;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Serie3_Ejecicio2_ExamenFinal_0902_22_12338
{
    
    public partial class Form1 : Form
    {
        NegocioBD objNegocio = new NegocioBD();
        Producto objProducto = new Producto();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            

        }
    }
}
