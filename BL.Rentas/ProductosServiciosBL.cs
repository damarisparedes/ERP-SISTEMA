using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class ProductosServiciosBL
    {
        public BindingList<ProductosServicios>ListaProductosServicios { get; set; }
        public ProductosServiciosBL()
        {
            ListaProductosServicios = new BindingList<ProductosServicios>();
            var producto1 = new ProductosServicios();
            producto1.Codigo = 000001;
            producto1.Descripcion = "Kit de Camaras";
            producto1.Precio = 2400;
            producto1.Costo = 3200;
            producto1.Existencias = 6000;
            producto1.Activos = true;

            ListaProductosServicios.Add(producto1);

            var producto2 = new ProductosServicios();
            producto2.Codigo = 000002;
            producto2.Descripcion = "Camara wifi";
            producto2.Precio = 23110;
            producto2.Costo = 1100;
            producto2.Existencias = 555;
            producto2.Activos = true;

            ListaProductosServicios.Add(producto2);

            var producto3 = new ProductosServicios();
            producto3.Codigo = 000003;
            producto3.Descripcion = "Intalacion de Camaras";
            producto3.Precio = 111100;
            producto3.Costo = 3200;
            producto3.Existencias = 1005;
            producto3.Activos = true;

            ListaProductosServicios.Add(producto3);

            var producto4 = new ProductosServicios();
            producto4.Codigo = 000004;
            producto4.Descripcion = "Intalacion de Camaras portatiles ";
            producto4.Precio = 3500;
            producto4.Costo = 500;
            producto4.Existencias = 1805;
            producto4.Activos = true;

            ListaProductosServicios.Add(producto4);

        }

        public BindigList<ProductosServicios> obtenerProductosServicios ()
        {
            return ListaProductosServicios;
        }


        public class ProductosServicios
        {
            public bool Activos { get; internal set; }
            public int Codigo { get; internal set; }
            public int Costo { get; internal set; }
            public string Descripcion { get; internal set; }
            public int Existencias { get; internal set; }
            public int Precio { get; internal set; }
        }

        public int Codigo { get; set; }
        public string Descrpcion { get; set; }
        public bool Tipo { get; set; }
        public double Costo { get; set; } 
        public double Precio { get; set; }
        public int Existencias { get; set; }
        public bool Activo { get; set; }

    }
}
