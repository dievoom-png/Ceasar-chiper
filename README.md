# Caesar Cipher Implementation in C#

This is a C# implementation of the Caesar cipher algorithm. This program allows the user to encrypt a given message using a key provided by the user.
How to use the Program

    1- Clone or download the code to your local machine.
    2- Open the project in Visual Studio or your preferred C# IDE.
    3- Build the project and run the program.
    4- Follow the instructions given in the console window.
    5- Input a key for the cipher and the message that you want to encrypt.
    6- The program will output the encrypted message.

### How the Caesar Cipher Works

The Caesar Cipher is a simple encryption technique that involves shifting the letters of a message a certain number of positions down the alphabet. The key is the number of positions that each letter is shifted. For example, if the key is 3, then each letter in the message is replaced with the letter that is 3 positions down the alphabet.

For instance, the letter 'A' would be replaced by the letter 'D', 'B' by 'E', and so on. If the key is negative, the letters are shifted up the alphabet instead of down.


This implementation takes input from the user for the key and the message to be encrypted. The message is then converted to lowercase characters, and each character is shifted by the given key value using the ASCII code values.

If a character goes beyond the boundaries of the alphabet (e.g., beyond 'z' or below 'a'), the algorithm will wrap around to the other side of the alphabet. Finally, the encrypted message is printed to the console.
