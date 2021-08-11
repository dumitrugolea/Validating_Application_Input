using System;
using System.Text.RegularExpressions;

namespace ValidatingApplicationInput
{
    class PersonalData
    {
        private string phone;
        private string email;
        private string dateOfBirth;
        private string zipCode;
        private bool state = false;
        public string Phone
        {
            get => phone;
            set
            {
                phone = value;
                bool isMatches = Regex.IsMatch(phone, @"\+373\d{8}");
                state = isMatches;
                if (!isMatches)
                {
                    throw new MyCustomException("Invalid phone number. Try again please!");
                }
            }
        }
        public string Email
        {
            get => email;
            set
            {
                email = value;
                bool isMatches = Regex.IsMatch(email, @"^\w+[a-zA-Z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+)\.\w{2,4}");
                state = isMatches;
                if (!isMatches)
                {
                    throw new MyCustomException("Invalid email. Try again please!");

                }

            }
        }
        public string DateOfBirth
        {
            get => dateOfBirth;
            set
            {
                dateOfBirth = value;
                bool isMatches = Regex.IsMatch(dateOfBirth, @"\d{2}-\d{2}-\d{4}");
                state = isMatches;
                if (!isMatches)
                {
                    throw new MyCustomException("Invalid date of birth. Try again please!");
                }
            }
        }
        public string ZipCode
        {
            get => zipCode;
            set
            {
                zipCode = value;
                bool isMatches = Regex.IsMatch(zipCode, @"[MD|MD]\-\d{4}");
                state = isMatches;
                if (!isMatches)
                {
                    throw new MyCustomException("Invalid zip code. Try again please!");
                }
            }
        }
        public void ValidatePhone()
        {
            state = false;
            while (!(state))
            {
                try
                {
                    Phone = Console.ReadLine();
                }
                catch (MyCustomException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void ValidateEmail()
        {
            state = false;
            while (!(state))
            {
                try
                {
                    Email = Console.ReadLine();
                }
                catch (MyCustomException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void ValidateDateOfBirth()
        {
            state = false;
            while (!(state))
            {
                try
                {
                    DateOfBirth = Console.ReadLine();
                }
                catch (MyCustomException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void ValidateZipCode()
        {
            state = false;
            while (!(state))
            {
                try
                {
                    ZipCode = Console.ReadLine();
                }
                catch (MyCustomException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}


