using System.Diagnostics;

namespace Ciphers
{
    public partial class CipherForm : Form
    {
        readonly String caesarAlphabet = "nopqrstuvwxyzabcdefghijklmNOPQRSTUVWXYZABCDEFGHIJKLM";
        readonly String keyboardAlphabet = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        String caesarText = "";
        String keyboardText = "";
        String binaryText = "";
        String morseText = "";
        String userInput = "";

        public CipherForm()
        {
            InitializeComponent();
            saveButton.Enabled = false;
        }

        public void EncryptText(String text)
        {
            caesarText = ShiftEncrypt(text, caesarAlphabet, true);
            caesarOutput.Text = caesarText;

            keyboardText = ShiftEncrypt(text, keyboardAlphabet, true);
            keyboardOutput.Text = keyboardText;

            binaryText = EncryptBinary(text);
            binaryOutput.Text = binaryText;

            Boolean isMorse = true;
            foreach (char ch in text)
            {
                if (!Char.IsDigit(ch) && !Char.IsLetter(ch) && ch != ' ')
                {
                    isMorse = false;
                }
            }
            if (isMorse)
            {
                morseText = EncryptMorse(text);
            }
            else
            {
                morseText = "Morse input accepts alphanumeric characters and whitespace";
            }
            morseOutput.Text = morseText;

            saveButton.Enabled = true;
        }

        public void DecryptText(String text)
        {
            Boolean isBinary = true;
            Boolean isMorse = true;
            foreach (char ch in text)
            {
                if (!Char.IsDigit(ch) && ch != ' ')
                {
                    isBinary = false;
                }
                if (ch != '.' && ch != '-' && ch != ' ' && ch != '/')
                {
                    isMorse = false;
                }
                if (text.Length > 5 && !text.Contains("/"))
                {
                    isMorse = false;
                }
            }
            if (isMorse)
            {
                morseText = DecryptMorse(text);
            }
            else
            {
                morseText = "That's not morse code...";
            }
            morseOutput.Text = morseText;

            caesarText = ShiftEncrypt(text, caesarAlphabet, false);
            caesarOutput.Text = caesarText;

            keyboardText = ShiftEncrypt(text, keyboardAlphabet, false);
            keyboardOutput.Text = keyboardText;

            if (isBinary)
            {
                binaryText = DecryptBinary(text);
            }
            else
            {
                binaryText = "01010100011010000110000101110100 0110100101110011 011011100110111101110100 011000100110100101101110011000010111001001111001";
            }
            binaryOutput.Text = binaryText;

            saveButton.Enabled = true;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            userInput = userInputBox.Text;
            if (userInput == "")
            {
                MessageBox.Show("Please enter some text to encrypt");
                return;
            }
            else if (userInput.Length > 200)
            {
                MessageBox.Show("Please enter less than 200 characters");
                return;
            }
            else if (!CheckSafe(userInput))
            {
                MessageBox.Show("Please enter only letters, numbers, spaces, periods, hyphens, and slashes");
                return;
            }
            EncryptText(userInput);
            userInputBox.Enabled = false;
            decryptButton.Enabled = false;
            encryptButton.Enabled = false;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            userInput = userInputBox.Text;
            if (userInput == "")
            {
                MessageBox.Show("Please enter some text to decrypt");
                return;
            }
            DecryptText(userInput);
            userInputBox.Enabled = false;
            decryptButton.Enabled = false;
            decryptButton.Enabled = true;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            userInputBox.Text = string.Empty;
            userInputBox.Enabled = true;
            encryptButton.Enabled = true;
            decryptButton.Enabled = true;
            saveButton.Enabled = false;
            caesarOutput.Text = string.Empty;
            keyboardOutput.Text = string.Empty;
            morseOutput.Text = string.Empty;
            binaryOutput.Text = string.Empty;
        }

        static Boolean CheckSafe(String text)
        {
            foreach (char ch in text)
            {
                if (!Char.IsLetter(ch) && !Char.IsDigit(ch) && ch != ' ' && ch != '.' && ch != '-' && ch != '/')
                {
                    return false;
                }
            }
            return true;
        }

        static string ShiftEncrypt(String text, String alphabetToCheck, Boolean encrypt)
        {
            String alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String outputText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (!Char.IsLetter(text[i]))
                {
                    outputText += text[i];
                }
                else
                {
                    var letter = text[i];
                    char newLetter;
                    if (encrypt)
                    {
                        int index = alphabet.IndexOf(letter);
                        newLetter = alphabetToCheck[index];
                    }
                    else
                    {
                        int index = alphabetToCheck.IndexOf(letter);
                        newLetter = alphabet[index];
                    }
                    outputText += newLetter;
                }
            }
            return outputText;
        }

