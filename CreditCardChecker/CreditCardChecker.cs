using System;

namespace CreditCardChecker
{
    public class CreditCardChecker
    {
        /// <summary>
        /// Diese Methode überprüft eine Kreditkartenummer, ob diese gültig ist.
        /// Regeln entsprechend der Angabe.
        /// </summary>
        public static bool IsCreditCardValid(string creditCardNumber)
        {
            if(!CheckIfNumberIsValid(creditCardNumber))
            {
                return false;
            }
            int[] creditCardNumbers = new int[creditCardNumber.Length];
            int sum = 0;
            for (int i = 0; i < creditCardNumber.Length; i++)
            {
                creditCardNumbers[i] = ConvertToInt(creditCardNumber[i]);
            }

            for (int i = 0; i < creditCardNumbers.Length - 1; i++)
            {
                if(i % 2 == 0)
                {
                    if (creditCardNumbers[i] * 2 > 10)
                    {
                        sum += CalculateDigitSum(creditCardNumbers[i] * 2);                       
                    }
                    else
                    {
                        sum += creditCardNumbers[i] * 2;
                    }                  
                }
                else
                {
                    sum += creditCardNumbers[i];
                }
            }           
            return 10 - (sum % 10) == creditCardNumbers[15];
        }

        public static bool CheckIfNumberIsValid(string creditCardNumber)
        {
            if (creditCardNumber.Length != 16)
                return false;

            for (int i = 0; i < creditCardNumber.Length; i++)
            {
                if (!char.IsDigit(creditCardNumber[i]))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Berechnet aus der Summe der geraden Stellen (bereits verdoppelt) und
        /// der Summe der ungeraden Stellen die Checkziffer.
        /// </summary>
        private static int CalculateCheckDigit(int oddSum, int evenSum)
        {
            //throw new NotImplementedException();
            throw new NotImplementedException();
        }

        /// <summary>
        /// Berechnet die Ziffernsumme einer Zahl.
        /// </summary>
        private static int CalculateDigitSum(int number)
        {
            if (number == 0)
                return -1;
            int sum = 0;
            while (number > 0)
            {
            sum += number % 10;
            number = number / 10;
            }
            return sum;            
        }

        private static int ConvertToInt(char ch)
        {
            return ch - '0';
        }
    }
}
