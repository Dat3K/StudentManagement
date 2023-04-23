using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Teacher_id { get; set; }
        public string Start_date { get; set; }
        public string End_date { get; set; }
        public DTO_Course(string id, string name, string description, string teacher_id, string start_date, string end_date)
        {
            Id = id;
            Name = name;
            Description = description;
            Teacher_id = teacher_id;
            Start_date = start_date;
            End_date = end_date;
        }

    }

}
