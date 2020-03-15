using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video
{
    class Factura : IPorPagar
    {
        private string numeroPieza;
        private string descripcionPieza;
        private int cantidad;
        private decimal precioPorArticulo;

        //contructor
        public Factura(string pieza, string descripcion, int cuenta, decimal precio)
        {
            numeroPieza = pieza;
            descripcionPieza = descripcion;
            cantidad = cuenta;
            precioPorArticulo = precio;
        }//fin constructor

        public string NumeroPieza
        {
            get
            {
                return numeroPieza;
            }
            set
            {
                numeroPieza = value;
            }
        }//fin propiedad NumeroPieza

        public string DescripcionPieza
        {
            get
            {
                return descripcionPieza;
            }
            set
            {
                descripcionPieza = value;
            }
        }//fin propiedad DescripcionPieza

        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }

        public decimal PrecioPorArticulo
        {
            get
            {
                return precioPorArticulo;
            }
            set
            {
                precioPorArticulo = value;
            }//fin propiedad PrecioPorArticulo
        }

            public override string ToString()
        {
            return string.Format(
                "{0}; \n{1}:{2} ({3}) \n{4}:{5} \n{6}: {7}:C",
                "Factura", "Numero de Pieza ", NumeroPieza, DescripcionPieza, "cantidad", Cantidad, "Precio Por Articulo", PrecioPorArticulo);
        }//fin metodo ToString

        public decimal ObtenerMontoAPagar()
        {
            return Cantidad * PrecioPorArticulo;
        }//fin metodo ObtenerMontoAPagar
    }
}
