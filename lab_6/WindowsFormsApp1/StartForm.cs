using System;
using System.Windows.Forms;

namespace KenoGame
{
    public partial class StartForm : Form
    {
        public int InitialBalance { get; private set; }

        public StartForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInitialBalance.Text, out int balance) && balance > 0)
            {
                InitialBalance = balance;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите баланс:");
            }
        }
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtInitialBalance;
        private System.Windows.Forms.Label lblInitialBalance;

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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInitialBalance = new System.Windows.Forms.TextBox();
            this.lblInitialBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(94, 74);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInitialBalance
            // 
            this.txtInitialBalance.Location = new System.Drawing.Point(13, 29);
            this.txtInitialBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtInitialBalance.Name = "txtInitialBalance";
            this.txtInitialBalance.Size = new System.Drawing.Size(181, 22);
            this.txtInitialBalance.TabIndex = 1;
            // 
            // lblInitialBalance
            // 
            this.lblInitialBalance.AutoSize = true;
            this.lblInitialBalance.Location = new System.Drawing.Point(13, 9);
            this.lblInitialBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitialBalance.Name = "lblInitialBalance";
            this.lblInitialBalance.Size = new System.Drawing.Size(191, 16);
            this.lblInitialBalance.TabIndex = 2;
            this.lblInitialBalance.Text = "Введите начальный баланс:";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 115);
            this.Controls.Add(this.lblInitialBalance);
            this.Controls.Add(this.txtInitialBalance);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartForm";
            this.Text = "Start Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
