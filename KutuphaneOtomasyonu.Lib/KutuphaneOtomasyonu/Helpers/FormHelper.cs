using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Helpers
{
    public static class FormHelper
    {

        public static void FormTemizle(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is ListView listView)
                    listView.Items.Clear();
                else if (control is TextBox textBox)
                    textBox.Text = string.Empty;
                else if (control is DateTimePicker dateTime)
                    dateTime.Value = DateTime.Now;
                else if (control is CheckBox checkBox)
                    checkBox.Checked = false;
 
            }
        }

    }
}
