using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс для проверки данных.
    /// </summary>
    static public class TextBoxHandler
    {
        // TODO: duplication +
        /// <summary>
        /// Проверка данных вводимых в textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static public void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            string dataType = textBox.Tag as string;

            if (dataType == "int")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (dataType == "double")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == ',' && textBox.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar == '0' && string.IsNullOrEmpty(textBox.Text.Trim('0')))
            {
                e.Handled = true;
            }
        }
    }
}
