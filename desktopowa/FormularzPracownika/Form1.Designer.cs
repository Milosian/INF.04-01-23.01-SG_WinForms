namespace FormularzPracownika
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            workerDataGroupBox = new GroupBox();
            stateBox = new ComboBox();
            label1 = new Label();
            surnameTB = new TextBox();
            surnameLbl = new Label();
            nameTB = new TextBox();
            nameLbl = new Label();
            passwordGeneratorGroupBox = new GroupBox();
            generateBtn = new Button();
            specialCharacterCheckBox = new CheckBox();
            numberCheckBox = new CheckBox();
            smallBigLetterCheckBox = new CheckBox();
            signsAmountTB = new TextBox();
            label4 = new Label();
            acceptBtn = new Button();
            workerDataGroupBox.SuspendLayout();
            passwordGeneratorGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // workerDataGroupBox
            // 
            workerDataGroupBox.Controls.Add(stateBox);
            workerDataGroupBox.Controls.Add(label1);
            workerDataGroupBox.Controls.Add(surnameTB);
            workerDataGroupBox.Controls.Add(surnameLbl);
            workerDataGroupBox.Controls.Add(nameTB);
            workerDataGroupBox.Controls.Add(nameLbl);
            workerDataGroupBox.Location = new Point(19, 29);
            workerDataGroupBox.Margin = new Padding(10, 3, 3, 3);
            workerDataGroupBox.Name = "workerDataGroupBox";
            workerDataGroupBox.Size = new Size(297, 192);
            workerDataGroupBox.TabIndex = 0;
            workerDataGroupBox.TabStop = false;
            workerDataGroupBox.Text = "Dane pracownika";
            // 
            // stateBox
            // 
            stateBox.FormattingEnabled = true;
            stateBox.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            stateBox.Location = new Point(138, 115);
            stateBox.Name = "stateBox";
            stateBox.Size = new Size(132, 23);
            stateBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 123);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "Stanowisko";
            // 
            // surnameTB
            // 
            surnameTB.Location = new Point(138, 76);
            surnameTB.Name = "surnameTB";
            surnameTB.Size = new Size(132, 23);
            surnameTB.TabIndex = 3;
            // 
            // surnameLbl
            // 
            surnameLbl.AutoSize = true;
            surnameLbl.Location = new Point(19, 79);
            surnameLbl.Name = "surnameLbl";
            surnameLbl.Size = new Size(57, 15);
            surnameLbl.TabIndex = 2;
            surnameLbl.Text = "Nazwisko";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(138, 30);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(132, 23);
            nameTB.TabIndex = 1;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(19, 33);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(30, 15);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Imię";
            // 
            // passwordGeneratorGroupBox
            // 
            passwordGeneratorGroupBox.Controls.Add(generateBtn);
            passwordGeneratorGroupBox.Controls.Add(specialCharacterCheckBox);
            passwordGeneratorGroupBox.Controls.Add(numberCheckBox);
            passwordGeneratorGroupBox.Controls.Add(smallBigLetterCheckBox);
            passwordGeneratorGroupBox.Controls.Add(signsAmountTB);
            passwordGeneratorGroupBox.Controls.Add(label4);
            passwordGeneratorGroupBox.Location = new Point(391, 29);
            passwordGeneratorGroupBox.Margin = new Padding(10, 3, 3, 3);
            passwordGeneratorGroupBox.Name = "passwordGeneratorGroupBox";
            passwordGeneratorGroupBox.Size = new Size(297, 192);
            passwordGeneratorGroupBox.TabIndex = 5;
            passwordGeneratorGroupBox.TabStop = false;
            passwordGeneratorGroupBox.Text = "Generowanie haseł";
            // 
            // generateBtn
            // 
            generateBtn.BackColor = Color.SteelBlue;
            generateBtn.ForeColor = Color.White;
            generateBtn.Location = new Point(98, 157);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(89, 23);
            generateBtn.TabIndex = 5;
            generateBtn.Text = "Generuj hasło";
            generateBtn.UseVisualStyleBackColor = false;
            generateBtn.Click += generateBtn_Click;
            // 
            // specialCharacterCheckBox
            // 
            specialCharacterCheckBox.AutoSize = true;
            specialCharacterCheckBox.Location = new Point(19, 126);
            specialCharacterCheckBox.Name = "specialCharacterCheckBox";
            specialCharacterCheckBox.Size = new Size(107, 19);
            specialCharacterCheckBox.TabIndex = 4;
            specialCharacterCheckBox.Text = "Znaki specjalne";
            specialCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // numberCheckBox
            // 
            numberCheckBox.AutoSize = true;
            numberCheckBox.Location = new Point(19, 101);
            numberCheckBox.Name = "numberCheckBox";
            numberCheckBox.Size = new Size(54, 19);
            numberCheckBox.TabIndex = 3;
            numberCheckBox.Text = "Cyfry";
            numberCheckBox.UseVisualStyleBackColor = true;
            // 
            // smallBigLetterCheckBox
            // 
            smallBigLetterCheckBox.AutoSize = true;
            smallBigLetterCheckBox.Location = new Point(19, 76);
            smallBigLetterCheckBox.Name = "smallBigLetterCheckBox";
            smallBigLetterCheckBox.Size = new Size(120, 19);
            smallBigLetterCheckBox.TabIndex = 2;
            smallBigLetterCheckBox.Text = "Małe wielkie litery";
            smallBigLetterCheckBox.UseVisualStyleBackColor = true;
            // 
            // signsAmountTB
            // 
            signsAmountTB.Location = new Point(138, 30);
            signsAmountTB.Name = "signsAmountTB";
            signsAmountTB.Size = new Size(132, 23);
            signsAmountTB.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 33);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 0;
            label4.Text = "Ile znaków?";
            // 
            // acceptBtn
            // 
            acceptBtn.BackColor = Color.SteelBlue;
            acceptBtn.ForeColor = Color.White;
            acceptBtn.Location = new Point(267, 239);
            acceptBtn.Name = "acceptBtn";
            acceptBtn.Size = new Size(173, 23);
            acceptBtn.TabIndex = 6;
            acceptBtn.Text = "Zatwierdź";
            acceptBtn.UseVisualStyleBackColor = false;
            acceptBtn.Click += acceptBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(709, 277);
            Controls.Add(acceptBtn);
            Controls.Add(passwordGeneratorGroupBox);
            Controls.Add(workerDataGroupBox);
            Name = "Form1";
            Text = "Dodaj Pracownika";
            workerDataGroupBox.ResumeLayout(false);
            workerDataGroupBox.PerformLayout();
            passwordGeneratorGroupBox.ResumeLayout(false);
            passwordGeneratorGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox workerDataGroupBox;
        private TextBox surnameTB;
        private Label surnameLbl;
        private TextBox nameTB;
        private Label nameLbl;
        private ComboBox stateBox;
        private Label label1;
        private GroupBox passwordGeneratorGroupBox;
        private TextBox signsAmountTB;
        private Label label4;
        private Button acceptBtn;
        private Button generateBtn;
        private CheckBox specialCharacterCheckBox;
        private CheckBox numberCheckBox;
        private CheckBox smallBigLetterCheckBox;
    }
}
