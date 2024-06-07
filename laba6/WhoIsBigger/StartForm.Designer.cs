namespace WhoIsBigger
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateGameButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TextBoxBots = new System.Windows.Forms.TextBox();
            this.TextBoxRounds = new System.Windows.Forms.TextBox();
            this.BotsLabel = new System.Windows.Forms.Label();
            this.RoundsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateGameButton
            // 
            this.CreateGameButton.Location = new System.Drawing.Point(153, 156);
            this.CreateGameButton.Name = "CreateGameButton";
            this.CreateGameButton.Size = new System.Drawing.Size(161, 41);
            this.CreateGameButton.TabIndex = 0;
            this.CreateGameButton.Text = "Создать игру";
            this.CreateGameButton.UseVisualStyleBackColor = true;
            this.CreateGameButton.Click += new System.EventHandler(this.CreateGameButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(82, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(290, 55);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Кто больше";
            // 
            // TextBoxBots
            // 
            this.TextBoxBots.Location = new System.Drawing.Point(175, 78);
            this.TextBoxBots.Name = "TextBoxBots";
            this.TextBoxBots.Size = new System.Drawing.Size(166, 20);
            this.TextBoxBots.TabIndex = 2;
            // 
            // TextBoxRounds
            // 
            this.TextBoxRounds.Location = new System.Drawing.Point(175, 115);
            this.TextBoxRounds.Name = "TextBoxRounds";
            this.TextBoxRounds.Size = new System.Drawing.Size(166, 20);
            this.TextBoxRounds.TabIndex = 3;
            // 
            // BotsLabel
            // 
            this.BotsLabel.AutoSize = true;
            this.BotsLabel.Location = new System.Drawing.Point(112, 85);
            this.BotsLabel.Name = "BotsLabel";
            this.BotsLabel.Size = new System.Drawing.Size(33, 13);
            this.BotsLabel.TabIndex = 4;
            this.BotsLabel.Text = "Боты";
            // 
            // RoundsLabel
            // 
            this.RoundsLabel.AutoSize = true;
            this.RoundsLabel.Location = new System.Drawing.Point(112, 118);
            this.RoundsLabel.Name = "RoundsLabel";
            this.RoundsLabel.Size = new System.Drawing.Size(45, 13);
            this.RoundsLabel.TabIndex = 5;
            this.RoundsLabel.Text = "Раунды";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 245);
            this.Controls.Add(this.RoundsLabel);
            this.Controls.Add(this.BotsLabel);
            this.Controls.Add(this.TextBoxBots);
            this.Controls.Add(this.TextBoxRounds);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CreateGameButton);
            this.Name = "Form1";
            this.Text = "Кто больше";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateGameButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TextBoxBots;
        private System.Windows.Forms.TextBox TextBoxRounds;
        private System.Windows.Forms.Label BotsLabel;
        private System.Windows.Forms.Label RoundsLabel;
    }
}

