using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Helpers
{
    public static class FormHelper
    {

        public static void FormTemizle(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if(control is Panel Panel)
                {

                    foreach (Control controlPanel in control.Controls)
                    {
                        if (controlPanel is ListView listView)
                            listView.Items.Clear();
                        else if (controlPanel is TextBox textBox)
                            textBox.Text = string.Empty;
                        else if (controlPanel is DateTimePicker dateTime)
                            dateTime.Value = DateTime.Now;
                        else if (controlPanel is CheckBox checkBox)
                            checkBox.Checked = false;
                    }

                }

                
                
 
            }
        }

    }
}
