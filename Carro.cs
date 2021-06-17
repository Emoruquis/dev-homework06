using System;

namespace dev_homework06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Hola buenos dias bienvenido a la distribuidora de autos RODRIGUEZ");
            Console.WriteLine("\n");
            Console.WriteLine("Comenzaremos con el proceso para la compra del auto");
            Console.WriteLine("\n");
            Console.WriteLine("¿Que modelo desea?, ¿AudiA3 o BMWSerie1?");
            var auto = Console.ReadLine();
            Console.WriteLine("De que color quiere sus interiores, ¿blanco o negro?");
            var color = Console.ReadLine();
            Console.WriteLine("De que color quiere sus interiores, ¿rojos o negros?");
            var interior = Console.ReadLine();
            Console.WriteLine("como quiere su transmision, ¿manual o automatico?");
            var transmision = Console.ReadLine();
            string[] carro = new string[4];

            if(auto == "AudiA3"){
                carro[0] = "AudiA3";
            }
            else if(auto == "BMWSerie1"){
                carro[0] = "BMWSeries1";
            }

            if(color == "blanco"){
                carro[1] = "blanco";
            }

            else if(color == "negro"){
                carro[1] = "negro";
            }

            if(interior == "rojos"){
                carro[2] = "rojos";
            }

            else if(interior == "negros"){
                carro[2] = "negros";
            }

            if(transmision == "manual"){
                carro[3] = "manual";
            }

        
            Console.WriteLine("\n");
            Console.WriteLine("¡Listo! A terminado de configurar su carro");
            Console.WriteLine("Aqui abajo esta su recibo");

            Console.WriteLine("\n");
            Console.WriteLine($"Modelo: {carro[0]}");
            Console.WriteLine($"Color: {carro[1]}");
            Console.WriteLine($"Interior: {carro[2]}");
            Console.WriteLine($"Transmision: {carro[3]}");
            Console.WriteLine("\n");

        }
    }
}
