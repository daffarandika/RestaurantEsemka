using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r6.Utils
{
    internal class Guard
    {
        public static bool FailsAgainstNull(Control[] controls)
        {
            bool fail = false;
            foreach (Control control in controls)
            {
                if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedIndex == -1)
                    {
                        control.ShowTinyError();
                        fail = true;
                    } else
                    {
                        control.ClearTinyError();
                    }
                } else
                {
                    if (control.Text.Length == 0)
                    {
                        control.ShowTinyError();
                        fail = true;
                    } else
                    {
                        control.ClearTinyError();
                    }
                }
            }
            return fail;
        }
    }
}
