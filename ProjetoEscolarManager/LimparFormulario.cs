using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAlunosWinForm
{
    class LimparFormulario
    {
        public void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control item in controles)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = string.Empty;
                }
                if (item.GetType() == typeof(ComboBox))
                {
                    item.Text = string.Empty;
                }
                if (item.GetType() == typeof(MaskedTextBox))
                {
                    item.Text = string.Empty;
                }

            }
        }
    }
}