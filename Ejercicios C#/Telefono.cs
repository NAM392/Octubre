using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entrevista
{
    public class Telefono
    {
        string _numero;
        string _tipo;

        public Telefono()
        {
        }

        public Telefono(string numero, string tipo)
        {
            _numero = numero;
            _tipo = tipo;
        }

        public string numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }
}
