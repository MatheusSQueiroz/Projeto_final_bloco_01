using Loja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Controller
{
    public class PerfumeController : IPerfumeRepository
    {
        private readonly List<Perfume> listaPerfumes = new();
        int id = 0;


        public void Atualizar(Perfume perfume)
        {
           var buscaPerfume = BuscaPerfume(perfume.GetId());

            if(buscaPerfume is not  null)
            {
                var index = listaPerfumes.IndexOf(buscaPerfume);

                listaPerfumes[index] = perfume;

                Console.WriteLine($"O perfume de código {perfume.GetId()} foi atualizado!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Perfume não encontrado!");
                Console.ResetColor();
            }
        }

        public void Cadastrar(Perfume perfume)
        {
            listaPerfumes.Add(perfume);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Perfume de código {perfume.GetId()} cadastrado!");
            Console.ResetColor();
        }

        public void Deletar(int id)
        {
            var perfume = BuscaPerfume(id);

            if(perfume is not null)
            {
                if(listaPerfumes.Remove(perfume) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Perfume de código {id} deletado!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Não foi possível localizar o perfume de código {id}");
                    Console.ResetColor();
                }
            }
        }

        public void ListarPerfumes()
        {
            foreach(var perfume in listaPerfumes)
            {
                perfume.Visualizar();
            }
        }

        public void ProcurarPorCodigo(int id)
        {
            var perfume = BuscaPerfume(id);

            if (perfume is not null)
            {
                perfume.Visualizar();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Não foi possível localizar o perfume de código {id}");
                Console.ResetColor();
            }
        }

        public Perfume? BuscaPerfume(int id)
        {
            foreach(var perfume in listaPerfumes)
            {
                if (perfume.GetId() == id)
                    return perfume;
            }

            return null;

        }
    }
}
