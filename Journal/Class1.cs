//Задание 5
//Создайте класс «Журнал». Необходимо хранить в
//полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail.
//Реализуйте методы класса для ввода данных, вывода
//данных, реализуйте доступ к отдельным полям через
//методы класса.
using System;


namespace Journal
{
    internal class Class1
    {
        public string Name { get; set; }
        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value != 0 && value<1800 || value > 2022)
                {
                    Console.WriteLine("Incorrect founding year");
                    return;
                }
                year = value;
            }
        }
        public string Phone { get; set; }
        
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value != String.Empty && value.IndexOf('@')==-1)
                {
                    Console.WriteLine("Incorrect Email");
                    return;
                }
                email = value;
            }
        }

        public Class1()
        {
            Name = String.Empty;
            Year = 0;
            Phone = String.Empty;
            Email = String.Empty;
        }
        public Class1(string _Name, int _Year, string _Phone, string _Email)
        {
            this.Name = _Name;
            this.Year = _Year;
            this.Phone = _Phone;
            this.Email = _Email;
        }
        public override string ToString()
        {
            return String.Format("Name: {0}\nYear of foundation: {1}\nPhone: {2}\nEmail : {3} \n", Name, Year, Phone, Email);
        }
    }

}
