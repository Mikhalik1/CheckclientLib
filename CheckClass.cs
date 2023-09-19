using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CheckclientLib
{
    public class CheckClass
    {
        /// <summary>
        /// В качестве параметра передается строка, которая может быть пустой или содержать произвольные символы.
        /// </summary>
        /// <param name="textstring"></param>
        /// <returns>
        /// Метод возвращает true, если переданная строка соответствует email В противном случае возвращается false.
        /// </returns>
        public static bool IsEmail(string textstring)
        {
            string regex = @"^([a-zA-Z]|\d)+@([a-zA-Z])+\.[a-zA-Z]+$"; //Регулярное выражение


            if (Regex.Match(textstring, regex, RegexOptions.IgnoreCase).Success) //Проверка почты на соответствие регулярному выражению
            {
                return true;
            }
            else { return false; }
        }
        public static bool IsPhoneNumber(string textstring)
        {
            string regaxIsPhone = @"^((\+7)|8)\d{3}\d{7}$"; //Регулярное выражение

            if (Regex.Match(textstring, regaxIsPhone, RegexOptions.IgnoreCase).Success) //Проверка номера на соответствие регулярному выражению
            {
                return true;
            }
            else { return false; }
            
        }





    }
}
