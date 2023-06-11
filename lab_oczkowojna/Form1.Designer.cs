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
            this.restartButton = new System.Windows.Forms.Button();
            this.playerCardPictureBox = new System.Windows.Forms.PictureBox();
            this.computerCardPictureBox = new System.Windows.Forms.PictureBox();
            this.playerWarCardPictureBox = new System.Windows.Forms.PictureBox();
            this.computerWarCardPictureBox = new System.Windows.Forms.PictureBox();
            this.playerCardsLabel = new System.Windows.Forms.Label();
            this.computerCardsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerWarCardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerWarCardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wojna
            // 
            this.wojna.AutoSize = true;
            this.wojna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wojna.Location = new System.Drawing.Point(19, 59);
            this.wojna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wojna.Name = "wojna";
            this.wojna.Size = new System.Drawing.Size(113, 29);
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
            this.oczko.Location = new System.Drawing.Point(19, 89);
            this.oczko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oczko.Name = "oczko";
            this.oczko.Size = new System.Drawing.Size(111, 29);
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
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz grę";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(181, 139);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(88, 61);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(134, 208);
            this.restartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(135, 39);
            this.restartButton.TabIndex = 4;
            this.restartButton.Text = "RESTART";
            this.restartButton.UseVisualStyleBackColor = true;
            // 
            // playerCardPictureBox
            // 
            this.playerCardPictureBox.Location = new System.Drawing.Point(515, 105);
            this.playerCardPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playerCardPictureBox.Name = "playerCardPictureBox";
            this.playerCardPictureBox.Size = new System.Drawing.Size(189, 385);
            this.playerCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerCardPictureBox.TabIndex = 5;
            this.playerCardPictureBox.TabStop = false;
            // 
            // computerCardPictureBox
            // 
            this.computerCardPictureBox.Location = new System.Drawing.Point(304, 105);
            this.computerCardPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.computerCardPictureBox.Name = "computerCardPictureBox";
            this.computerCardPictureBox.Size = new System.Drawing.Size(189, 385);
            this.computerCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerCardPictureBox.TabIndex = 6;
            this.computerCardPictureBox.TabStop = false;
            // 
            // playerWarCardPictureBox
            // 
            this.playerWarCardPictureBox.Location = new System.Drawing.Point(40, 359);
            this.playerWarCardPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playerWarCardPictureBox.Name = "playerWarCardPictureBox";
            this.playerWarCardPictureBox.Size = new System.Drawing.Size(228, 84);
            this.playerWarCardPictureBox.TabIndex = 7;
            this.playerWarCardPictureBox.TabStop = false;
            // 
            // computerWarCardPictureBox
            // 
            this.computerWarCardPictureBox.Location = new System.Drawing.Point(156, 275);
            this.computerWarCardPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.computerWarCardPictureBox.Name = "computerWarCardPictureBox";
            this.computerWarCardPictureBox.Size = new System.Drawing.Size(112, 62);
            this.computerWarCardPictureBox.TabIndex = 8;
            this.computerWarCardPictureBox.TabStop = false;
            // 
            // playerCardsLabel
            // 
            this.playerCardsLabel.AutoSize = true;
            this.playerCardsLabel.Location = new System.Drawing.Point(307, 509);
            this.playerCardsLabel.Name = "playerCardsLabel";
            this.playerCardsLabel.Size = new System.Drawing.Size(98, 20);
            this.playerCardsLabel.TabIndex = 9;
            this.playerCardsLabel.Text = "Player Cards";
            // 
            // computerCardsLabel
            // 
            this.computerCardsLabel.AutoSize = true;
            this.computerCardsLabel.Location = new System.Drawing.Point(512, 509);
            this.computerCardsLabel.Name = "computerCardsLabel";
            this.computerCardsLabel.Size = new System.Drawing.Size(121, 20);
            this.computerCardsLabel.TabIndex = 10;
            this.computerCardsLabel.Text = "ComputerCards";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1659, 1050);
            this.Controls.Add(this.computerCardsLabel);
            this.Controls.Add(this.playerCardsLabel);
            this.Controls.Add(this.computerWarCardPictureBox);
            this.Controls.Add(this.playerWarCardPictureBox);
            this.Controls.Add(this.computerCardPictureBox);
            this.Controls.Add(this.playerCardPictureBox);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oczko);
            this.Controls.Add(this.wojna);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "WOJNA LUB OCZKO ;)";
            ((System.ComponentModel.ISupportInitialize)(this.playerCardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerWarCardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerWarCardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton wojna;
        private System.Windows.Forms.RadioButton oczko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.PictureBox playerCardPictureBox;
        private System.Windows.Forms.PictureBox computerCardPictureBox;
        private System.Windows.Forms.PictureBox playerWarCardPictureBox;
        private System.Windows.Forms.PictureBox computerWarCardPictureBox;
        private System.Windows.Forms.Label playerCardsLabel;
        private System.Windows.Forms.Label computerCardsLabel;
    }
}

