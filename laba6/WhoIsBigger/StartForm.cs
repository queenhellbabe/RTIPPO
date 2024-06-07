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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void CreateGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                int bots = 0;
                bool botsIsParsed = int.TryParse(TextBoxBots.Text, out bots);

                if (!botsIsParsed)
                    throw new ArgumentException("Введите корректное количество ботов!");

                int rounds = 0;
                bool roundsIsParsed = int.TryParse(TextBoxRounds.Text, out rounds);

                if (!roundsIsParsed)
                    throw new ArgumentException("Введите корректное количество раундов!");

                Game game = new Game(bots, rounds);

                GameForm gameForm = new GameForm(game);
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
