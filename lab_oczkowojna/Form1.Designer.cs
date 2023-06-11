namespace lab_oczkowojna
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.wojna = new System.Windows.Forms.RadioButton();
            this.oczko = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.lblPlayer1Cards = new System.Windows.Forms.Label();
            this.lblPlayer2Cards = new System.Windows.Forms.Label();
            this.txtPlayer1Cards = new System.Windows.Forms.TextBox();
            this.txtPlayer2Cards = new System.Windows.Forms.TextBox();
            this.lblWarInfo = new System.Windows.Forms.Label();
            this.lblPlayer1Card = new System.Windows.Forms.Label();
            this.lblPlayer2Card = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.addCardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wojna
            // 
            this.wojna.AutoSize = true;
            this.wojna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wojna.Location = new System.Drawing.Point(11, 31);
            this.wojna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wojna.Name = "wojna";
            this.wojna.Size = new System.Drawing.Size(76, 21);
            this.wojna.TabIndex = 0;
            this.wojna.TabStop = true;
            this.wojna.Text = "WOJNA";
            this.wojna.UseVisualStyleBackColor = true;
            this.wojna.CheckedChanged += new System.EventHandler(this.wojna_CheckedChanged);
            // 
            // oczko
            // 
            this.oczko.AutoSize = true;
            this.oczko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oczko.Location = new System.Drawing.Point(13, 58);
            this.oczko.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oczko.Name = "oczko";
            this.oczko.Size = new System.Drawing.Size(75, 21);
            this.oczko.TabIndex = 1;
            this.oczko.TabStop = true;
            this.oczko.Text = "OCZKO";
            this.oczko.UseVisualStyleBackColor = true;
            this.oczko.CheckedChanged += new System.EventHandler(this.oczko_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz grę";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Violet;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playButton.Location = new System.Drawing.Point(104, 37);
            this.playButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(92, 40);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // lblPlayer1Cards
            // 
            this.lblPlayer1Cards.AutoSize = true;
            this.lblPlayer1Cards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayer1Cards.Location = new System.Drawing.Point(218, 84);
            this.lblPlayer1Cards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer1Cards.Name = "lblPlayer1Cards";
            this.lblPlayer1Cards.Size = new System.Drawing.Size(120, 17);
            this.lblPlayer1Cards.TabIndex = 9;
            this.lblPlayer1Cards.Text = "Pozostałe karty";
            this.lblPlayer1Cards.Click += new System.EventHandler(this.lblPlayer1Cards_Click);
            // 
            // lblPlayer2Cards
            // 
            this.lblPlayer2Cards.AutoSize = true;
            this.lblPlayer2Cards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayer2Cards.Location = new System.Drawing.Point(418, 84);
            this.lblPlayer2Cards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer2Cards.Name = "lblPlayer2Cards";
            this.lblPlayer2Cards.Size = new System.Drawing.Size(120, 17);
            this.lblPlayer2Cards.TabIndex = 10;
            this.lblPlayer2Cards.Text = "Pozostałe karty";
            this.lblPlayer2Cards.Click += new System.EventHandler(this.lblPlayer2Cards_Click);
            // 
            // txtPlayer1Cards
            // 
            this.txtPlayer1Cards.Location = new System.Drawing.Point(221, 64);
            this.txtPlayer1Cards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlayer1Cards.Name = "txtPlayer1Cards";
            this.txtPlayer1Cards.Size = new System.Drawing.Size(142, 20);
            this.txtPlayer1Cards.TabIndex = 11;
            this.txtPlayer1Cards.TextChanged += new System.EventHandler(this.txtPlayer1Cards_TextChanged);
            // 
            // txtPlayer2Cards
            // 
            this.txtPlayer2Cards.Location = new System.Drawing.Point(421, 64);
            this.txtPlayer2Cards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlayer2Cards.Name = "txtPlayer2Cards";
            this.txtPlayer2Cards.Size = new System.Drawing.Size(142, 20);
            this.txtPlayer2Cards.TabIndex = 12;
            this.txtPlayer2Cards.TextChanged += new System.EventHandler(this.txtPlayer2Cards_TextChanged);
            // 
            // lblWarInfo
            // 
            this.lblWarInfo.AutoSize = true;
            this.lblWarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWarInfo.Location = new System.Drawing.Point(370, 31);
            this.lblWarInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarInfo.Name = "lblWarInfo";
            this.lblWarInfo.Size = new System.Drawing.Size(0, 18);
            this.lblWarInfo.TabIndex = 13;
            this.lblWarInfo.Click += new System.EventHandler(this.lblWarInfo_Click);
            // 
            // lblPlayer1Card
            // 
            this.lblPlayer1Card.AutoSize = true;
            this.lblPlayer1Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayer1Card.Location = new System.Drawing.Point(219, 47);
            this.lblPlayer1Card.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer1Card.Name = "lblPlayer1Card";
            this.lblPlayer1Card.Size = new System.Drawing.Size(0, 15);
            this.lblPlayer1Card.TabIndex = 14;
            this.lblPlayer1Card.Click += new System.EventHandler(this.lblPlayer1Card_Click);
            // 
            // lblPlayer2Card
            // 
            this.lblPlayer2Card.AutoSize = true;
            this.lblPlayer2Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayer2Card.Location = new System.Drawing.Point(418, 47);
            this.lblPlayer2Card.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer2Card.Name = "lblPlayer2Card";
            this.lblPlayer2Card.Size = new System.Drawing.Size(0, 15);
            this.lblPlayer2Card.TabIndex = 15;
            this.lblPlayer2Card.Click += new System.EventHandler(this.lblPlayer2Card_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Violet;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopButton.Location = new System.Drawing.Point(104, 93);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(92, 40);
            this.stopButton.TabIndex = 16;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // addCardButton
            // 
            this.addCardButton.BackColor = System.Drawing.Color.Violet;
            this.addCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addCardButton.Location = new System.Drawing.Point(104, 158);
            this.addCardButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(92, 40);
            this.addCardButton.TabIndex = 17;
            this.addCardButton.Text = "ADD CARD";
            this.addCardButton.UseVisualStyleBackColor = false;
            this.addCardButton.Visible = false;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(983, 644);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.lblPlayer2Card);
            this.Controls.Add(this.lblPlayer1Card);
            this.Controls.Add(this.lblWarInfo);
            this.Controls.Add(this.txtPlayer2Cards);
            this.Controls.Add(this.txtPlayer1Cards);
            this.Controls.Add(this.lblPlayer2Cards);
            this.Controls.Add(this.lblPlayer1Cards);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oczko);
            this.Controls.Add(this.wojna);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "WOJNA LUB OCZKO ;)";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton wojna;
        private System.Windows.Forms.RadioButton oczko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label lblPlayer1Cards;
        private System.Windows.Forms.Label lblPlayer2Cards;
        private System.Windows.Forms.TextBox txtPlayer1Cards;
        private System.Windows.Forms.TextBox txtPlayer2Cards;
        private System.Windows.Forms.Label lblWarInfo;
        private System.Windows.Forms.Label lblPlayer1Card;
        private System.Windows.Forms.Label lblPlayer2Card;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button addCardButton;
    }
}

