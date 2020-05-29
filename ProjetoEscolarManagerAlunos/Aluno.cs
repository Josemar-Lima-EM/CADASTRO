using CadastroAlunosModel;
using System;

namespace CadastroAlunoModel
{
    public class Aluno : IEntidade
    {
        public int Matricula { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public SexoEnum Sexo { get; set; }


        public Aluno(int matricula, string nome, DateTime nascimento, SexoEnum sexo)
        {
            Matricula = matricula;
            Nome = nome;
            Nascimento = nascimento;
            Sexo = sexo;
        }


        public Aluno(int matricula, string nome, string cpf, DateTime nascimento, SexoEnum sexo) : this(matricula, nome, nascimento, sexo)
        {
            Cpf = cpf;
        }

        public Aluno()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Aluno aluno;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return $@"{Matricula}, {Nome}, {Sexo}, {Nascimento}, {Cpf}";
        }
    }
}