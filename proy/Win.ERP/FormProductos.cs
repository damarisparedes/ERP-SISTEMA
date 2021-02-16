using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.ERP
{
    public partial class FormProductos : Form
    {
        ProductosServiciosBL _productos;

        public FormProductos()
        {
            InitializeComponent();
            _productos = new ProductosServiciosBL();

            listaProductosServiciosBindingSource.DataSource = _productos.obtenerProductosServicios();
        }
    }
}
