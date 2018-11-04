using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Hto3.StringHelpers
{
    public static class Helpers
    {
        /// <summary>
        /// Strip all others caracters from a text lefting only numbers
        /// </summary>
        /// <param name="text">The original text</param>
        /// <returns></returns>
        public static String NumbersOnly(this String text)
        {
            if (String.IsNullOrEmpty(text))
                return text;

            var builder = new StringBuilder();

            foreach (var c in text)
            {
                if (Char.IsNumber(c))
                    builder.Append(c);
            }

            return builder.ToString();
        }
        /// <summary>
        /// Strip all others caracters from a text lefting only non-numbers
        /// </summary>
        /// <param name="texto">The original text</param>
        /// <returns></returns>
        public static String ExceptNumbers(this String text)
        {
            if (String.IsNullOrEmpty(text))
                return text;

            var builder = new StringBuilder();

            foreach (var c in text)
            {
                if (!Char.IsNumber(c))
                    builder.Append(c);
            }

            return builder.ToString();
        }
        /// <summary>
        /// Extract some characters from right to left
        /// </summary>
        /// <param name="text">The original text</param>
        /// <param name="length">Amount of characters to extract</param>
        /// <param name="useThreeDots">If true, three dots "..." will be added at the begining of the extracted characters</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static String Right(this String text, Int32 length, Boolean useThreeDots = false)
        {
            if (length < 0)
                throw new ArgumentOutOfRangeException(nameof(length));
            if (String.IsNullOrEmpty(text))
                return text;

            if (text.Length > length)
            {
                if (useThreeDots)
                    return "..." + text.Substring(text.Length - length, length);
                else
                    return text.Substring(text.Length - length, length);
            }
            else
            {
                return text;
            }
        }
        /// <summary>
        /// Reverse the characters sequence
        /// </summary>
        /// <param name="text">The original text</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static String Reverse(this String text)
        {
            if (String.IsNullOrEmpty(text))
                return text;

            var builder = new StringBuilder(text.Length);

            foreach (Char c in text)
                builder.Insert(0, c);

            return builder.ToString();
        }
        /// <summary>
        /// Extract some characters from left to right
        /// </summary>
        /// <param name="text">The original text</param>
        /// <param name="length">Amount of characters to extract</param>
        /// <param name="useThreeDots">If true, three dots "..." will be added at the end of the extracted characters</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static String Left(this String text, Int32 length, Boolean useThreeDots = false)
        {
            if (length < 0)
                throw new ArgumentOutOfRangeException(nameof(length));
            if (String.IsNullOrEmpty(text))
                return text;

            if (text.Length > length)
            {
                if (useThreeDots)
                    return text.Substring(0, length) + "...";
                else
                    return text.Substring(0, length);
            }
            else
            {
                return text;
            }
        }
        /// <summary>
        /// Replace a text with another one ignoring case
        /// </summary>
        /// <param name="input">The original text</param>
        /// <param name="oldText">The old text</param>
        /// <param name="newText">The new text</param>
        /// <returns></returns>
        public static String ReplaceIgnoringCase(this String input, String oldText, String newText)
        {
            if (oldText == null)
                throw new ArgumentNullException(nameof(oldText));
            if (newText == null)
                throw new ArgumentNullException(nameof(newText));
            if (String.IsNullOrEmpty(input))
                return input;            

            return Regex.Replace
                (
                    input
                    ,
                    Regex.Escape(oldText)
                    ,
                    newText?.Replace("$", "$$")
                    ,
                    RegexOptions.IgnoreCase
                );
        }
        /// <summary>
        /// Replace whole word
        /// </summary>
        /// <param name="input">The original text</param>
        /// <param name="oldText">The old word</param>
        /// <param name="newText">The new word</param>
        /// <param name="ignoreCase">if true, ignoring case</param>
        /// <returns></returns>
        public static String ReplaceWholeWord(this String input, String oldText, String newText, Boolean ignoreCase = false)
        {
            if (oldText == null)
                throw new ArgumentNullException(nameof(oldText));
            if (newText == null)
                throw new ArgumentNullException(nameof(newText));
            if (String.IsNullOrEmpty(input))
                return input;

            return Regex.Replace
                (
                    input
                    ,
                    "\\b" + Regex.Escape(oldText) + "\\b"
                    ,
                    newText.Replace("$", "$$")
                    ,
                    ignoreCase ? RegexOptions.IgnoreCase : RegexOptions.None
                );
        }
        /// <summary>
        /// Tries to get the first name of a full name
        /// </summary>
        /// <param name="fullName">The full name of a person</param>
        /// <returns></returns>
        public static Boolean TryGetFirstName(this String fullName, out String firstName)
        {
            firstName = null;

            if (String.IsNullOrEmpty(fullName))
                return false;

            fullName = fullName.Trim();

            if (fullName.IndexOf(" ") == -1)
                return false;
            else
            {
                firstName = fullName.Substring(0, fullName.IndexOf(" "));
                return true;
            }                
        }
        /// <summary>
        /// Tries to get the last name of a full name
        /// </summary>
        /// <param name="fullName">The full name of a person</param>
        /// <returns></returns>
        public static Boolean TryGetLastName(this String fullName, out String lastName)
        {
            lastName = null;

            if (String.IsNullOrEmpty(fullName))
                return false;

            fullName = fullName.Trim();

            if (fullName.LastIndexOf(" ") == -1)
                return false;
            else
            {
                lastName = fullName.Substring(fullName.LastIndexOf(" ") + 1);
                return true;
            }                
        }
        /// <summary>
        /// Tries to exclude the first name of a full name and return the middle and the last name
        /// </summary>
        /// <param name="name">The full name of a person</param>
        /// <returns></returns>
        public static String TryGetExceptFirstName(this String name)
        {
            if (String.IsNullOrEmpty(name))
                return name;

            name = name.TrimEnd();

            if (name.IndexOf(" ") == -1)
                return name;
            else
                return name.Substring(name.IndexOf(" ") + 1);
        }

        /// <summary>
        /// Format a brazilian CPF
        /// </summary>
        /// <param name="cpf">A CPF with ou without formatting</param>
        /// <returns></returns>
        public static String FormatCPF(this String cpf)
        {
            if (String.IsNullOrEmpty(cpf))
                return null;

            var cpfLimpo = NumbersOnly(cpf);

            if (cpfLimpo.Length != 11)
                return null;

            return String.Format("{0}.{1}.{2}-{3}", cpfLimpo.Substring(0, 3), cpfLimpo.Substring(3, 3), cpfLimpo.Substring(6, 3), cpfLimpo.Substring(9, 2));
        }
        /// <summary>
        /// Format a brazilian CNPJ
        /// </summary>
        /// <param name="cnpj">A CNPJ with or without formatting</param>
        /// <returns></returns>
        public static String FormatCNPJ(this String cnpj)
        {
            if (String.IsNullOrEmpty(cnpj))
                return null;

            var cnpjLimpo = NumbersOnly(cnpj);

            if (cnpjLimpo.Length != 14)
                return null;

            return String.Format("{0}.{1}.{2}/{3}-{4}", cnpjLimpo.Substring(0, 2), cnpjLimpo.Substring(2, 3), cnpjLimpo.Substring(5, 3), cnpjLimpo.Substring(8, 4), cnpjLimpo.Substring(12, 2));
        }
        /// <summary>
        /// Format a brazilian zip code
        /// </summary>
        /// <param name="cep">A brazilian CEP with or without formatting</param>
        /// <returns></returns>
        public static String FormatCEP(String cep)
        {
            if (String.IsNullOrEmpty(cep))
                return null;

            cep = NumbersOnly(cep);

            if (cep.Length > 8 || cep.Length < 5)
                return null;

            cep = cep.PadRight(8, '0');

            return cep.Substring(0, 5) + '-' + cep.Substring(5);
        }
        /// <summary>
        /// Verify if a text is a number
        /// </summary>
        /// <param name="text">The text that will be tested</param>
        /// <param name="onlyIntegerNumbers">If true, the text will be tested to be an integer (decimal part MUST not exist)</param>
        /// <returns></returns>
        public static Boolean IsNumber(this String text, Boolean onlyIntegerNumbers = false)
        {
            if (String.IsNullOrEmpty(text))
                return false;

            if (onlyIntegerNumbers)
            {
                return Int32.TryParse(text, out Int32 teste);
            }
            else
            {
                return Decimal.TryParse(text, out Decimal teste);
            }
        }
        /// <summary>
        /// Remove all non-ASCII characters from a text
        /// </summary>
        /// <param name="text">The original text</param>
        /// <returns></returns>
        public static String RemoveNonASCIICharacters(this String text)
        {
            if (String.IsNullOrEmpty(text))
                return text;
            else
                return System.Text.RegularExpressions.Regex.Replace(text, @"[^\u0000-\u007F]", String.Empty);
        }
        /// <summary>
        /// Remove accents replacing the character with the equivalent without accent
        /// </summary>
        /// <param name="text">The original text</param>
        /// <returns></returns>
        public static String RemoveAccents(this String text)
        {
            if (String.IsNullOrEmpty(text))
                return text;

            var s = text.Normalize(NormalizationForm.FormD);

            var retorno = new StringBuilder(s.Length);

            for (var k = 0; k < s.Length; k++)
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(s[k]) != System.Globalization.UnicodeCategory.NonSpacingMark)
                    retorno.Append(s[k]);

            return retorno.ToString();
        }
        /// <summary>
        /// Returns a new string in which only the first occurrence of a specified string in the current instance are replaced with another specified string.
        /// </summary>
        /// <param name="originalText">The original text</param>
        /// <param name="oldValue">The text to looking for</param>
        /// <param name="newValue">The text to replace</param>
        /// <returns></returns>
        public static String ReplaceFirstOccurrence(this String originalText, String oldValue, String newValue)
        {
            if (oldValue == null)
                throw new ArgumentNullException(nameof(oldValue));
            if (newValue == null)
                throw new ArgumentNullException(nameof(newValue));
            if (String.IsNullOrEmpty(originalText))
                return originalText;

            var pos = originalText.IndexOf(oldValue);
            if (pos < 0)
                return originalText;
            return originalText.Substring(0, pos) + newValue + originalText.Substring(pos + oldValue.Length);
        }
        /// <summary>
        /// Center a text inside a fixed length using space characters ' '
        /// </summary>
        /// <param name="text">Text to format</param>
        /// <param name="totalLength">Total length</param>
        /// <returns></returns>
        public static String CenterAlignText(String text, Int32 totalLength)
        {
            if (totalLength < 0)
                throw new ArgumentOutOfRangeException(nameof(totalLength));

            text = text ?? String.Empty;

            String textoFormatado;
            if (text.Length > totalLength)
                textoFormatado = text.Substring(0, totalLength);
            else
                textoFormatado = text;
            int tamanho = (totalLength - textoFormatado.Trim().Length) / 2;
            int ePar = (totalLength - textoFormatado.Trim().Length) % 2;
            return new String(' ', tamanho) + textoFormatado + new String(' ', ePar == 0 || tamanho == 0 ? tamanho : tamanho - 1);
        }
    }
}
