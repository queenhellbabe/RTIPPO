using System.Linq;
using WhoIsBigger.Domain;

namespace WhoIsBigger
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartRoundButton = new System.Windows.Forms.Button();
            this.StopGameButton = new System.Windows.Forms.Button();
            this.MakeRollButton = new System.Windows.Forms.Button();
            this.RoundNumberLabel = new System.Windows.Forms.Label();
            this.RoundStatusLabel = new System.Windows.Forms.Label();
            this.ScoreTable = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StartRoundButton
            // 
            this.StartRoundButton.Location = new System.Drawing.Point(29, 27);
            this.StartRoundButton.Name = "StartRoundButton";
            this.StartRoundButton.Size = new System.Drawing.Size(130, 45);
            this.StartRoundButton.TabIndex = 1;
            this.StartRoundButton.Text = "Начать раунд";
            this.StartRoundButton.UseVisualStyleBackColor = true;
            this.StartRoundButton.Click += new System.EventHandler(this.StartRoundButton_Click);
            // 
            // StopGameButton
            // StopGameButton
            this.StopGameButton.Location = new System.Drawing.Point(29, 156);
            this.StopGameButton.Name = "StopGameButton";
            this.StopGameButton.Size = new System.Drawing.Size(130, 45);
            this.StopGameButton.TabIndex = 2;
            this.StopGameButton.Text = "Покинуть игру";
            this.StopGameButton.UseVisualStyleBackColor = true;
            this.StopGameButton.Click += new System.EventHandler(this.StopGameButton_Click);
            // 
            // MakeRollButton
            // 
            this.MakeRollButton.Location = new System.Drawing.Point(29, 89);
            this.MakeRollButton.Name = "MakeRollButton";
            this.MakeRollButton.Size = new System.Drawing.Size(130, 45);
            this.MakeRollButton.TabIndex = 3;
            this.MakeRollButton.Text = "Сделать бросок";
            this.MakeRollButton.UseVisualStyleBackColor = true;
            this.MakeRollButton.Click += new System.EventHandler(this.MakeRollButton_Click);
            // 
            // RoundNumberLabel
            // 
            this.RoundNumberLabel.AutoSize = true;
            this.RoundNumberLabel.Location = new System.Drawing.Point(64, 233);
            this.RoundNumberLabel.Name = "RoundNumberLabel";
            this.RoundNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.RoundNumberLabel.TabIndex = 4;
            // 
            // RoundStatusLabel
            // 
            this.RoundStatusLabel.AutoSize = true;
            this.RoundStatusLabel.Location = new System.Drawing.Point(51, 270);
            this.RoundStatusLabel.Name = "RoundStatusLabel";
            this.RoundStatusLabel.Size = new System.Drawing.Size(83, 13);
            this.RoundStatusLabel.TabIndex = 5;
            this.RoundStatusLabel.Text = "Раунд не начат";
            // 
            // ScoreTable
            // 
            this.ScoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.Score});
            this.ScoreTable.Location = new System.Drawing.Point(241, 27);
            this.ScoreTable.Name = "ScoreTable";
            this.ScoreTable.Size = new System.Drawing.Size(392, 150);
            this.ScoreTable.TabIndex = 6;
            // 
            // PlayerName
            // 
            this.PlayerName.Frozen = true;
            this.PlayerName.HeaderText = "Player name";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            this.PlayerName.Width = 200;
            // 
            // Score
            // 
            this.Score.Frozen = true;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 150;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(675, 363);
            this.Controls.Add(this.ScoreTable);
            this.Controls.Add(this.RoundStatusLabel);
            this.Controls.Add(this.RoundNumberLabel);
            this.Controls.Add(this.MakeRollButton);
            this.Controls.Add(this.StopGameButton);
            this.Controls.Add(this.StartRoundButton);
            this.Name = "Form2";
            this.Text = "Игра";
            ((System.ComponentModel.ISupportInitialize)(this.ScoreTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartRoundButton;
        private System.Windows.Forms.Button StopGameButton;
        private System.Windows.Forms.Button MakeRollButton;
        private System.Windows.Forms.Label RoundNumberLabel;
        private System.Windows.Forms.Label RoundStatusLabel;
        private System.Windows.Forms.DataGridView ScoreTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}