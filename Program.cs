namespace Loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option, id;
            string nome, nacionalidade;
            decimal preco;
            float tamanho;

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
                option = Convert.ToInt32(Console.ReadLine());

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

                            
                        Console.WriteLine("Digite a nacionalidade do perfume:");
                        nacionalidade = Console.ReadLine();


                        Console.WriteLine("Digite o preço do perfume:");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        break;

                    case 2:
                        Console.WriteLine("Listar todos os perfumes\n\n");
                        break;

                    case 3:
                        Console.WriteLine("Buscar perfume por código\n\n");
                        break;

                    case 4:
                        Console.WriteLine("Atualizar perfume\n\n");
                        break;

                    case 5:
                        Console.WriteLine("Excluir perfume\n\n");
                        break;

                    case 6:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}