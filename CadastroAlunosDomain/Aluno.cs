using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunosDomain
{
    public class Aluno : IEntidade
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public EnumeradorSexo Sexo { get; set; }


        public Aluno(int matricula, string nome, EnumeradorSexo sexo, DateTime nascimento)
        {
            Matricula = matricula;
            Nome = nome;
            Sexo = sexo;
            Nascimento = nascimento;
        }
        public Aluno(int matricula, string nome, EnumeradorSexo sexo, DateTime nascimento, string cpf) : this (matricula, nome, sexo, nascimento)
        {
            
            Cpf = cpf;
}
            public Aluno()
        {
        }

    }
}
