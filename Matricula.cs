using System;

namespace ExercíciosCSharp
{
    public class Matricula
    {
        public string NomeDoAluno;
        public string Curso;
        public int NumeroMatricula;
        public string Situacao;
        public string DataInicial;

        public void Trancar()
        {
            Situacao = "Trancada";
        }

        public void Reativar()
        {
            Situacao = "Ativa";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Aluno: {NomeDoAluno}, Curso: {Curso}, Matrícula: {NumeroMatricula}, Situação: {Situacao}, Início: {DataInicial}");
        }
    }
}
