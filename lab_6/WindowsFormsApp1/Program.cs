using System;
using System.Windows.Forms;

namespace KenoGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int initialBalance = GetInitialBalance();
            if (initialBalance >= 0)
            {
                Application.Run(new Form1(initialBalance));
            }
        }

        private static int GetInitialBalance()
        {
            using (var form = new Form())
            {
                form.Text = "Введите баланс";
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Width = 300;
                form.Height = 150;

                var label = new Label() { Left = 50, Top = 20, Text = "Баланс:" };
                var textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
                var button = new Button() { Text = "Начать игру", Left = 150, Width = 100, Top = 80, DialogResult = DialogResult.OK };

                button.Click += (sender, e) => { form.Close(); };
                form.Controls.Add(label);
                form.Controls.Add(textBox);
                form.Controls.Add(button);
                form.AcceptButton = button;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    int initialBalance;
                    if (int.TryParse(textBox.Text, out initialBalance))
                    {
                        return initialBalance;
                    }
                    else
                    {
                        MessageBox.Show("Неверный формат, введите целое число:");
                        return -1;
                    }
                }
                return -1;
            }
        }
    }
}
