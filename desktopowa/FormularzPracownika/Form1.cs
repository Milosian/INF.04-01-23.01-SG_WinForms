namespace FormularzPracownika
{
    public partial class Form1 : Form
    {
        public string password = "";
        public Form1()
        {
            InitializeComponent();
        }

        private static string CreatePassword(bool BigLettersCheck, bool NumbersCheck, bool SpecialCharactersCheck, int length)
        {
            string smallLetters = "abcdefghijklmnoprstuwxyz";
            string bigLetters = "ABCDEFGHIJKLMNOPRSTUWXYZ";
            string specialCharacters = "!@#$%^&*()_+-=";
            string password = "";

            Random random = new Random();
            while(password.Length < length)
            {
                password += smallLetters[random.Next(0, smallLetters.Length)];
                if (BigLettersCheck == true && password.Length < length)
                {
                    password += bigLetters[random.Next(0, bigLetters.Length)];
                }
                if (NumbersCheck == true && password.Length < length)
                {
                    password += random.Next(0, 10);
                }
                if (SpecialCharactersCheck == true && password.Length < length)
                {
                    password += specialCharacters[random.Next(0, specialCharacters.Length)];
                }
            }

            return password;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            string surname = surnameTB.Text;
            string? state = stateBox.SelectedItem?.ToString(); 

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(state) && !string.IsNullOrEmpty(password))
            {
                MessageBox.Show($"Dane pracownika: {name} {surname} {state} Has³o: {password}");
            }
            else
            {
                MessageBox.Show($"Nie wprowadzono wszystkich danych!");
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            int passwordLength = 0;
            if (signsAmountTB.Text != "")
            {
                passwordLength = Convert.ToInt32(signsAmountTB.Text);
                password = CreatePassword(smallBigLetterCheckBox.Checked, numberCheckBox.Checked, specialCharacterCheckBox.Checked, passwordLength);
                MessageBox.Show(password);
            }
            else
            {
                MessageBox.Show("Nie wprowadzono iloœci znaków dla has³a!");
            }
        }
    }
}
