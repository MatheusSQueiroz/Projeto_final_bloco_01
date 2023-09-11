using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    public class Importado : Perfume
    {
        private string paisOrigem
        public Importado(int id, string nome, string nacionalidade, decimal preco, float tamanho) : 
            base(id, nome, nacionalidade, preco, tamanho)
        {
            this.paisOrigem = paisOrigem;
        }

        public string GetPaisOrigem() { return  paisOrigem; }

        public void SetPaisOrigem(string paisOrigem) { this.paisOrigem = paisOrigem; }
    }
}
