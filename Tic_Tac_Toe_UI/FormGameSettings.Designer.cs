using System.Windows.Forms;

namespace Tic_Tac_Toe_WindowGame
{
    partial class FormGameSettings
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
            this.labelHeadingPlayers = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.textBoxPlayer1Name = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2Name = new System.Windows.Forms.TextBox();
            this.labelHeadingBoardSize = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.numericUpDownRowNumber = new System.Windows.Forms.NumericUpDown();
            this.labelColumns = new System.Windows.Forms.Label();
            this.numericUpDownColumnNumber = new System.Windows.Forms.NumericUpDown();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeadingPlayers
            // 
            this.labelHeadingPlayers.AutoSize = true;
            this.labelHeadingPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadingPlayers.Location = new System.Drawing.Point(9, 7);
            this.labelHeadingPlayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeadingPlayers.Name = "labelHeadingPlayers";
            this.labelHeadingPlayers.Size = new System.Drawing.Size(67, 17);
            this.labelHeadingPlayers.TabIndex = 0;
            this.labelHeadingPlayers.Text = "Players:";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.Location = new System.Drawing.Point(32, 31);
            this.labelPlayer1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(64, 17);
            this.labelPlayer1.TabIndex = 2;
            this.labelPlayer1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Playes1";
            // 
            // checkBoxPlayer2
            // 
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPlayer2.Location = new System.Drawing.Point(34, 54);
            this.checkBoxPlayer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(83, 21);
            this.checkBoxPlayer2.TabIndex = 4;
            this.checkBoxPlayer2.Text = "Player 2:";
            this.checkBoxPlayer2.UseVisualStyleBackColor = true;
            this.checkBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBoxPlayer2_CheckedChanged);
            // 
            // textBoxPlayer1Name
            // 
            this.textBoxPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer1Name.Location = new System.Drawing.Point(112, 28);
            this.textBoxPlayer1Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPlayer1Name.Name = "textBoxPlayer1Name";
            this.textBoxPlayer1Name.Size = new System.Drawing.Size(122, 21);
            this.textBoxPlayer1Name.TabIndex = 5;
            // 
            // textBoxPlayer2Name
            // 
            this.textBoxPlayer2Name.AcceptsReturn = true;
            this.textBoxPlayer2Name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPlayer2Name.Enabled = false;
            this.textBoxPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer2Name.Location = new System.Drawing.Point(112, 52);
            this.textBoxPlayer2Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPlayer2Name.Name = "textBoxPlayer2Name";
            this.textBoxPlayer2Name.Size = new System.Drawing.Size(122, 21);
            this.textBoxPlayer2Name.TabIndex = 6;
            this.textBoxPlayer2Name.Text = "[computer]";
            // 
            // labelHeadingBoardSize
            // 
            this.labelHeadingBoardSize.AutoSize = true;
            this.labelHeadingBoardSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadingBoardSize.Location = new System.Drawing.Point(9, 98);
            this.labelHeadingBoardSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeadingBoardSize.Name = "labelHeadingBoardSize";
            this.labelHeadingBoardSize.Size = new System.Drawing.Size(92, 17);
            this.labelHeadingBoardSize.TabIndex = 7;
            this.labelHeadingBoardSize.Text = "Board Size:";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRows.Location = new System.Drawing.Point(32, 126);
            this.labelRows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(46, 17);
            this.labelRows.TabIndex = 8;
            this.labelRows.Text = "Rows:";
            // 
            // numericUpDownRowNumber
            // 
            this.numericUpDownRowNumber.Location = new System.Drawing.Point(78, 124);
            this.numericUpDownRowNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownRowNumber.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownRowNumber.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRowNumber.Name = "numericUpDownRowNumber";
            this.numericUpDownRowNumber.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownRowNumber.TabIndex = 9;
            this.numericUpDownRowNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRowNumber.ValueChanged += new System.EventHandler(this.numericUpDownRowNumber_ValueChanged);
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumns.Location = new System.Drawing.Point(134, 126);
            this.labelColumns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(66, 17);
            this.labelColumns.TabIndex = 10;
            this.labelColumns.Text = "Columns:";
            // 
            // numericUpDownColumnNumber
            // 
            this.numericUpDownColumnNumber.Location = new System.Drawing.Point(199, 124);
            this.numericUpDownColumnNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownColumnNumber.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownColumnNumber.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownColumnNumber.Name = "numericUpDownColumnNumber";
            this.numericUpDownColumnNumber.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownColumnNumber.TabIndex = 11;
            this.numericUpDownColumnNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownColumnNumber.ValueChanged += new System.EventHandler(this.numericUpDownColumnNumber_ValueChanged);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(34, 168);
            this.buttonStartGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(172, 28);
            this.buttonStartGame.TabIndex = 12;
            this.buttonStartGame.Text = "Start!";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // FormGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 206);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.numericUpDownColumnNumber);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.numericUpDownRowNumber);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.labelHeadingBoardSize);
            this.Controls.Add(this.textBoxPlayer2Name);
            this.Controls.Add(this.textBoxPlayer1Name);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelHeadingPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeadingPlayers;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPlayer2;
        private System.Windows.Forms.TextBox textBoxPlayer1Name;
        private System.Windows.Forms.TextBox textBoxPlayer2Name;
        private System.Windows.Forms.Label labelHeadingBoardSize;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.NumericUpDown numericUpDownRowNumber;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.NumericUpDown numericUpDownColumnNumber;
        private System.Windows.Forms.Button buttonStartGame;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

