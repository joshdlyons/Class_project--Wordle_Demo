namespace CSC102_Final_Project
{
    partial class Wordle
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
            this.enterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.debugPanel = new System.Windows.Forms.Panel();
            this.debugLabel = new System.Windows.Forms.Label();
            this.loadNewWordButton = new System.Windows.Forms.Button();
            this.reloadWordButton = new System.Windows.Forms.Button();
            this.setNewWordButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.newWordTextBox = new System.Windows.Forms.TextBox();
            this.debugPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.Control;
            this.enterButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(30, 445);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(50, 42);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "ENTER";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(336, 445);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 42);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // debugPanel
            // 
            this.debugPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.debugPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debugPanel.Controls.Add(this.debugLabel);
            this.debugPanel.Controls.Add(this.loadNewWordButton);
            this.debugPanel.Controls.Add(this.reloadWordButton);
            this.debugPanel.Controls.Add(this.setNewWordButton);
            this.debugPanel.Controls.Add(this.instructionLabel);
            this.debugPanel.Controls.Add(this.newWordTextBox);
            this.debugPanel.Location = new System.Drawing.Point(30, 493);
            this.debugPanel.Name = "debugPanel";
            this.debugPanel.Size = new System.Drawing.Size(356, 120);
            this.debugPanel.TabIndex = 3;
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugLabel.Location = new System.Drawing.Point(135, 2);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(79, 13);
            this.debugLabel.TabIndex = 5;
            this.debugLabel.Text = "Debug Menu";
            // 
            // loadNewWordButton
            // 
            this.loadNewWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadNewWordButton.Location = new System.Drawing.Point(200, 69);
            this.loadNewWordButton.Name = "loadNewWordButton";
            this.loadNewWordButton.Size = new System.Drawing.Size(112, 36);
            this.loadNewWordButton.TabIndex = 4;
            this.loadNewWordButton.Text = "LOAD NEW RANDOM WORD";
            this.loadNewWordButton.UseVisualStyleBackColor = true;
            this.loadNewWordButton.Click += new System.EventHandler(this.loadNewWordButton_Click);
            // 
            // reloadWordButton
            // 
            this.reloadWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadWordButton.Location = new System.Drawing.Point(200, 22);
            this.reloadWordButton.Name = "reloadWordButton";
            this.reloadWordButton.Size = new System.Drawing.Size(112, 36);
            this.reloadWordButton.TabIndex = 3;
            this.reloadWordButton.Text = "RELOAD CURRENT WORD";
            this.reloadWordButton.UseVisualStyleBackColor = true;
            this.reloadWordButton.Click += new System.EventHandler(this.reloadWordButton_Click);
            // 
            // setNewWordButton
            // 
            this.setNewWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setNewWordButton.Location = new System.Drawing.Point(40, 80);
            this.setNewWordButton.Name = "setNewWordButton";
            this.setNewWordButton.Size = new System.Drawing.Size(115, 25);
            this.setNewWordButton.TabIndex = 2;
            this.setNewWordButton.Text = "SET AS NEW WORD";
            this.setNewWordButton.UseVisualStyleBackColor = true;
            this.setNewWordButton.Click += new System.EventHandler(this.setNewWordButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Enabled = false;
            this.instructionLabel.Location = new System.Drawing.Point(40, 15);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(115, 36);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Enter a new set of five letters as the word.";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newWordTextBox
            // 
            this.newWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newWordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.newWordTextBox.Location = new System.Drawing.Point(40, 54);
            this.newWordTextBox.Name = "newWordTextBox";
            this.newWordTextBox.Size = new System.Drawing.Size(115, 20);
            this.newWordTextBox.TabIndex = 0;
            // 
            // Wordle
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 629);
            this.Controls.Add(this.debugPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.enterButton);
            this.KeyPreview = true;
            this.Name = "Wordle";
            this.Text = "Wordle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Wordle_KeyDown);
            this.debugPanel.ResumeLayout(false);
            this.debugPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel debugPanel;
        private System.Windows.Forms.Button loadNewWordButton;
        private System.Windows.Forms.Button reloadWordButton;
        private System.Windows.Forms.Button setNewWordButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox newWordTextBox;
        private System.Windows.Forms.Label debugLabel;
    }
}

