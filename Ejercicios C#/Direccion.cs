using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entrevista
{
    public class Direccion
    {
        string _calle;
        int _altura;
        string _codigoPostal;

        public Direccion()
        {
        }

        public Direccion(string calle, int altura, string codigoPostal)
        {
            _calle = calle;
            _altura = altura;
            _codigoPostal = codigoPostal;
        }

        public string calle
        {
            get { return _calle; }
            set { _calle = value; }
        }

        public int altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public string codigoPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }
    }
}
