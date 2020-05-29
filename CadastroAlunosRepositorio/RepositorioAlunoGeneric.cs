using CadastroAlunosDomain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunosRepositorio
{
    public class RepositorioAlunoGeneric<T> where T : class, IEntidade
    {

        List<IEntidade> listaAlunos = new List<IEntidade>();

        public void Adicionar(T IEntidade)
        {


        }

        public void Modificar(T IEntidade)
        {

        }

        public void Deletar(T IEntidade)
        {

        }
        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }


            void Get(Func<IEntidade, bool> predicate)
            {
                throw new NotImplementedException();
            }
        }
    }
