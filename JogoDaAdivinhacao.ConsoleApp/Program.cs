using System.Numerics;

namespace JogoDaAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine("###################");
                Console.WriteLine("Jogo da Adivinhação");
                Console.WriteLine("###################\n");

                //escolha de dificuldade
                Console.WriteLine("Escolha o nível de dificuldade: ");
                Console.WriteLine("1 - Fácil (10 tentativas)");
                Console.WriteLine("2 - Normal (5 tentativas)");
                Console.WriteLine("3 - Difícil (2 tentativas)");

                int totalDeTentativas = 0;

                Console.Write("Digite sua escolha de dificuldade: ");
                string opcaoDificuldade = Console.ReadLine();


                if (opcaoDificuldade == "1")
                    totalDeTentativas = 10;
                else if (opcaoDificuldade == "2")
                    totalDeTentativas = 5;
                else if (opcaoDificuldade == "3")
                    totalDeTentativas = 2;
                else
                {
                    Console.WriteLine("Escolha uma opção válida");
                    break;
                }


                    //numero aleatorio
                    Random geradorNumeros = new Random();
                int numeroSecreto = geradorNumeros.Next(1, 21);

                //tentativas
                for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
                    Console.WriteLine("-------------------------------------------------");




                    //logica
                    Console.Write("Digite um número: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine($"Você acertou o número secreto em {totalDeTentativas} tentativas! Parabéns!");
                        Console.WriteLine("-------------------------------------------------");

                        break;


                    }

                    if (tentativa == totalDeTentativas)
                    {
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Que pena! Voce nao conseguiu acertar. O numero secreto era " + numeroSecreto);
                        Console.WriteLine("----------------------------------------------------");

                        break;
                    }

                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("O número digitado é maior que o número secreto!");
                        Console.WriteLine("-------------------------------------------------");
                    }
                    else if (numeroDigitado < numeroSecreto)
                    {
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("O número digitado é menor que o número secreto!");
                        Console.WriteLine("-------------------------------------------------");
                    }
                }

                    Console.Write("Deseja continuar? [S/N]");
                    string opcaoContinuar = Console.ReadLine().ToUpper(); //string para textos, int para numeros

                    if (opcaoContinuar != "S")
                        break;
                
            }
        }
    }
}
