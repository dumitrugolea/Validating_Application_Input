using System;

namespace ValidatingApplicationInput
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalData personalData = new PersonalData();
            Console.WriteLine("Enter your personal data:");
            Console.Write("Phone Number: ");
            personalData.ValidatePhone();
            Console.Write("Email ID: ");
            personalData.ValidateEmail();
            Console.Write("Date of birth: ");
            personalData.ValidateDateOfBirth();
            Console.Write("Zip code: ");
            personalData.ValidateZipCode();
            Console.WriteLine("\n");
            Console.WriteLine($" Phone:         {personalData.Phone}\n Email:         { personalData.Email}\n" +
                $" Date of birth: {personalData.DateOfBirth}\n Zip code:      {personalData.ZipCode}\n");
        }
    }
}
