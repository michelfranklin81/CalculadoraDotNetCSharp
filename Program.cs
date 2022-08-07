using System;

namespace Calculator
{

    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {

            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Raiz Quadrada");
            Console.WriteLine("6 - Porcentagem");
            Console.WriteLine("7 - Bhaskara");
            Console.WriteLine("8 - Sair");
            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione uma opção:");

            Console.WriteLine("");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: RaizQd(); break;
                case 6: Percent(); break;
                case 7: Bhaskara(); break;
                case 8: System.Environment.Exit(0); break; //Comando para sair do ambiente. O Exit() define que desejamos sair e o Zero é o seu parâmetrode saída com sucesso.
                default: Menu(); break;
            }

        }

        static void Soma()
        {

            Console.Clear();
            Console.WriteLine("Primeiro valor(v1):");
            float v1 = float.Parse(Console.ReadLine()); //O valor que será digitado no Condole.ReadLine será convertido de string(padrão) para float e será armazenado na variável v1
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine()); //O valor que será digitado no Condole.ReadLine será convertido de string(padrão) para float e será armazenado na variável v2
            float resultado = v1 + v2;
            Console.WriteLine("");
            Console.WriteLine($"{v1} + {v2} = " + resultado);
            // Alternativa 2
            // Console.WriteLine("");
            // Console.WriteLine($"A soma de v1 e v2 é = " + (v1 + v2));

            // Usando placeholder
            // Console.WriteLine("");
            // Console.WriteLine($"A soma de v1 e v2 é = {resultado}"); // $"{}" placeholder no C#
            Console.ReadKey();
            Menu();


        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine($"{v1} - {v2} = {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            if (v1 == 0 && v2 == 0)
            {
                Console.WriteLine("Não é possível dividir por 0.");
            }
            else
            {
                Console.WriteLine("");

                Console.WriteLine($"{v1} / {v2} = {resultado}");

                
            }
                Console.ReadKey();
                Menu();


        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine("");
            Console.WriteLine($"{v1} * {v2} = {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void RaizQd()
        {
            Console.Clear();

            Console.WriteLine("Digite o número desejado:");
            float v1 = float.Parse(Console.ReadLine());

            double resultado = Math.Sqrt(v1);

            Console.WriteLine("");
            Console.WriteLine($"A raiz quadrada de {v1} = {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Percent()
        {
            Console.Clear();

            Console.WriteLine("Digite o valor total:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual desejado:");
            float v2 = float.Parse(Console.ReadLine());

            double resultado = (v1 * v2) / 100;

            Console.WriteLine("");
            Console.WriteLine($"{v2}% de {v1} = {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Bhaskara()
        {
            Console.Clear();

            Console.WriteLine("Digite o valor de 'a':");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de 'b':");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de 'c':");
            float c = float.Parse(Console.ReadLine());

            float delta = (b * b) - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("O delta é negativo. Equação não possui raízes reais.");
                Console.ReadKey();
                Menu();
            }
            else
            {
                double x1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
                double x2 = ((-b) - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Resultado");
                Console.WriteLine("");
                Console.WriteLine($"x1= {x1}");
                Console.WriteLine($"x2= {x2}");
            }

            Console.ReadKey();
            Menu();

        }
    }


}




