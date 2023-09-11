using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    public class Nacional : Perfume
    {
        private string fabricante;
        public Nacional(int id, string nome, string nacionalidade, decimal preco, float tamanho) : 
            base(id, nome, nacionalidade, preco, tamanho)
        {
            this.fabricante = fabricante;
        }

        public string GetFabricante() { return  fabricante; }

        public void SetFabricante(string fabricante) { this.fabricante = fabricante; }
    }
}
