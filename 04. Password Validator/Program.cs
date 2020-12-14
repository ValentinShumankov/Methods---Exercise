using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordValidator(Console.ReadLine());
        }

        /// <summary>
        /// Validated the necesery criteria for a valid password.
        /// </summary>
        /// <param name="pass"></param>
        static void PasswordValidator(string pass)
        {
            bool moreThan6Characters = false;
            bool haveLettersAndDigits = false;
            bool haveAleast2Digits = false;
           
            
            // Count off the letter if they more than specified.
            int lettersCounter = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                lettersCounter++;

            }
            if (lettersCounter < 6 || lettersCounter > 10)
            {
                moreThan6Characters = false;
            }
            else
            {
                moreThan6Characters = true;
            }


            // Checking if the password concist of unallowed characters.
            int wrongInputCount = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if ( (pass[i] < 48 || pass[i] > 57 )&&
                    ( pass[i] < 65 || pass[i] > 90) &&
                    ( pass[i] < 97 || pass[i] > 122))

                {
                    wrongInputCount++;

                }


            }

            if (wrongInputCount == 0)
            {
                haveLettersAndDigits = true;
            }
            else if (wrongInputCount > 0)
            {
                haveLettersAndDigits = false;

            }


            //Counts of if there is digits in the password.
            int digitCounter = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] == '0' ||
                      pass[i] == '1' ||
                      pass[i] == '2' ||
                      pass[i] == '3' ||
                      pass[i] == '4' ||
                      pass[i] == '5' ||
                      pass[i] == '6' ||
                      pass[i] == '7' ||
                      pass[i] == '8' ||
                      pass[i] == '9')
                {
                    digitCounter++;
                }
            }


            //Check for minimal amount digits.
            if (digitCounter != 0)
            {
                Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
                Match result = re.Match(pass);
                string numberPart = result.Groups[2].Value;


                int minDigitCounter = 0;
                for (int i = 0; i < numberPart.Length; i++)
                {
                    minDigitCounter++;
                }
                if (minDigitCounter < 2)
                {
                    haveAleast2Digits = false;

                }
                else
                {
                    haveAleast2Digits = true;
                }

            }
            else
            {
                haveAleast2Digits = false;

            }




            //Prints off the result after all checks.

            if (moreThan6Characters == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (haveLettersAndDigits == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (haveAleast2Digits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (moreThan6Characters == true &&
                haveAleast2Digits == true &&
                haveLettersAndDigits == true)
            {
                Console.WriteLine("Password is valid");
            }
        }

       
        
        
        
        
        
        
        
        
        
        
        
        static void BetterPasswordValidator(string password)
        {
            if (password.Count(Char.IsDigit) >= 2 && password.Length >= 6 && password.Length <= 10 && password.All(Char.IsLetterOrDigit))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!(password.Length >= 6 && password.Length <= 10))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!password.All(Char.IsLetterOrDigit))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!(password.Count(Char.IsDigit) >= 2))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
    }
}
