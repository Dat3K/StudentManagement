using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Staff
    {
        public DTO_Staff(string id, string name, DateTime? dOB, string gen,string job, string address, string phone, string email, string qual, string major, string workExp, string lang)
        {
            this.Id = id;
            this.Name = name;
            this.DOB = dOB;
            this.Gender = gen;
            this.Job = job;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Qualification = qual;
            this.Major = major;
            this.Experience = workExp;
            this.Language = lang;
        }



        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DOB { get; set; }
        public string Gender { get; set; }
        public string Job { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
        public string Major { get; set; }
        public string Experience { get; set; }
        public string Language { get; set; }
    }

}
