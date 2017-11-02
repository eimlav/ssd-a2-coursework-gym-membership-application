using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDIO2_Subscription_Manager
{
    class Member
    {
        public Member() { }

        public Member(string title, string firstName, string surname, string addressLine, string addressCity, string addressCounty, string addressPostcode, string dateOfBirth, string emergencyContactNumber, string gender, string phone, string email)
        {
            Title = title;
            FirstName = firstName;
            Surname = surname;
            AddressLine = addressLine;
            AddressCity = addressCity;
            AddressCounty = addressCounty;
            AddressPostcode = addressPostcode;
            DateOfBirth = dateOfBirth;
            EmergencyContactNumber = emergencyContactNumber;
            Gender = gender;
            Phone = phone;
            Email = email;
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressCounty { get; set; }
        public string AddressPostcode { get; set; }
        public string DateOfBirth { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }



    }
}
