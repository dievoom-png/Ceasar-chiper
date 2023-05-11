using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ceasar_chiper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the key of the cipher");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the text you want to chiper");
            string m = Console.ReadLine();
            m = m.ToLower(); // converting to all the string to lower case
            char[] chars = m.ToCharArray();//converting the string to an array of chars
            for (int i = 0; i < chars.Length; i++)
            {
                char letter = chars[i];
                letter = (char)(letter + key);// (char) allows me to acess the ascii value of the given character and shift it using the key
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);// inorder to loop back starting from a if the ascii value exceeds the value of z
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26); // to accept keys in negative values
                }
                chars[i] = letter;
                
                Console.WriteLine(chars[i]);
               
            }
            Console.Read();
        }
    }
}
