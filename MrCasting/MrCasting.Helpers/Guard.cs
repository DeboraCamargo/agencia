using System;
using System.Text.RegularExpressions;

namespace MrCasting.Helpers
{
    public class Guard
    {

        public enum StringSizeType
        {
            MinLenght, MaxLenght
        };

        public static void ForSpecialCharacter(string value, string errorMessage)
        {
            if(Regex.Match(value, "[^a-zA-Zà-úÀ-Ú\\s0-9]").Success)
            {
                throw new Exception(errorMessage + " Contém caracter especial");

            }
        }

        public static void ForContainSpace(string value, string errorMessage)
        {
            if (value.Contains(" "))
                throw new Exception(errorMessage);
        }


        public static void ForNullOrWhiteSpace(string value, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception(errorMessage);
        }

        public static void ForNull(string value, string errorMessage)
        {
            if (value == null)
                throw new Exception(errorMessage);
        }

        public static void ForNull(object value, string errorMessage)
        {
            if (value == null)
                throw new Exception(errorMessage);
        }


        public static void ForSpecialCharAndNumbers(string text, string errorMessage)
        {
            text = TestHelper.RemoverAcentos(text);
            if (Regex.Match(text, "[^a-zA-Zà-úÀ-Ú\\s]").Success)
            {
                throw new Exception(errorMessage+" Contém caracter especial ou numero");

            }

        }

        public static void ForValidId(string propName, Guid id)
        {
            ForValidId(id, propName + " id inválido!");
        }

        public static void ForValidId(Guid id, string errorMessage)
        {
            if (id == Guid.Empty)
                throw new Exception(errorMessage);
        }

        public static void ForValidId(string propName, int id)
        {
            ForValidId(id, propName + " id inválido!");
        }

        public static void ForValidId(int id, string errorMessage)
        {
            if (!(id > 0))
                throw new Exception(errorMessage);
        }

        public static void ForNegative(int number, string propName)
        {
            if (number < 0)
                throw new Exception(propName + " não pode ser negativo!");
        }

        public static void ForNullOrEmptyDefaultMessage(string value, string propName)
        {
            if (String.IsNullOrEmpty(value))
                throw new Exception(propName + " é obrigatório!");
        }

        public static void ForNullOrEmpty(string value, string errorMessage)
        {
            if (String.IsNullOrEmpty(value))
                throw new Exception(errorMessage);
        }

        public static void StringLength(string propName, string stringValue, int maximum)
        {
            StringLength(stringValue, maximum, propName + " não pode ter mais que " + maximum + " caracteres");
        }

        public static void StringLength(string stringValue, int maximum, string message)
        {
            int length = stringValue.Length;
            if (length > maximum)
            {
                throw new Exception(message);
            }
        }

        public static void StringLength(string propName, string stringValue, int minimum, int maximum)
        {
            StringLength(stringValue, minimum, maximum, propName + " deve ter de " + minimum + " à " + maximum + " caracteres!");
        }

        public static void StringLength(string stringValue, int minimum, int maximum, string message)
        {
            if (String.IsNullOrEmpty(stringValue))
                stringValue = String.Empty;

            int length = stringValue.Length;
            if (length < minimum || length > maximum)
            {
                throw new Exception(message);
            }
        }

        public static void StringLength(string propName, string stringValue, int compareLength, StringSizeType sizeType)
        {
            if (String.IsNullOrEmpty(stringValue))
                stringValue = String.Empty;

            int length = stringValue.Length;

            if (sizeType == StringSizeType.MinLenght && length < compareLength)
            {
                throw new Exception(string.Format("{0} deve conter mais de {1} caracteres", propName, compareLength));
            }
            else if (length > compareLength)
            {
                throw new Exception(string.Format("{0} deve conter menos de {1} caracteres", propName, compareLength));
            }
        }

        public static void AreEqual(string a, string b, string errorMessage)
        {
            if (a != b)
                throw new Exception(errorMessage);
        }


        public static bool ValidaCnpj(string cnpj)
        {

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;

            int resto;

            string digito;

            string tempCnpj;

            cnpj = cnpj.Trim();

            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;

            for (int i = 0; i < 12; i++)

                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;

            soma = 0;

            for (int i = 0; i < 13; i++)

                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);

        }
    }
}
