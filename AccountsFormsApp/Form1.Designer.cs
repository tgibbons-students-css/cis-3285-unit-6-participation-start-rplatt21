namespace AccountsFormsApp
{
    partial class Form1
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
            this.WellsFargoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accNameText = new System.Windows.Forms.TextBox();
            this.AccountBalTextBox = new System.Windows.Forms.TextBox();
            this.DepositTextBox = new System.Windows.Forms.TextBox();
            this.WithTextBox = new System.Windows.Forms.TextBox();
            this.AccountBalanceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentAccountListBox1 = new System.Windows.Forms.ListBox();
            this.AddButton1 = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WellsFargoLabel
            // 
            this.WellsFargoLabel.AutoSize = true;
            this.WellsFargoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WellsFargoLabel.Location = new System.Drawing.Point(58, 66);
            this.WellsFargoLabel.Name = "WellsFargoLabel";
            this.WellsFargoLabel.Size = new System.Drawing.Size(264, 25);
            this.WellsFargoLabel.TabIndex = 0;
            this.WellsFargoLabel.Text = "Wells Fargo Account Creator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Account Name";
            // 
            // accNameText
            // 
            this.accNameText.Location = new System.Drawing.Point(64, 130);
            this.accNameText.Name = "accNameText";
            this.accNameText.Size = new System.Drawing.Size(100, 20);
            this.accNameText.TabIndex = 2;
            // 
            // AccountBalTextBox
            // 
            this.AccountBalTextBox.Location = new System.Drawing.Point(431, 129);
            this.AccountBalTextBox.Name = "AccountBalTextBox";
            this.AccountBalTextBox.Size = new System.Drawing.Size(100, 20);
            this.AccountBalTextBox.TabIndex = 3;
            // 
            // DepositTextBox
            // 
            this.DepositTextBox.Location = new System.Drawing.Point(431, 234);
            this.DepositTextBox.Name = "DepositTextBox";
            this.DepositTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepositTextBox.TabIndex = 4;
            // 
            // WithTextBox
            // 
            this.WithTextBox.Location = new System.Drawing.Point(431, 275);
            this.WithTextBox.Name = "WithTextBox";
            this.WithTextBox.Size = new System.Drawing.Size(100, 20);
            this.WithTextBox.TabIndex = 5;
            // 
            // AccountBalanceLabel
            // 
            this.AccountBalanceLabel.AutoSize = true;
            this.AccountBalanceLabel.Location = new System.Drawing.Point(428, 100);
            this.AccountBalanceLabel.Name = "AccountBalanceLabel";
            this.AccountBalanceLabel.Size = new System.Drawing.Size(89, 13);
            this.AccountBalanceLabel.TabIndex = 6;
            this.AccountBalanceLabel.Text = "Account Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Accounts";
            // 
            // CurrentAccountListBox1
            // 
            this.CurrentAccountListBox1.FormattingEnabled = true;
            this.CurrentAccountListBox1.Location = new System.Drawing.Point(61, 234);
            this.CurrentAccountListBox1.Name = "CurrentAccountListBox1";
            this.CurrentAccountListBox1.Size = new System.Drawing.Size(120, 95);
            this.CurrentAccountListBox1.TabIndex = 9;
            this.CurrentAccountListBox1.SelectedIndexChanged += new System.EventHandler(this.CurrentAccountListBox1_SelectedIndexChanged);
            // 
            // AddButton1
            // 
            this.AddButton1.Location = new System.Drawing.Point(67, 157);
            this.AddButton1.Name = "AddButton1";
            this.AddButton1.Size = new System.Drawing.Size(75, 23);
            this.AddButton1.TabIndex = 10;
            this.AddButton1.Text = "Add Account";
            this.AddButton1.UseVisualStyleBackColor = true;
            this.AddButton1.Click += new System.EventHandler(this.AddButton1_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(349, 230);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(75, 23);
            this.DepositButton.TabIndex = 11;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawalButton
            // 
            this.WithdrawalButton.Location = new System.Drawing.Point(349, 273);
            this.WithdrawalButton.Name = "WithdrawalButton";
            this.WithdrawalButton.Size = new System.Drawing.Size(75, 23);
            this.WithdrawalButton.TabIndex = 12;
            this.WithdrawalButton.Text = "Withdrawal";
            this.WithdrawalButton.UseVisualStyleBackColor = true;
            this.WithdrawalButton.Click += new System.EventHandler(this.WithdrawalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WithdrawalButton);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.AddButton1);
            this.Controls.Add(this.CurrentAccountListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccountBalanceLabel);
            this.Controls.Add(this.WithTextBox);
            this.Controls.Add(this.DepositTextBox);
            this.Controls.Add(this.AccountBalTextBox);
            this.Controls.Add(this.accNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WellsFargoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WellsFargoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accNameText;
        private System.Windows.Forms.TextBox AccountBalTextBox;
        private System.Windows.Forms.TextBox DepositTextBox;
        private System.Windows.Forms.TextBox WithTextBox;
        private System.Windows.Forms.Label AccountBalanceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox CurrentAccountListBox1;
        private System.Windows.Forms.Button AddButton1;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button WithdrawalButton;
    }
}

