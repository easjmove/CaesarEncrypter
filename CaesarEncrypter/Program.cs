using System;
using System.Text;

namespace CaesarEncrypter
{
    class Program
    {
        public static void Main(string[] args)
        {
            int cipher = 5;
            Console.WriteLine("Testing Caesar encryption! With the cipher " + cipher);

            string testString = "Caesar encryption is easy to break";
            Console.WriteLine("Encrypting the string: " + testString);
            string encryptedString = Encrypt(testString, true, cipher);
            Console.WriteLine("Encrypted result: " + encryptedString);

            Console.WriteLine("Decrypted result: " + Encrypt(encryptedString, false, cipher));
        }

        // This encrypts using both letters, numbers and other special characters.
        //Another way of creating this is to only encrypt the letters
        public static string Encrypt(string message, bool addCipher, int cipher)
        {
            StringBuilder sb = new StringBuilder();
            //Iterates all characters in the message
            foreach (char messageChar in message)
            {
                //reads the numeric value of the char (0-65535)
                int charNumber = messageChar;
                char result;
                //adds or subtracts 1 from the numeric value of the character and convert it back into a char
                if (addCipher) result = (char)(charNumber + cipher);
                else result = (char)(charNumber - cipher);

                //adds the converted char to the string builder
                sb.Append(result);
            }

            return sb.ToString();
        }
    }
}
