using System;

namespace ExercíciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste Exercícios 2-6: Ingresso
            Console.WriteLine("=== TESTE INGRESSO (Exercícios 2-6) ===");
            Ingresso ingresso1 = new Ingresso("Show do Metallica", 150.0, 100);
            ingresso1.ExibirInformacoes();

            ingresso1.AlterarPreco(180.0);
            ingresso1.AlterarQuantidade(80);
            ingresso1.ExibirInformacoes();

            // Teste getters/setters
            ingresso1.SetPreco(200.0);
            Console.WriteLine($"Preço atual: {ingresso1.GetPreco()}");

            // Teste Exercícios 7-9: Matrícula
            Console.WriteLine("\n=== TESTE MATRÍCULA (Exercícios 7-9) ===");
            Matricula mat1 = new Matricula();
            mat1.NomeDoAluno = "João Silva";
            mat1.Curso = "Engenharia";
            mat1.NumeroMatricula = 12345;
            mat1.Situacao = "Ativa";
            mat1.DataInicial = "01/01/2025";

            mat1.ExibirInformacoes();
            mat1.Trancar();
            mat1.ExibirInformacoes();
            mat1.Reativar();
            mat1.ExibirInformacoes();

            // Teste Exercícios 10-12: Figuras
            Console.WriteLine("\n=== TESTE FIGURAS (Exercícios 10-12) ===");
            Circulo circulo = new Circulo();
            circulo.Raio = 3.0;
            Console.WriteLine($"Área do círculo: {circulo.CalcularArea():F2}");

            Esfera esfera = new Esfera();
            esfera.Raio = 5.0;
            Console.WriteLine($"Volume da esfera: {esfera.CalcularVolume():F2}");
        }
    }
}
