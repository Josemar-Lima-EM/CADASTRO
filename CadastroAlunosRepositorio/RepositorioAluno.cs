using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroAlunosDomain;



namespace CadastroAlunosRepositorio
{
    public class RepositorioAluno : RepositorioAlunoGeneric<Aluno>
    {

        List<Aluno> listaAlunos = new List<Aluno>();

        public void Adicionar(Aluno alunoDomain)
        {

            listaAlunos.Add(alunoDomain);
        }

        public void Modificar(Aluno IEntidade)
        {

        }

        public void Deletar(Aluno IEntidade)
        {

        }
        public IEnumerable GetAll()
        {

            listaAlunos.Add(new Aluno(222, "maria", EnumeradorSexo.Feminino, Convert.ToDateTime("01/01/2001"), "12569854789"));
            listaAlunos.Add(new Aluno(333, "joao", EnumeradorSexo.Masculino, Convert.ToDateTime("05/01/2004"), "22569854787"));
            listaAlunos.Add(new Aluno(444, "ze", EnumeradorSexo.Feminino, Convert.ToDateTime("01/06/1998"), "32569854786"));
            listaAlunos.Add(new Aluno(555, "bia", EnumeradorSexo.Feminino, Convert.ToDateTime("06/04/2008"), "42569854785"));

            return (IEnumerable)listaAlunos;
        }

        public IEnumerable<Aluno> Get(Func<IEntidade, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void BuscarPorMatricula(params object[] id)
        {

        }

        public void BuscarPorNomeOuParteDoNome(Func<IEntidade, bool> predicate)
        {

        }

    }
}
