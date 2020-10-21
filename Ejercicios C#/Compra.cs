using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entrevista
{
    public class Compra
    {
        float _precioUnitario;
        string _articulo;
        int _cantidad;

        public Compra()
        {
        }

        public Compra(float precioUnitario, string articulo, int cantidad)
        {
            _precioUnitario = precioUnitario;
            _articulo = articulo;
            _cantidad = cantidad;
        }

        public float precioUnitario
        {
            get { return _precioUnitario; }
            set { _precioUnitario = value; }
        }

        public string articulo
        {
            get { return _articulo; }
            set { _articulo = value; }
        }

        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
    }
}
