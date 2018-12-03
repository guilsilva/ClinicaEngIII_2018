using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaEngIII
{
    public class ManipulacoesTelas
    {
        public void limparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
                if (ctrl is CheckBox)
                {
                    ((CheckBox)(ctrl)).Checked = false;
                }
            }
        }

        public void AlterarEdicaoTextBoxes(Control.ControlCollection controles, bool visao)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Enabled = visao;
                }
            }
        }
        public bool VerificaTextBoxesPreenchidas(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    if(((TextBox)(ctrl)).Text == String.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void bloquearCheckBoxes(Control.ControlCollection controles, bool desbloquear)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is CheckBox)
                {
                    ((CheckBox)(ctrl)).Enabled = desbloquear;
                }
            }
        }
    }
}
