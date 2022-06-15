using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Generator
    {
        /// <summary>
        /// Generate password with lowercase and uppercase letters by default, can generate with numbers and symbols with parameters from checkbox
        /// </summary>
        /// <param name="num">If <see cref="num"/> is true add numbers to password</param>
        /// <param name="sym">if <see cref="sym"/> is true add symbols to password</param>
        /// <returns>Password generated based on methods parameters</returns>
        public static string Generate(bool num, bool sym)
        {
            Random random = new Random();
            string password = "";
            string lowercase = "qwertyuiopasdfghjklzxcvbnm";
            string uppercase = lowercase.ToUpper();
            string numbers = "1234567890";
            string symbols = "!@#$%&*()-_=+<>,.?/;:";
            int count = 0;

            while (count <= 10)
            {
                if (num)
                {
                    password += numbers[random.Next(numbers.Length)];
                    count += 1;
                }

                if (sym)
                {
                    password += symbols[random.Next(symbols.Length)];
                    count += 1;
                }

                password += lowercase[random.Next(lowercase.Length)];
                password += uppercase[random.Next(uppercase.Length)];
                count += 2;
            }

            return password;
        }
    }
}
