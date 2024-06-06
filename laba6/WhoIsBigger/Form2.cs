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
    public partial class Form2 : Form
    {
        private Game GameSession; 
        public Form2(Game game)
        {
            this.GameSession = game;

            InitializeComponent();

            InitTable();
        }

        private void InitTable()
        {
            foreach (Player player in GameSession.Players)
            {
                this.dataGridView1.Rows.Add(player.Name, 0);
            }
        }

        private void UpdateTable()
        {
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                foreach (Player player in GameSession.Players)
                {
                    if (row.Cells[0].Value == player.Name)
                    {
                        row.Cells[1].Value = player.Score;
                    }
                }
                
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

        private void ShowMessage(string message)
        {
            MessageBox.Show(
                message,
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GameSession.StartRound();
                label3.Text = GameSession.isRoundStarted ? "Раунд запущен" : "Раунд не начат";
                label2.Text = string.Format("{0} раунд", GameSession.CurrentRound.RoundNumber);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GameSession.StopGame(); 

                if (GameSession.isGameFinished)
                {
                    ShowMessage("Вы покинули игру!\nИгра завершена!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                GameSession.RollDice();

                List<string> roundTable = new List<string>
                {
                    string.Format("Результаты раунда {0}", GameSession.CurrentRound.RoundNumber)
                };

                List<Player> roundWinners = new List<Player>();
                int maxResult = 0;

                foreach (Player player in GameSession.Players)
                {
                    foreach (Dice dice in player.Dices)
                    {
                        if (dice.DiceRound == GameSession.CurrentRound)
                        {
                            roundTable.Add(string.Format("{0} - {1}", player.Name, dice.Result));

                            if (dice.Result > maxResult)
                            {
                                roundWinners = new List<Player> { player };
                                maxResult = dice.Result;
                            } 
                            else if (dice.Result == maxResult)
                            {
                                roundWinners.Add(player);
                            }
                        }
                    }
                }

                ShowMessage(string.Join("\n", roundTable));

                while (roundWinners.Count != 1)
                {
                    ShowMessage("Ничейная ситуация в раунде.\nЗапуск дополнительного раунда");

                    int extraRoundMaxResult = 0;

                    List<string> extraRoundTable = new List<string>
                    {
                        "Результаты дополнительного раунда"
                    };

                    foreach (Player player in roundWinners)
                    {
                        Dice dice = new Dice(GameSession.CurrentRound);

                        dice.MakeRoll();

                        extraRoundTable.Add(string.Format("{0} - {1}", player.Name, dice.Result));

                        if (dice.Result > extraRoundMaxResult)
                        {
                            roundWinners = new List<Player> { player };
                            extraRoundMaxResult = dice.Result;
                        }
                        else if (dice.Result == extraRoundMaxResult)
                        {
                            roundWinners.Add(player);
                        }
                    }

                    ShowMessage(string.Join("\n", extraRoundTable));
                }

                ShowMessage(string.Format("Победитель раунда - {0}", roundWinners[0].Name));

                GameSession.AddScore(roundWinners[0]);

                UpdateTable();
                label3.Text = "Раунд окончен";

                if (Round.GetNextRoundCount(GameSession) == 0)
                {
                    List<Player> winners = new List<Player>();
                    int maxScore = 0;

                    foreach (Player player in GameSession.Players)
                    {
                        if (player.Score > maxScore)
                        {
                            winners = new List<Player> { player };
                            maxScore = player.Score;
                        }
                        else if (player.Score == maxScore)
                        {
                            winners.Add(player);
                        }
                    }

                    while (winners.Count != 1)
                    {
                        ShowMessage("Ничейная ситуация в игре.\nЗапуск дополнительного раунда");

                        List<string> extraRoundTable = new List<string>
                        {
                            "Результаты дополнительного раунда"
                        };

                        int extraRoundMaxResult = 0;

                        foreach (Player player in winners)
                        {
                            Dice dice = new Dice(GameSession.CurrentRound);

                            dice.MakeRoll();

                            extraRoundTable.Add(string.Format("{0} - {1}", player.Name, dice.Result));

                            if (dice.Result > extraRoundMaxResult)
                            {
                                winners = new List<Player> { player };
                                extraRoundMaxResult = dice.Result;
                            }
                            else if (dice.Result == extraRoundMaxResult)
                            {
                                winners.Add(player);
                            }
                        }

                        ShowMessage(string.Join("\n", extraRoundTable));
                    }

                    ShowMessage(string.Format("Игра закончена.\nПобедитель - {0}", winners[0].Name));
                    GameSession.StopGame();
                }

                if (GameSession.isGameFinished)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
