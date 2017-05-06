using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Models
{
    public class RegistrationUser
    {
      private string key;
        private string firstName;
        private string lastName;
        private string martialStatus;
        private string hobbys;
        private string country;
        private string birthMonth;
        private string birthDay;
        private string birthYear;
        private string phone;
        private string username;
        private string email;
        private string picture;
        private string description;
        private string password;
        private string confirmPassword;

        public RegistrationUser(string key,
                              string firstName,
                              string lastName,
                              string martialStatus,
                              string hobbys,
                              string country,
                              string birthMonth,
                              string birthDay,
                              string birthYear,
                              string phone,
                              string username,
                              string email,
                              string picture,
                              string description,
                              string password,
                              string confirmPassword
                              )
        {
            this.key = key;
            this.firstName = firstName;
            this.lastName = lastName;
            this.martialStatus = martialStatus;
            this.hobbys = hobbys;
            this.country = country;
            this.birthMonth = birthMonth;
            this.birthDay = birthDay;
            this.birthYear = birthYear;
            this.phone = phone;
            this.username = username;
            this.email = email;
            this.picture = picture;
            this.description = description;
            this.password = password;
            this.confirmPassword = confirmPassword;
        }

        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string MartialStatus
        {
            get { return martialStatus; }
            set { martialStatus = value; }
        }

        public string Hobbys
        {
            get { return hobbys; }
            set { hobbys = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string BirthMonth
        {
            get { return birthMonth; }
            set { birthMonth = value; }
        }

        public string BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }

        public string BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; }
        }
    }
}