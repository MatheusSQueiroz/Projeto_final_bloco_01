using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    internal interface IPerfumeRepository
    {
        public void ProcurarPorCodigo(int id);
        public void ListarPerfumes();
        public void Cadastrar(Perfume perfume);
        public void Atualizar(Perfume perfume);
        public void Deletar(int id);
    }
}
