using CadastroAlunosDomain;
using CadastroAlunosRepositorio;
using CadastroAlunosWinForm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;



namespace CadastroAlunosWinForm
{
    public partial class FrmCadastroAlunos : Form
    {
        //BindingSource bsCadastroAluno = new BindingSource();

        Aluno alunoDomain = new Aluno();
        LimparFormulario ui = new LimparFormulario();
        RepositorioAluno repositorioAluno = new RepositorioAluno();
        private object gvListaAlunos;

        public FrmCadastroAlunos()
        {
            InitializeComponent();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                //atribuindo dados do form a um objeto
                alunoDomain.Matricula = int.Parse(txtMatricula.Text);
                alunoDomain.Nome = txtNome.Text;
                EnumeradorSexo sexoEscolhido;
                var sexoIndex = txtSexo.SelectedIndex;
                if (txtSexo.Text == "Masculino")
                {
                    sexoEscolhido = EnumeradorSexo.Masculino;
                }
                else if (txtSexo.Text == "Feminino")
                {
                    sexoEscolhido = EnumeradorSexo.Feminino;
                }
                else
                {

                    MessageBox.Show("Escolha uma das opções!", "'Sexo' não informado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                alunoDomain.Nascimento = Convert.ToDateTime(mtbNascimento.Text);
                alunoDomain.Cpf = txtCpf.Text;

                repositorioAluno.Adicionar(alunoDomain);

                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;

                ui.LimpaCampos(this.gpbNovoAluno.Controls);

                MessageBox.Show("Cadastro Realizado com secesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cadastro não inserido! Algo deu errado! Por favor, insira novamente o dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bsCadastroAluno.DataSource = repositorioAluno.GetAll();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Passa o método LimparCampos() a todos os controles que estão dentro do panel
            ui.LimpaCampos(this.gpbNovoAluno.Controls);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                txtMatricula.Text = dgvListaAlunos.SelectedRows[0].Cells[0].Value.ToString();
                txtNome.Text = dgvListaAlunos.SelectedRows[0].Cells[1].Value.ToString();
                txtCpf.Text = dgvListaAlunos.SelectedRows[0].Cells[2].Value.ToString();
                mtbNascimento.Text = dgvListaAlunos.SelectedRows[0].Cells[3].Value.ToString();
                txtSexo.Text = dgvListaAlunos.SelectedRows[0].Cells[4].Value.ToString();



                btnAdicionar.Visible = false;
                btnLimpar.Visible = false;
                btnModificar.Visible = true;
                btnCancelar.Visible = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                txtMatricula.ReadOnly = true;
                gpbNovoAluno.Text = "Editando Aluno";

            }
            catch
            {
                MessageBox.Show("Povr Favor selecione o registro a ser editado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            dgvListaAlunos.SelectedRows[0].Cells[0].Value = txtMatricula.Text;
            dgvListaAlunos.SelectedRows[0].Cells[1].Value = txtNome.Text;
            dgvListaAlunos.SelectedRows[0].Cells[2].Value = txtCpf.Text;
            dgvListaAlunos.SelectedRows[0].Cells[3].Value = mtbNascimento.Text;
            dgvListaAlunos.SelectedRows[0].Cells[4].Value = txtSexo.Text;

            //alunoDomain.Matricula = int.Parse(txtMatricula.Text);
            //alunoDomain.Nome = txtNome.Text;
            //EnumeradorSexo sexoEscolhido = EnumeradorSexo.Masculino;
            //if (txtSexo.Text == "Feminino")
            //{
            //    sexoEscolhido = EnumeradorSexo.Feminino;
            //}
            //alunoDomain.Sexo = sexoEscolhido;
            //alunoDomain.Nascimento = Convert.ToDateTime(mtbNascimento.Text).Date;
            //alunoDomain.Cpf = txtCpf.Text;

            //repositorioAluno.Modificar(alunoDomain);

            btnAdicionar.Visible = true;
            btnLimpar.Visible = true;
            btnModificar.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            txtMatricula.ReadOnly = false;
            gpbNovoAluno.Text = "Novo Aluno";

            ui.LimpaCampos(this.gpbNovoAluno.Controls);

            bsCadastroAluno.DataSource = repositorioAluno.GetAll();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja Cancelar a Modificação?", "Atenção", MessageBoxButtons.OK);

            //dgvListaAlunos.SelectedRows[0].Cells[0].Value = dgvListaAlunos.SelectedRows[0].Cells[0].Value.ToString();
            //dgvListaAlunos.SelectedRows[0].Cells[1].Value = dgvListaAlunos.SelectedRows[0].Cells[1].Value.ToString();
            //dgvListaAlunos.SelectedRows[0].Cells[2].Value = dgvListaAlunos.SelectedRows[0].Cells[2].Value.ToString();
            //dgvListaAlunos.SelectedRows[0].Cells[3].Value = dgvListaAlunos.SelectedRows[0].Cells[3].Value.ToString();
            //dgvListaAlunos.SelectedRows[0].Cells[4].Value = dgvListaAlunos.SelectedRows[0].Cells[4].Value.ToString();

            bsCadastroAluno.DataSource = repositorioAluno.GetAll();

            btnAdicionar.Visible = true;
            btnLimpar.Visible = true;
            btnModificar.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            txtMatricula.ReadOnly = false;
            gpbNovoAluno.Text = "Novo Aluno";

            ui.LimpaCampos(this.gpbNovoAluno.Controls);


        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Deseja excluir o registro selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                dgvListaAlunos.Rows.RemoveAt(dgvListaAlunos.SelectedRows[0].Index);

                MessageBox.Show("Registro excluido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O registro não foi excluído!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bsCadastroAluno.DataSource = repositorioAluno.GetAll();
            }

            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        private void dgvListaAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bsCadastroAluno.DataSource = repositorioAluno.GetAll();

            dgvListaAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaAlunos.MultiSelect = false;
        }
        //private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("Matricula invladida! Informe apenas valores numéricos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void mtbNascimento_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("Informe apenas valores numericos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("Informe apenas valores numéricos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void FrmCadastroAlunos_Load(object sender, EventArgs e)
        {
            gvListaAlunos = bsCadastroAluno.DataSource;
            bsCadastroAluno.DataSource = repositorioAluno.GetAll();
        }
    }
}
