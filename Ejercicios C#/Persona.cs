using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entrevista
{
    public class Persona
    {
        string _name;
        int _dni;
        char _sexo;
        IList<Direccion> _direcciones;
        IList<Telefono> _telefonos;

        public Persona()
        {
        }

        public Persona(string name, int dni, char sexo, IList<Direccion> direcciones, IList<Telefono> telefonos)
        {
            _name = name;
            _dni = dni;
            _sexo = sexo;
            _direcciones = direcciones;
            _telefonos = telefonos;
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public char sexo
        {
            get { return _sexo;}
            set { _sexo = value; }
        }

        public IList<Direccion> direcciones
        {
            get { return _direcciones; }
            set { _direcciones = value; }
        }

        public IList<Telefono> telefonos
        {
            get { return _telefonos; }
            set { _telefonos = value; } 
        }

    }
}
