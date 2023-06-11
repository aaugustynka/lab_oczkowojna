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
            this.lblPlayer1Card = new System.Windows.Forms.Label();
            this.txtPlayer1Cards = new System.Windows.Forms.TextBox();
            this.txtPlayer2Cards = new System.Windows.Forms.TextBox();
            this.lblPlayer2Card = new System.Windows.Forms.Label();
            this.lblWarInfo = new System.Windows.Forms.Label();
            this.kartyys = new System.Windows.Forms.Label();
            this.kyst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wojna
            // 
            this.wojna.AutoSize = true;
            this.wojna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wojna.Location = new System.Drawing.Point(17, 43);
            this.wojna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wojna.Name = "wojna";
            this.wojna.Size = new System.Drawing.Size(91, 24);
            this.wojna.TabIndex = 0;
            this.wojna.TabStop = true;
            this.wojna.Text = "WOJNA";
            this.wojna.UseVisualStyleBackColor = true;
            this.wojna.CheckedChanged += new System.EventHandler(this.wojna_CheckedChanged_1);
            // 
            // oczko
            // 
            this.oczko.AutoSize = true;
            this.oczko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oczko.Location = new System.Drawing.Point(17, 71);
            this.oczko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oczko.Name = "oczko";
            this.oczko.Size = new System.Drawing.Size(88, 24);
            this.oczko.TabIndex = 1;
            this.oczko.TabStop = true;
            this.oczko.Text = "OCZKO";
            this.oczko.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz grę";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Plum;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playButton.Location = new System.Drawing.Point(164, 47);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(127, 48);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // lblPlayer1Card
            // 
            this.lblPlayer1Card.AutoSize = true;
            this.lblPlayer1Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayer1Card.Location = new System.Drawing.Point(344, 110);
            this.lblPlayer1Card.Name = "lblPlayer1Card";
            this.lblPlayer1Card.Size = new System.Drawing.Size(78, 20);
            this.lblPlayer1Card.TabIndex = 11;
            this.lblPlayer1Card.Text = "Player 1";
            this.lblPlayer1Card.Click += new System.EventHandler(this.lblPlayer1Card_Click);
            // 
            // txtPlayer1Cards
            // 
            this.txtPlayer1Cards.Location = new System.Drawing.Point(348, 133);
            this.txtPlayer1Cards.Name = "txtPlayer1Cards";
            this.txtPlayer1Cards.Size = new System.Drawing.Size(228, 22);
            this.txtPlayer1Cards.TabIndex = 13;
            this.txtPlayer1Cards.TextChanged += new System.EventHandler(this.txtPlayer1Cards_TextChanged);
            // 
            // txtPlayer2Cards
            // 
            this.txtPlayer2Cards.Location = new System.Drawing.Point(649, 133);
            this.txtPlayer2Cards.Name = "txtPlayer2Cards";
            this.txtPlayer2Cards.Size = new System.Drawing.Size(234, 22);
            this.txtPlayer2Cards.TabIndex = 14;
            this.txtPlayer2Cards.TextChanged += new System.EventHandler(this.txtPlayer2Cards_TextChanged);
            // 
            // lblPlayer2Card
            // 
            this.lblPlayer2Card.AutoSize = true;
            this.lblPlayer2Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayer2Card.Location = new System.Drawing.Point(645, 110);
            this.lblPlayer2Card.Name = "lblPlayer2Card";
            this.lblPlayer2Card.Size = new System.Drawing.Size(78, 20);
            this.lblPlayer2Card.TabIndex = 12;
            this.lblPlayer2Card.Text = "Player 2";
            this.lblPlayer2Card.Click += new System.EventHandler(this.lblPlayer2Card_Click);
            // 
            // lblWarInfo
            // 
            this.lblWarInfo.AutoSize = true;
            this.lblWarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWarInfo.Location = new System.Drawing.Point(590, 47);
            this.lblWarInfo.Name = "lblWarInfo";
            this.lblWarInfo.Size = new System.Drawing.Size(0, 25);
            this.lblWarInfo.TabIndex = 15;
            this.lblWarInfo.Click += new System.EventHandler(this.lblWarInfo_Click);
            // 
            // kartyys
            // 
            this.kartyys.AutoSize = true;
            this.kartyys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kartyys.Location = new System.Drawing.Point(345, 158);
            this.kartyys.Name = "kartyys";
            this.kartyys.Size = new System.Drawing.Size(126, 18);
            this.kartyys.TabIndex = 16;
            this.kartyys.Text = "Pozostałe karty";
            // 
            // kyst
            // 
            this.kyst.AutoSize = true;
            this.kyst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kyst.Location = new System.Drawing.Point(646, 158);
            this.kyst.Name = "kyst";
            this.kyst.Size = new System.Drawing.Size(126, 18);
            this.kyst.TabIndex = 17;
            this.kyst.Text = "Pozostałe karty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1475, 990);
            this.Controls.Add(this.kyst);
            this.Controls.Add(this.kartyys);
            this.Controls.Add(this.lblWarInfo);
            this.Controls.Add(this.txtPlayer2Cards);
            this.Controls.Add(this.txtPlayer1Cards);
            this.Controls.Add(this.lblPlayer2Card);
            this.Controls.Add(this.lblPlayer1Card);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oczko);
            this.Controls.Add(this.wojna);
            this.Name = "Form1";
            this.Text = "WOJNA LUB OCZKO ;)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton wojna;
        private System.Windows.Forms.RadioButton oczko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label lblPlayer1Card;
        private System.Windows.Forms.TextBox txtPlayer1Cards;
        private System.Windows.Forms.TextBox txtPlayer2Cards;
        private System.Windows.Forms.Label lblPlayer2Card;
        private System.Windows.Forms.Label lblWarInfo;
        private System.Windows.Forms.Label kartyys;
        private System.Windows.Forms.Label kyst;
    }
}

