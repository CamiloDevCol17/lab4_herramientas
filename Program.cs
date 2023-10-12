using System;

namespace laboratorio_4
{
    //se crea la clase Rectangulo con sus metodos Ancho y Alto y un metodo para acalcular area y otro el perimetro
    class Rectangulo
    {
        public float Ancho { get; set;}
        public float Alto { get; set; }
        //constructor Rectangulo
        public Rectangulo(float Ancho, float Alto)
        {
            this.Ancho = Ancho; 
            this.Alto = Alto;
            
        }
        public float Perimetro()
        {
            return 2*(Ancho+Alto);
        }
        public float Area()
        {
            return Ancho * Alto;
        }
    }
    class Avion
    {
        //clase avion con metodos modelo, capacidad de pasajeros y velocidad max
        //co  metodo mostrar_info del avion, crear programa que permita
        //ingresar varios aviones mediangte un bucle y muestrem la info

        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public float Velocidad_Maxima { get; set; }


        //crear constructos con 3 parametros
        public Avion(string modelo, int capacidad, float velocidad_maxima)
        {
            Modelo = modelo;
            Capacidad = capacidad;
            Velocidad_Maxima = velocidad_maxima;
        }
        //creamos el metodo mostrar_info 
        public void Mostra_info()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Capacidad de Pasajeros: {Capacidad}");
            Console.WriteLine($"Velocidad Máxima: {Velocidad_Maxima} km/h");
            Console.WriteLine();
        }
        
    }
    class Factura
    {
        //crear clase Factura, con propiedades numero factura, fehca y lista
        //de productos comprados, agregar metodo para calcular total factura
        //el usuario ingresara info de varias facturas, calcular tottal de cada factura

        public int Numero_factura { get; set; }
        public string Fecha_factura { get; set; }
        public double[] Productos_comprados { get; set; }

        //constructor factura
        public Factura(int numero_factura, string fecha_factura, double[] productos_comprados)

    }

    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("" +
                "\n---------MENU DE OPCIONES---------\n" +
                "1).Clase Rectangulo\n" +
                "2).Clase Avion\n" +
                "3).Clase Factura\n" +
                "4).Clase Mascota\n" +
                "5).Clase Pelota\n\nIngresa una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Rectangulo();
                    break;
                case 2:
                    Aviones();
                    break;
            }






        }
        public static void Rectangulo()
        {
            Console.WriteLine("Ingrese el ancho del rectangulo: ");
            float ancho = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el largo del rectangulo: ");
            float largo = float.Parse(Console.ReadLine());
            //crear instancias de la clase Rectangulo
            Rectangulo rectangulo = new Rectangulo(ancho, largo);

            //mostrar resultados
            Console.WriteLine("Rectangulo: ");
            Console.WriteLine($"Area: {rectangulo.Area()}");
            Console.WriteLine($"Perimetro: {rectangulo.Perimetro()}");
            Console.WriteLine();


            Console.ReadKey();
        }
        public static void Aviones()
        {
            int n_Aviones;

            Console.WriteLine("Ingrese la cantidad de aviones: ");
            //creamos el arreglo llamado aviones de la case Avion y el total de veces sera la cantidad de aviones
            n_Aviones = int.Parse(Console.ReadLine());
            Avion[] aviones = new Avion[n_Aviones];

            for(int i = 0; i<n_Aviones; i++)
            {
                Console.WriteLine($"\nIngresa la informacion del avion {i + 1} : ");

                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();

                Console.Write("Capacidad de pasajeros: ");
                int capacidad = int.Parse(Console.ReadLine());

                Console.Write("Velocidad maxima: ");
                float velocidad_maxima = float.Parse(Console.ReadLine());

                aviones[i] = new Avion(modelo, capacidad, velocidad_maxima);
            }

            Console.WriteLine("\nInformacion de los aviones");
            foreach(var avion in aviones)
            {
                avion.Mostra_info();
            }

        }
        
        
    }
}