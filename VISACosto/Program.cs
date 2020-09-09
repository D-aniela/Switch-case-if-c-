using System;

namespace VISACosto
{
    class datos
    {
        public string ObtenerNombreCompleto(string nombre, string apellidos)
        {
            string nombreCompleto = string.Empty;
            nombreCompleto = nombre + " " + apellidos;
            return nombreCompleto;
        }

        public int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            return edad;
        }
    }
    class Program
    {
          static void Main(string[] args)
        {
            datos cliente = new datos();

            string nombre, apellidos;
            int tipo, vigencia;
            Boolean requisitos;
            DateTime fechaNac;

            Console.WriteLine("Ingrese nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellidos");
            apellidos = Console.ReadLine();

            Console.WriteLine("Indique la fecha de nacimiento (dd/mm/aaaa): ");
            fechaNac = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(cliente.ObtenerNombreCompleto(nombre, apellidos));
            Console.WriteLine(cliente.CalcularEdad(fechaNac) + " años");
            int edad = cliente.CalcularEdad(fechaNac);

            Console.Write("Seleccione una opción");

            if(edad > 15)
            {
            Console.WriteLine("Tipo: 1=Turista, 2=Petición, 3=Empresarial");
            string eleccion = Console.ReadLine();
            int valor = Convert.ToInt32(eleccion);
            switch (valor)
            {
                case 1:
                    Console.WriteLine("Escoja periodo: 1=1 mes, 2=10 años");
                    string select = Console.ReadLine();
                    tipo = Convert.ToInt32(select);
                    switch (tipo)
                    {
                        case 1:
                            Console.WriteLine("Tiene tipo turista con un periodo de un mes y un precio de $320 pesos");
                            break;
                        case 2:
                            Console.WriteLine("Tiene tipo turista con un periodo de 10 años y un costo de $3 200 pesos");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Escoja periodo: 1=6 meses, 2=1 año");
                    string select2 = Console.ReadLine();
                    tipo = Convert.ToInt32(select2);
                    switch (tipo)
                    {
                        case 1:
                            Console.WriteLine("Tiene tipo petición con un periodo de 6 meses y un precio de $3 800 pesos");
                            break;
                        case 2:
                            Console.WriteLine("Tiene tipo petición con un periodo de 1 año y un costo de $3 800 pesos");
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("Escoja periodo: 1=1 mes, 2=1 año");
                    string select3 = Console.ReadLine();
                    tipo = Convert.ToInt32(select3);
                    switch (tipo)
                    {
                        case 1:
                            Console.WriteLine("Tiene tipo empresarial con un periodo de 1 mes");
                            break;
                        case 2:
                            Console.WriteLine("Tiene tipo empresarial con un periodo de 1 año y un costo de $4 100 pesos");
                            break;
                    }
                    break;

                case 4:
                    Console.WriteLine("Escoja periodo: 1=1 mes, 2=15 años");
                    string select4 = Console.ReadLine();
                    tipo = Convert.ToInt32(select4);
                    switch (tipo)
                    {
                        case 1:
                            Console.WriteLine("Tiene tipo turista con un periodo de un mes y un precio de $320 pesos");
                            break;
                        case 2:
                            Console.WriteLine("Tiene tipo turista con un periodo de 15 años y un costo de $3 200 pesos");
                            break;
                    }
                    break;
            }

            }
            else
            {
                Console.WriteLine("Escoja periodo: 1=1 mes, 2=10 años");
                string eleccion = Console.ReadLine();
                int valor = Convert.ToInt32(eleccion);
                switch (valor)
                {
                    case 1:
                        Console.WriteLine("Tiene tipo turista con un periodo de un mes y un precio de $320 pesos");
                        break;
                    case 2:
                        Console.WriteLine("Tiene tipo turista con un periodo de 10 años y un costo de $3 200 pesos");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
