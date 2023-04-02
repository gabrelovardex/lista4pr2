using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace lista4pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float MENU;

            Console.WriteLine("==========MENU==========");
            Console.WriteLine("1- exercicio 1");
            Console.WriteLine("2- exercicio 2");
            Console.WriteLine("3- exercicio 3");
            Console.WriteLine("4- exercicio 4");
            Console.WriteLine("5- exercicio 5");
            Console.WriteLine("6- exercicio 6");
            Console.WriteLine("7- exercicio 7");
            Console.WriteLine("8- exercicio 8");
            Console.WriteLine("========================");

            MENU = float.Parse(Console.ReadLine());

            switch (MENU)
            {
                case 1:

                    Console.WriteLine("a afirmaçao é falsa pois é possível atribuir uma variavel tipo int em uma variavel float, mas não é possível atribuir uma variavel float em uma variavel tipo int.");

                    break;

                case 2:

                    Console.WriteLine("O Console.Read(); serve apenas para ler um caracter, já o Console.ReadLine(); serve para ler uma linha inteira, e retorna o valor em string.");

                    break;

                case 3:

                    Console.WriteLine("Precisamos tomar o cuidado de colocarmos o parse para mudar a variavel");

                    break;

                case 4:

                    int num, num2, num3;
                    Console.WriteLine("Entre com um número: ");
                    num = int.Parse(Console.ReadLine());
                    num2 = num / 2;
                    num3 = num % 2;
                    if (num3 == 0 && num2 * 2 > 10)
                        Console.WriteLine("Mensagem 1");
                    else
                        Console.WriteLine("Mensagem 2");
                    // serve para saber se o resto do numero por 2 é 0, se for, aparecerá mensagem 1, se não aparecerá mensagem 2
                    break;

                case 5:

                    double PI, VC, T, PF;

                    Console.WriteLine("DIGITE O VALOR DA POSIÇÃO INICIAL: ");
                    PI = double.Parse(Console.ReadLine());
                   
                    Console.WriteLine("DIGITE O VALOR DA VELOCIDADE CONSTANTE: ");
                    VC = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("DIGITE O VALOR DO DESLOCAMENTO: ");
                    T = double.Parse(Console.ReadLine());
                   
                    PF = PI + (VC * T);
                    
                    Console.WriteLine("A POSIÇÃO FINAL É:  " + PF);

                    break;

                case 6:

                    int NUMEINT;

                    Console.WriteLine("DIGITE UM NÚMERO INTEIRO:");
                    NUMEINT = int.Parse(Console.ReadLine());

                    if(((NUMEINT % 3) == 0) && ((NUMEINT & 5 ) == 0) && ((NUMEINT % 10) == 0))
                    Console.WriteLine("O NUMERO É DIVÍSIVEL POR 3, 5 E 10");

                    else if (((NUMEINT % 3) == 0) && ((NUMEINT % 5) == 0))
                    Console.WriteLine("O NÚMERO É DIVÍSIVEL POR 3 E 5");

                    else if ((NUMEINT % 3) == 0)
                    Console.WriteLine("O NÚMERO É DIVÍSIVEL POR 3");

                    else if ((NUMEINT % 5) == 0)
                    Console.WriteLine("O NÚMERO É DIVÍSIVEL POR 5");

                    else 
                    Console.WriteLine("O NÚMERO NÃO É DIVÍSIVEL POR NENHUM DOS NÚMEROS ACIMA");

                  

                    break;

                case 7:


                    break;

                case 8:

                    
                    double SACOS, QUANTI, IMPOSTO, CUSTO, LUCRO;
                    string MARCA;

                    Console.WriteLine("DIGITE O NÚMERO DE SACOS DE RAÇÃO: ");
                    SACOS = int.Parse(Console.ReadLine());

                    Console.WriteLine("ESCOLHA UMA DAS MARCAS ABAIXO: ");

                    Console.WriteLine("==========MENU==========");
                    Console.WriteLine("1 - ROYAL");
                    Console.WriteLine("2 - WISKAS");
                    Console.WriteLine("3 - GOLDEN");
                    Console.WriteLine("4 - NUTRIEN");
                    Console.WriteLine("5 - SPECIALCAT");
                    Console.WriteLine("6 - MARBA");
                    Console.WriteLine("7 - GATUS");
                    Console.WriteLine("========================");

                    
                    MARCA = Console.ReadLine();

                    switch (MARCA)
                    {
                        case 1:

                            QUANTI = 129.50 * SACOS;

                            CUSTO = QUANTI * 0.775;

                            CUSTO = QUANTI - CUSTO;

                            IMPOSTO = CUSTO * 0.33;

                            LUCRO = (QUANTI - CUSTO) - IMPOSTO;

                            Console.WriteLine("O LUCRO É: " + LUCRO);

                            break;

                        case 2:

                            QUANTI = 182.78 * SACOS;

                            CUSTO = QUANTI * 0.897;

                            CUSTO = QUANTI - CUSTO;

                            IMPOSTO = CUSTO * 0.275;

                            LUCRO = (QUANTI - CUSTO) - IMPOSTO;

                            Console.WriteLine("O LUCRO É: " + LUCRO);

                            break;

                        case 3:

                            QUANTI = 144.80 * SACOS;

                            CUSTO = QUANTI * 0.889;

                            CUSTO = QUANTI - CUSTO;

                            IMPOSTO = CUSTO * 0.25;

                            LUCRO = (QUANTI - CUSTO) - IMPOSTO;

                            Console.WriteLine("O LUCRO É:  " + LUCRO);

                            break;

                        case 4:

                            QUANTI = 159.46 * SACOS;

                            CUSTO = QUANTI * 0.717;

                            CUSTO = QUANTI - CUSTO;

                            IMPOSTO = CUSTO * 0.225;

                            LUCRO = (QUANTI - CUSTO) - IMPOSTO;

                            Console.WriteLine("O LUCRO É: " + LUCRO);

                            break;

                        case 5:

                            QUANTI = 205.40 * SACOS;

                            CUSTO = QUANTI * 0.8224;

                            CUSTO = QUANTI - CUSTO;

                            IMPOSTO = CUSTO * 0.22;

                            LUCRO = (QUANTI - CUSTO) - IMPOSTO;

                            Console.WriteLine("O LUCRO É: " + LUCRO);

                            break;

                        case 6:

                            QUANTI = 125.10 * SACOS;

                            CUSTO = QUANTI * 0.904;

                            CUSTO = QUANTI - CUSTO;

                            IMPOSTO = CUSTO * 0.179;

                            LUCRO = (QUANTI - CUSTO) - IMPOSTO;

                            Console.WriteLine("O LUCRO É: " + LUCRO);

                            break;

                        case 7:

                            QUANTI = 133.99 * SACOS;

                            CUSTO = QUANTI * 0.946;

                            CUSTO = QUANTI - CUSTO;

                            IMPOSTO = CUSTO * 0.20;

                            LUCRO = (QUANTI - CUSTO) - IMPOSTO;

                            Console.WriteLine("O LUCRO É: " + LUCRO);

                            break;

                        default:
                            Console.WriteLine("Opção Invalida");
                            break;







                    }
              
               Console.ReadKey();
            
            }
        
        
        }
            
    }
}