        static string EncryptBinary(String text)
        {
            String outputText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    outputText += ' ';
                }
                else
                {
                    var binaryLetter = Convert.ToString(text[i], 2).PadLeft(8, '0');
                    outputText += binaryLetter;
                }
            }
            return outputText;
        }

        static string DecryptBinary(String text)
        {
            String[] binaryWords = text.Split(" ");
            String[] stringWords = [];
            foreach (String word in binaryWords)
            {
                String newWord = "";
                for (int i = 0; i < word.Length; i += 8)
                {
                    if (word.Length < i + 8)
                    {
                        newWord += word[i..];
                    }
                    else
                    {
                        var binarySubstring = word.Substring(i, 8);
                        int binaryInteger = Convert.ToInt32(binarySubstring, 2);
                        char binaryLetter = Convert.ToChar(binaryInteger);
                        newWord += binaryLetter;
                    }
                }
                stringWords = stringWords.Append(newWord).ToArray();
            }
            String outputText = String.Join(" ", stringWords);
            return outputText;
        }

        static string EncryptMorse(String text)
        {
            Dictionary<char, String> morseCharToDots = new Dictionary<char, String>()
            {
                {'a', ".-"}, {'b', "-..."}, {'c', "-.-."}, {'d', "-.."}, {'e', "."}, {'f', "..-."}, {'g', "--."}, {'h', "...."},
                {'i', ".."}, {'j', ".---"}, {'k', "-.-"}, {'l', ".-.."}, {'m', "--"}, {'n' , "-."}, {'o', "---"}, {'p', ".--."},
                {'q', "--.-"}, {'r', ".-."}, {'s', "..."}, {'t', "-"}, {'u', "..-"}, {'v', "...-"}, {'w', ".--"}, {'x', "-..-"},
                {'y', "-.--"}, {'z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"},
                {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."},
            };
            String[] words = text.ToLower().Split(" ");
            String[] morseWords = [];
            foreach (String word in words)
            {
                String newWord = "";
                foreach (Char ch in word)
                {
                    String newMorse = morseCharToDots[ch];
                    newWord += newMorse + "/";
                }
                morseWords = [.. morseWords, newWord];
            }
            String outputText = String.Join(" ", morseWords);
            return outputText;
        }

        static string DecryptMorse(String text)
        {
            Dictionary<String, char> morseDotstoChars = new()
            {
                {".-", 'a'}, {"-...", 'b'}, {"-.-.", 'c'}, {"-..", 'd'}, {".", 'e'}, {"..-.", 'f'}, {"--.", 'g'}, {"....", 'h'},
                {"..", 'i'}, {".---", 'j'}, {"-.-", 'k'}, {".-..", 'l'}, {"--", 'm'}, {"-.", 'n'}, {"---", 'o'}, {".--.", 'p'}, {"--.-", 'q'},
                {".-.", 'r'}, {"...", 's'}, {"-", 't'}, {"..-", 'u'}, {"...-", 'v'}, {".--", 'w'}, {"-..-", 'x'}, {"-.--", 'y'}, {"--..", 'z'},
                {".----", '1'}, {"..---", '2'}, {"...--", '3'}, {"....-", '4'}, {".....", '5'}, {"-....", '6'}, {"--...", '7'},
                {"---..", '8'}, {"----.", '9'}, {"-----", '0' }
            };
            if (text.EndsWith("/"))
            {
                text = text[..^1];
            }
            Debug.WriteLine(text);
            String[] words = text.Split(" ");
            String[] stringWords = [];

            foreach (String word in words)
            {
                String[] letters = word.Split("/");
                String newWord = "";
                foreach (String letter in letters)
                {
                    if (letter is not "")
                    {
                        char newLetter = morseDotstoChars[letter];
                        newWord += newLetter;
                    }
                }
                if (newWord.Length > 0)
                {
                    stringWords = [.. stringWords, newWord];
                }
            }
            String outputText = String.Join(" ", stringWords);
            return outputText;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveNewFile = new SaveFileDialog();

            saveNewFile.Filter = "txt files (*.txt)|*.txt";
            saveNewFile.FilterIndex = 2;
            saveNewFile.Title = "Save your code";
            saveNewFile.RestoreDirectory = true;

            if (saveNewFile.ShowDialog() == DialogResult.OK)
            {
                String filename = saveNewFile.FileName;
                System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
                file.WriteLine("Your text: ");
                file.WriteLine(userInput);
                file.WriteLine();
                file.WriteLine("Caesar Cipher: ");
                file.WriteLine(caesarText);
                file.WriteLine();
                file.WriteLine("Keyboard Cipher: ");
                file.WriteLine(keyboardText);
                file.WriteLine();
                file.WriteLine("Morse Code: ");
                file.WriteLine(morseText);
                file.WriteLine();
                file.WriteLine("Binary: ");
                file.WriteLine(binaryText);
                file.Close();
            }
        }

    }
}
