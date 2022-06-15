using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Models
{
    /// <summary>
    /// Check password Strength based on the follow rules:
    /// 
    /// 1 - Six points to each character in passwors, until the max os 60 points.
    /// 2 - Five points to passwords with lowercase letters. Ten if the password have more than one lowercase letter.
    /// 3 - Five points to passwords with uppercase letters. Ten if the password have more than one uppercase letter.
    /// 4 - Five points to passwords with numbers. Ten if the password have more than one numbers.
    /// 5 - Five points to passwords with symbols. Ten if the password have more than one symbol.
    /// 
    /// The original article on: https://www.macoratti.net/13/01/c_vfs1.htm
    /// </summary>
    public class CheckPasswordStrength
    {
        /// <summary>
        /// Classifies password strength
        /// </summary>
        public enum PasswordStrength
        {
            Unacceltable,
            Weak,
            Acceptable,
            Strong,
            Secure
        }

        /// <summary>
        /// Generate password points based on rules above
        /// </summary>
        /// <param name="password">Password to analyze strength</param>
        /// <returns></returns>
        public int GeneratePasswordPoints(string password)
        {
            if (String.IsNullOrEmpty(password))
            {
                return 0;
            }

            int pointsByLength = this.GetPointsByLength(password);
            int pointsByLowercase = this.GetPointsByLowercase(password);
            int pointsByUppercase = this.GetPointsByUpperCase(password);
            int pointsByNumbers = this.GetPointsByNumbers(password);
            int pointsBySymbols = this.GetPointsBySymbols(password);
            int pointsByRepetition = this.GetPointsByRepetition(password);

            return pointsByLength + pointsByLowercase + pointsByUppercase + pointsByNumbers + pointsBySymbols + pointsByRepetition;
        }

        /// <summary>
        /// Get points based on length os string
        /// </summary>
        /// <param name="password">Password to get points</param>
        /// <returns></returns>
        public int GetPointsByLength(string password)
        {
            return Math.Min(10, password.Length) * 6;
        }

        /// <summary>
        /// Get points based on lowercase letters
        /// </summary>
        /// <param name="password">Password to get points</param>
        /// <returns></returns>
        public int GetPointsByLowercase(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[a-z]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        /// <summary>
        /// Get points based on uppercase letters
        /// </summary>
        /// <param name="password">Password to get points</param>
        /// <returns></returns>
        public int GetPointsByUpperCase(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[A-Z]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        /// <summary>
        /// Get points based on numbers
        /// </summary>
        /// <param name="password">Password to get points</param>
        /// <returns></returns>
        public int GetPointsByNumbers(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[0-9]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        /// <summary>
        /// Get points based on symbols
        /// </summary>
        /// <param name="password">Password to get points</param>
        /// <returns></returns>
        public int GetPointsBySymbols(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        /// <summary>
        /// Get points based on repetition os lowercase letters, uppercase letters, numbers and symbols
        /// </summary>
        /// <param name="password">Password to get points</param>
        /// <returns></returns>
        public int GetPointsByRepetition(string password)
        {
            Regex regex = new Regex(@"(\w)*.*\1");
            bool repeat = regex.IsMatch(password);

            if (repeat)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Get the password points and classifies password
        /// </summary>
        /// <param name="password">Password to classify</param>
        /// <returns></returns>
        public PasswordStrength GetPasswordStrength(string password)
        {
            int score = GeneratePasswordPoints(password);

            if (score < 50)
            {
                return PasswordStrength.Unacceltable;
            }
            else if (score < 60)
            {
                return PasswordStrength.Weak;
            }
            else if (score < 80)
            {
                return PasswordStrength.Acceptable;
            }
            else if (score < 100)
            {
                return PasswordStrength.Strong;
            }
            else
            {
                return PasswordStrength.Secure;
            }
        }
    }
}
