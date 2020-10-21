using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entrevista
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Cliente> clientes = cargarDatosIniciales();

            // 1) Desarrollar un método que reciba la lista de clientes y retorne el cliente que más gastó. Mostrar sus datos en pantalla.


            // 2) Desarrollar un método que reciba la lista de clientes y retorne cuántos de ellos podrían haber aprovechado una caja rápida
            // (máximo de 15 unidades) si la hubiera. Mostrar resultado por pantalla.                        


            // 3) Desarrollar un método que permita conocer si algún cliente gastó por lo menos el doble que cada uno de los otros clientes,
            // ya que en dicho caso se le otorgará un descuento del 50% en todos sus productos.
            // Mostrar por pantalla el cliente y el monto total del descuento que recibiría.
            

        }

        #region Datos Iniciales

        static IList<Cliente> cargarDatosIniciales()
        {
            IList<Cliente> rv = new List<Cliente>();

            // Cliente 1            
            IList<Direccion> direcciones = new List<Direccion>();
            IList<Telefono> telefonos = new List<Telefono>();
            IList<Compra> compras = new List<Compra>();                       
            direcciones.Add(new Direccion("Zapiola", 345, "1756"));           
            telefonos.Add(new Telefono("456456", "Personal"));
            compras.Add(new Compra((float)8.5, "Gaseosa", 6));
            compras.Add(new Compra((float)4.5, "Leche", 4));
            compras.Add(new Compra((float)4, "Puré de tomate", 6));
            rv.Add(new Cliente(compras,"Carlos Ponce",4568765,'M',direcciones,telefonos));

            // Cliente 2            
            direcciones = new List<Direccion>();
            telefonos = new List<Telefono>();
            compras = new List<Compra>();
            direcciones.Add(new Direccion("Rincon", 3298, "1562"));
            telefonos.Add(new Telefono("47632143", "Laboral"));
            compras.Add(new Compra((float)6, "Queso", 1));
            compras.Add(new Compra((float)1.4, "Jugo", 5));
            compras.Add(new Compra((float)5.7, "Fideos", 2));
            compras.Add(new Compra((float)5, "Chocolate", 2));
            rv.Add(new Cliente(compras, "Ana Lopez", 10965283, 'F', direcciones, telefonos));

            // Cliente 3
            direcciones = new List<Direccion>();
            telefonos = new List<Telefono>();
            compras = new List<Compra>();
            direcciones.Add(new Direccion("Belgrano", 234, "4790"));
            telefonos.Add(new Telefono("476384", "Personal"));
            compras.Add(new Compra((float)6, "Yogourt", 1));
            compras.Add(new Compra((float)7, "Azucar", 1));
            rv.Add(new Cliente(compras, "Pedro Nieva", 23098789, 'M', direcciones, telefonos));

            // Cliente 4
            direcciones = new List<Direccion>();
            telefonos = new List<Telefono>();
            compras = new List<Compra>();
            direcciones.Add(new Direccion("Alsina", 256, "2387"));
            telefonos.Add(new Telefono("46576343", "Personal"));
            compras.Add(new Compra((float)6, "Arroz", 5));
            compras.Add(new Compra((float)7, "Pochoclo", 10));
            compras.Add(new Compra((float)6, "Queso", 3));
            compras.Add(new Compra((float)7, "Flan", 8));
            compras.Add(new Compra((float)6, "Galletitas", 4));
            compras.Add(new Compra((float)7, "Pasta dental", 9));
            rv.Add(new Cliente(compras, "Ramona Gomez", 8723983, 'F', direcciones, telefonos));

            return rv;
        }

        #endregion

    }
}
