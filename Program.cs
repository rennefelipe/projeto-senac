using ConsoleApp1.classes;
using System;

namespace Console_Entrada_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            passos opassos = new passos();
        Rotulo_retorno:
            Console.WriteLine("Informe o seu animal: ");
            Console.Write("Digite: ");
            String Animal= Console.ReadLine();
            
            if (Animal.ToLower() == "cachorro" || Animal.ToLower() == "gato" || Animal.ToLower() == "cavalo" )
            { }
            else
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(" **** Informe o animal Corretamente ****");
                Console.WriteLine("!! Cachorro, Gato, Cavalo !!");
                Console.WriteLine("-------------------------------------");
                goto Rotulo_retorno;
            }
            Rotulo_retorno_passos:
            Console.WriteLine("Informe de 1 a 6 para o animal andar: ");
            Console.Write("Digite: ");
            String Passos = Console.ReadLine();

            if (Passos == "1" || 
                Passos == "2" || 
                Passos == "3" || 
                Passos == "4" || 
                Passos == "5" || 
                Passos == "6")
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(" **** seu animal " + Animal + " esta  correndo a " + Passos + " KM/H imagine ****");

                opassos.andar(int.Parse(Passos));


                Console.WriteLine("     ('_') ███████▄▄▄▄▄▄▄▄ ****************** ");
                Console.WriteLine("  ▄▅█████████▅▄▃             ");
                Console.WriteLine("███████████████████.         ");
                Console.WriteLine("  ◥@▲@▲@▲@▲@▲@▲@◤...          ");
                Console.WriteLine("!! RUN !!");
                Console.WriteLine("-------------------------------------");
            }
            else
            {
                Console.WriteLine("Erro valor invalido");
                goto Rotulo_retorno_passos;
            }

        }
    }
}
