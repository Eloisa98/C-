using System;

namespace ExercíciosCSharp
{
    public class Ingresso
    {
        public string nomeDoShow;
        public double preco;
        public int quantidadeDisponivel;

        public Ingresso(string nome, double p, int qtd)
        {
            nomeDoShow = nome;
            preco = p;
            quantidadeDisponivel = qtd;
        }

        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Show: {nomeDoShow}, Preço: R${preco:F2}, Qtd: {quantidadeDisponivel}");
        }

        public string GetNomeDoShow() { return nomeDoShow; }
        public void SetNomeDoShow(string novoNome) { nomeDoShow = novoNome; }

        public double GetPreco() { return preco; }
        public void SetPreco(double novoPreco) { preco = novoPreco; }

        public int GetQuantidadeDisponivel() { return quantidadeDisponivel; }
        public void SetQuantidadeDisponivel(int novaQtd) { quantidadeDisponivel = novaQtd; }
    }
}
