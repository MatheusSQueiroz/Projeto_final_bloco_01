using Loja.Model;
using Loja.Controller;
using System;

namespace Loja
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {
            int option, id, nacionalidade;
            string? nome, fabricante, paisOrigem;
            decimal preco;
            float tamanho;

            PerfumeController perfume = new();

            while (true)
            {
                Console.WriteLine("**************************************************************");
                Console.WriteLine("*                                                            *");
                Console.WriteLine("*                    PERFUMARIA QRZ                          *");
                Console.WriteLine("*                                                            *");
                Console.WriteLine("**************************************************************");
                Console.WriteLine("*                1 - Cadastrar perfume                       *");
                Console.WriteLine("*                2 - Listar todos perfumes                   *");
                Console.WriteLine("*                3 - Buscar perfume por ID                   *");
                Console.WriteLine("*                4 - Atualizar perfume                       *");
                Console.WriteLine("*                5 - Excluir perfume                         *");
                Console.WriteLine("*                6 - Sair                                    *");
                Console.WriteLine("**************************************************************");
                Console.WriteLine("*                Entre com a opção desejada:                 *");
                Console.WriteLine("**************************************************************");

                try
                {

                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um número entre 1 e 6!");
                    option = 0;
                    Console.ResetColor();
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Cadastrar novo perfume\n\n");

                        Console.WriteLine("Digite o código do perfume:");
                        id = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Digite o nome do perfume:");
                        nome = Console.ReadLine();


                        Console.WriteLine("Digite o tamanho em ML do perfume:");
                        tamanho = Convert.ToSingle(Console.ReadLine());



                        do
                        {
                            Console.WriteLine("Digite a nacionalidade: [1] - Nacional [2] - Importado");
                            nacionalidade = Convert.ToInt32(Console.ReadLine());

                        } while (nacionalidade != 1 && nacionalidade != 2);

                        Console.WriteLine("Digite o preço do perfume:");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        switch (nacionalidade)
                        {
                            case 1:
                                Console.WriteLine("Digite o fabricante: ");
                                fabricante = Console.ReadLine();

                                perfume.Cadastrar(new Nacional(id, nome, nacionalidade, preco, tamanho, fabricante));

                                break;

                            case 2:
                                Console.WriteLine("Digite o país de origem:");
                                paisOrigem = Console.ReadLine();

                                perfume.Cadastrar(new Importado(id, nome, nacionalidade, preco, tamanho, paisOrigem));

                                break;
                        }

                        KeyPress();
                        break;

                    case 2:
                        Console.WriteLine("Listar todos os perfumes\n\n");

                        perfume.ListarPerfumes();

                        KeyPress();
                        break;

                    case 3:
                        Console.WriteLine("Buscar perfume por código\n\n");

                        Console.WriteLine("Digite o código do perfume:");
                        id = Convert.ToInt32(Console.ReadLine());


                        perfume.ProcurarPorCodigo(id);
                        KeyPress();
                        break;

                    case 4:
                        Console.WriteLine("Atualizar perfume\n\n");

                        Console.WriteLine("Digite o código do perfume:");
                        id = Convert.ToInt32(Console.ReadLine());

                        var perfumes = perfume.BuscaPerfume(id);

                        if(perfumes is not null)
                        {
                            Console.WriteLine("Digite o código do perfume:");
                            id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite o nome do perfume:");
                            nome = Console.ReadLine();


                            Console.WriteLine("Digite o tamanho em ML do perfume:");
                            tamanho = Convert.ToSingle(Console.ReadLine());



                            do
                            {
                                Console.WriteLine("Digite a nacionalidade: [1] - Nacional [2] - Importado");
                                nacionalidade = Convert.ToInt32(Console.ReadLine());

                            } while (nacionalidade != 1 && nacionalidade != 2);

                            Console.WriteLine("Digite o preço do perfume:");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            switch (nacionalidade)
                            {
                                case 1:
                                    Console.WriteLine("Digite o fabricante: ");
                                    fabricante = Console.ReadLine();

                                    perfume.Atualizar(new Nacional(id, nome, nacionalidade, preco, tamanho, fabricante));

                                    break;

                                case 2:
                                    Console.WriteLine("Digite o país de origem:");
                                    paisOrigem = Console.ReadLine();

                                    perfume.Atualizar(new Importado(id, nome, nacionalidade, preco, tamanho, paisOrigem));

                                    break;
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Excluir perfume\n\n");

                        Console.WriteLine("Digite o código do perfume:");
                        id = Convert.ToInt32(Console.ReadLine());
                        perfume.Deletar(id);
                        KeyPress();
                        break;

                    case 6:
                        Sobre();
                        System.Environment.Exit(0);

                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            static void Sobre()
            {
                Console.WriteLine("\n**************************************************************");
                Console.WriteLine("Projeto desenvolvido por: ");
                Console.WriteLine("Matheus Queiroz - matheusqrz.dev@gmail.com ");
                Console.WriteLine("Github - https://github.com/MatheusSQueiroz ");
                Console.WriteLine("**************************************************************");
            }

            static void KeyPress()
            {
                do
                {
                    Console.Write("\nPressione Enter para Continuar...");
                    consoleKeyInfo = Console.ReadKey();
                } while (consoleKeyInfo.Key != ConsoleKey.Enter);
            }
        }
    }
}