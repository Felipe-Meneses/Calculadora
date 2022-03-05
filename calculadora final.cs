using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_repeticao
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        /* Declarar que o inicio começa em 1 */
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) // Enquanto o usuário NÃO (!) ESCOLHER SAIR EXIBA O MENU (!=igual ou diferente)
            {
                // Exiba o menu
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                //menu//
                
                
                switch (opcao)
                {
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                }
                Console.Clear();  // apagar sempre que finalizar//
            }

            
        }

        static void Soma()  
        {
            Console.WriteLine("Soma de dois numeros:");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é:{resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Sub()
        {
            Console.WriteLine("Subtração de dois numeros:");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é:{resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Div()
        {
            Console.WriteLine("Divisão de dois numeros:");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a/(float)b; //Modo de ter numeros completos\\
            Console.WriteLine($"O resultado é:{resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Mult()
        {
            Console.WriteLine("Multição de dois numeros:");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é:{resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Pot()
        {   
            // 2^4 = 2*2*2*2 = 16 (potencia)//
            Console.WriteLine("Potência de dois numeros:");
            Console.WriteLine("Digite a base:");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);     // float, double, decimal (Math//
            Console.WriteLine($"O resultado é:{resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero:");
            Console.WriteLine("Digite o numero:");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a); // Square Root //
            Console.WriteLine($"O resultado é:{resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }


    }
}
