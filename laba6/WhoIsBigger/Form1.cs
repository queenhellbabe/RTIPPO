using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhoIsBigger.Domain;

namespace WhoIsBigger
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
                int bots = 0;
                bool botsIsParsed = int.TryParse(textBoxBots.Text, out bots);

                if (!botsIsParsed)
                    throw new ArgumentException("Введите корректное количество ботов!");

                int rounds = 0;
                bool roundsIsParsed = int.TryParse(textBoxRounds.Text, out rounds);

                if (!roundsIsParsed)
                    throw new ArgumentException("Введите корректное количество раундов!");

                Game game = new Game(bots, rounds);

                Form2 gameForm = new Form2(game);
                gameForm.Show();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(
                message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
