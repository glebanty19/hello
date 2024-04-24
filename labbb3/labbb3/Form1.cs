using System;
using System.Windows.Forms;

namespace labbb3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримання значень з текстових полів
                double radius = double.Parse(textBox1.Text);
                double centralAngle = double.Parse(textBox2.Text);

                // Обчислення довжини дуги
                double arcLength = (centralAngle / 360) * 2 * Math.PI * radius;

                // Виведення результату
                textBox3.Text = arcLength.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні значення для радіуса та кута.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
    }
}
