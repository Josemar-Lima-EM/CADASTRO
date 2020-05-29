using CadastroAlunosWinForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CadastroAlunosWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCadastroAlunos());

            //ArrayList alunos = new ArrayList();

            //alunos.Add(new Aluno(111,"joao", SexoEnum..Masculino));
            //alunos.Add(new Aluno(222,"maria","01234567890",SexoEnum..Feminino));

            //foreach (var item in alunos)
            //{
            //    Console.WriteLine(item.ToString());

            //}





        }
    }
}
