using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    public abstract class Perfume
    {
        private int id;
        private string nome;
        private string nacionalidade;
        private decimal preco;
        private float tamanho;

        public Perfume(int id, string nome, string nacionalidade, decimal preco, float tamanho)
        {
            this.id = id;
            this.nome = nome;
            this.nacionalidade = nacionalidade;
            this.preco = preco;
            this.tamanho = tamanho;
        }

        public int GetId() { return id; }

        public void SetId(int id) { this.id = id;}

        public string GetNome() {  return nome;}

        public void SetNome(string nome) {  this.nome = nome;}

        public string GetNacionalidade() {  return nacionalidade;}

        public void SetNacionalidade (string nacionalidade) { this.nacionalidade = nacionalidade;}

        public decimal GetPreco() {  return preco;}

        public void SetPreco(decimal preco) {  this.preco = preco;}

        public float GetTamanho() {  return tamanho;}

        public void SetTamanho (float tamanho) { this.tamanho = tamanho ; }

        public void Visualizar()
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Dados do perfume:");
            Console.WriteLine("**************************************************************");
            Console.WriteLine($"Código do perfume: {this.id}");
            Console.WriteLine($"Nome do perfume: {this.nome}");
            Console.WriteLine($"Nacionalidade do perfume: {this.nacionalidade}");
            Console.WriteLine($"Preço do perfume: {this.preco}");
            Console.WriteLine($"Tamanho do perfume em ML: {this.tamanho}");
            Console.WriteLine("**************************************************************");
        }

    }
}
