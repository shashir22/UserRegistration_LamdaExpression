using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration_LambdaExpression
{
    public class Patterns
    {
        public static string Regex_name = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public static string Regex_phone = "^[1-9]{1}[0-9]{1}\\s[1-9]{1}[0-9]{9}$";
        public static string Regex_password = "^(?=.*[A-Z])(?=.*\\d)(?=[\\w]*[\\W][\\w]*$)[\\S]{8,}$";
        public bool IsValidFirstName(string firstname)
        {
            bool flag;
            do
            {
                flag = (Regex.IsMatch(firstname, Regex_name));
                if (flag == true)
                    return true;
                else
                    return false;
            }
            while (flag == false);

        }
        public bool IsValidLastName(string lastname)
        {
            bool flag;
            do
            {
                flag = (Regex.IsMatch(lastname, Regex_name));
                if (flag == true)
                    return true;
                else
                    return false;
            }
            while (!flag);
        }
        public bool IsValidEmail(string email)
        {
            bool flag;
            do
            {
                flag = (Regex.IsMatch(email, Regex_email));
                if (flag == true)
                    return true;
                else
                    return false;
            }
            while (!flag);
        }
        public bool IsValidPhoneNo(string phone)
        {
            bool flag;
            do
            {
                flag = (Regex.IsMatch(phone, Regex_phone));
                if (flag == true)
                    return true;
                else
                    return false;
            }
            while (!flag);
        }
        public bool IsValidPasswordRule(string password)
        {
            bool flag;
            do
            {
                flag = (Regex.IsMatch(password, Regex_password));
                if (flag == true)
                    return true;
                else
                    return false;

            }
            while (!flag);
        }

        public bool IsValidSampleEmail(string SampleEmail)
        {
            bool flag = (Regex.IsMatch(SampleEmail, Regex_email));
            if (flag == true)
                return true;
            else
                return false;

        }
    }
}