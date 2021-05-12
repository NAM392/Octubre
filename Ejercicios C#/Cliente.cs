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

        public static void ClienteMasGasto(IList<Cliente> clients)
        {
            float ACUM = 0;
            float mayor = 0;
            Dictionary<Cliente, float> ClientesconGastos = new Dictionary<Cliente, float>();
            Cliente MiCliente = new Cliente();
            //recorro los clientes y los junto con sus gastos
            foreach (Cliente cl in clients)
            {
                foreach (var Buy in cl.compras)
                {
                    ACUM = ACUM + (Buy.precioUnitario * Buy.cantidad);
                }
                ClientesconGastos.Add(cl, ACUM);
                ACUM = 0;
            }
            //comparo entre la lista de clientes/total de gastos para encontrar el cliente que ms gasto
            foreach (KeyValuePair<Cliente, float> cg in ClientesconGastos)
            {
                if (mayor < cg.Value)
                {
                    MiCliente = cg.Key;
                    mayor = cg.Value;
                }
            }

            //muestro los datos del cliente que mas gasto

            Console.WriteLine("El cliente que mas gasto fue " + MiCliente.name + "\n");
            Console.WriteLine("DNI :  " + MiCliente.dni + "\n");
            Console.WriteLine("Sexo " + MiCliente.sexo + "\n");
            foreach (var tel in MiCliente.telefonos)
            {
                Console.WriteLine("Telefono " + tel.tipo + tel.numero + "\n ");
            }
            foreach (var dir in MiCliente.direcciones)
            {
                Console.WriteLine("Direccion : " + dir.calle + " " + dir.altura.ToString() + "\n ");
                Console.WriteLine("Codigo Postal : " + dir.codigoPostal + "\n ");
            }

            Console.WriteLine("Las compras realizadas fueron  : ");
            foreach (var compras in MiCliente.compras)
            {
                Console.WriteLine("Articulo : " + compras.articulo + "  Cantidad : " + compras.cantidad.ToString() + "  ;" + "Precio Unitario : $" + compras.precioUnitario.ToString());
            }

            Console.WriteLine(" \n con un gasto total de  : $" + mayor.ToString() + "\n");
        }

        public static void CajaRapida(IList<Cliente> clients)
        {
            int ACUM = 0;
            Dictionary<Cliente, int> ClientesconCantidad = new Dictionary<Cliente, int>();
            List<Cliente> ClientesCajaRapida = new List<Cliente>();
            //recorro los clientes y los junto con la cantidad de productos que compraron
            foreach (Cliente cl in clients)
            {
                foreach (var Buy in cl.compras)
                {
                    ACUM = ACUM + Buy.cantidad;
                }
                ClientesconCantidad.Add(cl, ACUM);
                ACUM = 0;
            }
            //comparo entre la lista de clientes/cantidad para encontrar los clientes que compraron <= 15 unidades
            foreach (KeyValuePair<Cliente, int> cg in ClientesconCantidad)
            {
                if (cg.Value <= 15)
                {
                    ClientesCajaRapida.Add(cg.Key);
                }
            }
            // muestro en panrtalla los clientes

            if(ClientesCajaRapida.Count == 0)
            {
                Console.WriteLine("No hay clientes que puedan acceder al beneficio de Caja Rapida");
            }
            else
            {
                Console.WriteLine("Los Clientes que podrian haber utilizado la caja rapida son : \n");
                foreach (var cj in ClientesCajaRapida)
                {
                    Console.WriteLine("DNI : " + cj.dni);
                    Console.WriteLine("Nombre : " + cj.name);
                    Console.WriteLine("\n");
                }
            }


        }
        public static void ClienteGastoDoble(IList<Cliente> clients)
        {
            float ACUM = 0;
            float total = 0;
            Dictionary<Cliente, float> ClientesconGastos = new Dictionary<Cliente, float>();
            Cliente MiCliente = new Cliente();
            //recorro los clientes y los junto con sus gastos
            foreach (Cliente cl in clients)
            {
                foreach (var Buy in cl.compras)
                {
                    ACUM = ACUM + (Buy.precioUnitario * Buy.cantidad);
                }
                ClientesconGastos.Add(cl, ACUM);
                ACUM = 0;
            }
            //comparo entre la lista de clientes/total de gastos para encontrar el cliente que gasto el doble o mas que el resto
            foreach (KeyValuePair<Cliente, float> cg in ClientesconGastos)
            {
                foreach (KeyValuePair<Cliente, float> cg2 in ClientesconGastos)
                {
                    if (cg.Key != cg2.Key)
                    {
                        if (cg.Value >= (cg2.Value * 2))
                        {
                            MiCliente = cg.Key;
                            total = cg.Value;
                        }
                    }
                }
            }

            //muestro los datos 

            if (!string.IsNullOrEmpty(MiCliente.name))
            {
                Console.WriteLine("El cliente que gasto el doble o mas que el resto fue " + MiCliente.name + "\n");
                Console.WriteLine("DNI :  " + MiCliente.dni + "\n");
                Console.WriteLine("Sexo " + MiCliente.sexo + "\n");
                foreach (var tel in MiCliente.telefonos)
                {
                    Console.WriteLine("Telefono Tipo: " + tel.tipo + " Numero : " + tel.numero + "\n ");
                }
                foreach (var dir in MiCliente.direcciones)
                {
                    Console.WriteLine("Direccion : " + dir.calle + " " + dir.altura.ToString() + "\n ");
                    Console.WriteLine("Codigo Postal : " + dir.codigoPostal + "\n ");
                }

                Console.WriteLine("Las compras realizadas fueron  : ");
                foreach (var compras in MiCliente.compras)
                {
                    Console.WriteLine("Articulo : " + compras.articulo + "  Cantidad : " + compras.cantidad.ToString() + "  ;" + "Precio Unitario : $" + compras.precioUnitario.ToString());
                }

                Console.WriteLine(" \n Habiendo aplicado el 50% de descuento su gasto total es de   : $" + (total / 2).ToString() + "\n");
            }
            else
            {
                Console.WriteLine("No hay cliente que hayan gastado el doble que el resto de los clientes");
            }
        }




























    }
}
