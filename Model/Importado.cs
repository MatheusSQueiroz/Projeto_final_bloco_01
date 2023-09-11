using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    public class Importado : Perfume
    {
        private string paisOrigem;

        public Importado(int id, string nome, int nacionalidade, decimal preco, float tamanho, string paisOrigem) : 
            base(id, nome, nacionalidade, preco, tamanho)
        {
            this.paisOrigem = paisOrigem;
        }


        public string GetPaisOrigem() { return  paisOrigem; }

        public void SetPaisOrigem(string paisOrigem) { this.paisOrigem = paisOrigem; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"País de origem: {this.paisOrigem}");
            Console.WriteLine("**************************************************************");
        }
    }
}
