using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KenoGame
{
    public partial class Form1 : Form
    {
        private Game game;
        private List<Button> numberButtons;
        private Label label2;
        private TextBox textBox1;
        private HashSet<int> selectedNumbers;

        public Form1(int initialBalance)
        {
            InitializeComponent();
            game = new Game(initialBalance);
            selectedNumbers = new HashSet<int>();
            InitializeNumberButtons();
            lblBalance.Text = $"Баланс: {game.Balance}";
        }

        private void InitializeNumberButtons()
        {
            numberButtons = new List<Button>();
            for (int i = 1; i <= 80; i++)
            {
                Button btn = new Button
                {
                    Text = i.ToString(),
                    Width = 30,
                    Height = 30,
                    Tag = i,
                    BackColor = Color.LightGray
                };
                btn.Click += NumberButton_Click;
                flowLayoutPanelNumbers.Controls.Add(btn);
                numberButtons.Add(btn);
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                int number = (int)btn.Tag;
                if (btn.BackColor == Color.LightGray)
                {
                    if (selectedNumbers.Count < 10)
                    {
                        btn.BackColor = Color.Blue;
                        selectedNumbers.Add(number);
                    }
                    else
                    {
                        MessageBox.Show("Вы можете выбрать только 10 номеров.");
                    }
                }
                else if (btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.LightGray;
                    selectedNumbers.Remove(number);
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (selectedNumbers.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одно число.");
                return;
            }

            int bid;
            if (!int.TryParse(txtBid.Text, out bid) || bid <= 0)
            {
                MessageBox.Show("Введите ставку.");
                return;
            }
            int ticketCount;
            if (!int.TryParse(textBox1.Text, out ticketCount) || ticketCount <= 0)
            {
                MessageBox.Show("Введите количество билетов.");
                return;
            }

            if (game.Balance >= bid * ticketCount)
            {
                List<List<int>> winningNumbers = game.PlayGame(bid, selectedNumbers.ToList(), ticketCount);
                lblBalance.Text = $"Баланс: {game.Balance}";

                ShowResults(selectedNumbers.ToList(), winningNumbers, game.LastGain);
            }
            else {
                MessageBox.Show("Недостаточно баланса!");
                return;
            }
            
        }

        private void ShowResults(List<int> selectedNumbers, List<List<int>> winningNumbers, int gain)
        {
            string selectedNumbersStr = string.Join(", ", selectedNumbers);
            string winningNumbersStr = ConvertListOfListsToString(winningNumbers);

            string message = $"Выбранные номера: {selectedNumbersStr}\n" +
                             $"Выигрышные номера: \n{winningNumbersStr}\n" +
                             $"Выигрыш: {gain}";

            label1.Text = message;
        }
        static string ConvertListOfListsToString(List<List<int>> listOfLists)
        {
            List<string> listOfStrings = new List<string>();

            foreach (List<int> innerList in listOfLists)
            {
                string innerListStr = string.Join(", ", innerList);
                listOfStrings.Add(innerListStr);
            }

            return string.Join("\n", listOfStrings);
        }
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNumbers;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.lblBid = new System.Windows.Forms.Label();
            this.flowLayoutPanelNumbers = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(12, 600);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(58, 16);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Баланс:";

            this.btnPlay.Location = new System.Drawing.Point(713, 592);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 37);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);

            this.txtBid.Location = new System.Drawing.Point(607, 595);
            this.txtBid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(100, 22);
            this.txtBid.TabIndex = 3;

            this.lblBid.AutoSize = true;
            this.lblBid.Location = new System.Drawing.Point(609, 574);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(54, 16);
            this.lblBid.TabIndex = 4;
            this.lblBid.Text = "Ставка";

            this.flowLayoutPanelNumbers.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanelNumbers.Location = new System.Drawing.Point(64, 62);
            this.flowLayoutPanelNumbers.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.flowLayoutPanelNumbers.Name = "flowLayoutPanelNumbers";
            this.flowLayoutPanelNumbers.Size = new System.Drawing.Size(481, 358);
            this.flowLayoutPanelNumbers.TabIndex = 0;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выбранные номера:\r\nВыигрышные номера:\r\nВыигрыш:";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество билетов";

            this.textBox1.Location = new System.Drawing.Point(445, 595);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 6;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Без_имени_12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBid);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.flowLayoutPanelNumbers);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Keno Game";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
