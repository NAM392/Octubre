using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entrevista
{
    public class Cliente : Persona
    {
        IList<Compra> _compras;

        public Cliente()
        {
        }

        public Cliente(IList<Compra> compras, string name, int dni, char sexo, IList<Direccion> direcciones, IList<Telefono> telefonos)
        : base(name, dni, sexo,  direcciones,  telefonos)
        {
            _compras = compras;
        }

        public IList<Compra> compras
        {
            get { return _compras; }
            set { _compras = value; }
        }
    }
}
