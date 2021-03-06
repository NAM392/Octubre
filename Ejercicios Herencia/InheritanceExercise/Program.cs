using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            PizzaMozzarella pzm = new PizzaMozzarella(8, "Anana", "La Paulina");
            PizzaDobleMozzarella pzdm = new PizzaDobleMozzarella(12, "Jamon", "Barraza", (float)40.1);
            Pizza pizza = new Pizza(23, "Cebolla");
            //prepara masa de PizzaMozzarella
            pzm.PreparaMasa();
            //prepara masa de PizzaDobleMozzarella
            pzdm.PreparaMasa((float)44);
            //prepara masa Pizza
            pizza.PreparaMasa();
            pizza.PreparaMasa((float) 36);

            Console.ReadKey();


        }
        //1. Crear una clase que herede de la clase System.Object
        class ClaseHeredera : System.Object
        {

        }

        //2. Crear una clase que herede de la clase System.Object pero sin usar las palabras System.Object, Object o object

        class Clase2
        {
            //todas las clases dentro de C# heredan implicitamente de System.Object 
        }

        class Clase22 : ClaseHeredera
        {
            //otra manera de heredar sin poner explicitamente es heredando de una clase que ya hereda System.Object 
        }


        //3. Crear una clase Pizza con las propiedades publicas: CantidadPorciones (int), Ingredientes (string) 

        class Pizza : IPizza
        {
            public int CantidadPorciones;
            public string Ingredientes;
            public Pizza(int cant, string ing)
            {
                CantidadPorciones = cant;
                Ingredientes = ing;
            }

            public int cantidadPorciones
            {
                get { return CantidadPorciones; }
                set { CantidadPorciones = value; }
            }
            public string ingrediente
            {
                get { return Ingredientes; }
                set { Ingredientes = value; }

            }




            //5. Agregary el metodo publico PrepararMasa (no devuelve parametros, recibe la cantidad en gramos de harina a utilizar)
            //El metodo solo deve mostrar "lo que hace" en un mensaje por consola

            public virtual void PreparaMasa(float cantidad_gramos)
            {
                Console.WriteLine("lo que hace  con " + cantidad_gramos.ToString() + " gr de harina ");

            }

            //6. Hacer una sobrecarga del metodo PrepararMasa que no reciba parametros y que solamente llame al otro metodo PrepararMasa, pasandole un valor por defecto


            public virtual void PreparaMasa()
            {
                float gramos = (float)12.5;
                PreparaMasa(gramos);

            }

        }

        // 7. Crear una clase PizzaMozzarella que herede de la clase Pizza
        //8. Al crearse un objeto de la clase PizzaMozzarella siempre deben establecerse los valores para CantidadPorciones e Ingredientes (Pista: usar constructor)
        class PizzaMozzarella : Pizza
        {
            public string muzzarella;
            public PizzaMozzarella(int cantidad, string ingredientes, string muzza) : base(cantidad, ingredientes)
            {
                muzzarella = muzza;
            }
            public virtual string Cheese
            {
                get { return muzzarella; }
                set { muzzarella = value; }
            }

            //9. Hacer que los metodos de la clase PizzaMozzarella tengan un funcionamiento interno diferente al de Pizza (que muestre mensajes diferentes)

            public override void PreparaMasa(float cantidad_gramos)
            {
                Console.WriteLine("usamos el doble de harina " + (cantidad_gramos * 2).ToString()+ " "+ muzzarella +" " + Ingredientes);

            }

        }

       


        //10.  Crear una clase PizzaDobleMozzarella que herede de la clase PizzaMozzarella.
        //Al crear un objeto de la clase PizzaDobleMozzarella siempre se deben establecerse los valores para CantidadPorciones e Ingredientes (Pista: usar constructor)
        //Deben ser diferentes a los valores que se establecen al crear la clase PizzaMozzarella

        class PizzaDobleMozzarella : PizzaMozzarella
        {

            private float MuzzaExtra;
            private int Quantity;
            private string Ingredients;
            private string Quesos;
            public PizzaDobleMozzarella(int cantidad, string ingredientes, string muzza, float AdicionMuzza) : base(cantidad, ingredientes, muzza)
            {

                MuzzaExtra = AdicionMuzza;
                Quantity = cantidad;
                Ingredients = ingredientes;
                Quesos = muzza;
            }
            public float Extra
            {
                get { return MuzzaExtra; }
                set { MuzzaExtra = value; }
            }


        }

          //11. Crear una interfaz IPizza que defina los metodos y propiedades publicos de la clase Pizza. Pizza debe implementar dicha interfaz

        interface IPizza
        {
            void PreparaMasa();
            void PreparaMasa(float cant);


        }

        //12. Hacer que la clase Pizza se abstracta

        /*
            abstract class Pizza
            {
                protected int CantidadPorciones;
                protected string Ingredientes;

                public abstract void PreparaMasa();
                public abstract void PreparaMasa(float cant);



            }



        */


    }


}


