using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Staff
    {
        public DTO_Staff(string id, string fullName, DateTime? dOB, string gen,string job, string address, string phone, string email, string eduLv, string major, string workExp, string lang)
        {
            this.Id = id;
            this.FullName = fullName;
            this.DateOfBirth = dOB;
            this.Gender = gen;
            this.Job = job;
            this.Address = address;
            this.PhoneNumber = phone;
            this.Email = email;
            this.Qualification = eduLv;
            this.Major = major;
            this.WorkExperience = workExp;
            this.Language = lang;
        }



        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Job { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
        public string Major { get; set; }
        public string WorkExperience { get; set; }
        public string Language { get; set; }
    }

}
