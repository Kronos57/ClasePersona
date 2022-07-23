using System;

namespace ClasePersona
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(27, "3214587984", "Juanita Gutierrez", 25000000.57);
            cliente.ImprimirCliente();

            Trabajador trabajador = new Trabajador(25, "Miguel Saavedra", "7441285", 9500000.35);
            trabajador.ImprimirTrabajador();
        }
    }

    class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }

    class Cliente : Persona
    {
        public double Credito { get; set; }

        public Cliente()
        {

        }

        public Cliente(int edad, string nombre, string telefono, double credito)
        {
            this.Edad = edad;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Credito = credito;
        }

        public void ImprimirCliente()
        {
            Console.WriteLine("Edad: " + this.Edad);
            Console.WriteLine("Teléfono: " + this.Telefono);
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Crédito: " + this.Credito + "\n");
        }
    }

    class Trabajador : Persona
    {
        public double Salario { get; set; }

        public Trabajador()
        {

        }

        public Trabajador(int edad, string nombre, string telefono, double salario)
        {
            this.Edad = edad;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Salario = salario;
        }

        public void ImprimirTrabajador()
        {
            Console.WriteLine("Edad: " + this.Edad);
            Console.WriteLine("Teléfono: " + this.Telefono);
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Salario: " + this.Salario + "\n");
        }
    }
}
