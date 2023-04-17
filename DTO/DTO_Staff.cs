using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Staff
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public float Salary { get; set; }

        // Phương thức khởi tạo
        public DTO_Staff(string id, string name, int age, string gender, string address, string phone, string email, string position, float salary)
        {
            ID = id;
            Name = name;
            Age = age;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            Position = position;
            Salary = salary;
        }
    }

}
