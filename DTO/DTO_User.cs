using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_User
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public bool locked { get; set; }
        public DTO_User(string id, string user_id, string password, bool locked)
        {
            this.Id = id;
            this.Password = password;
            this.UserId = user_id;
            this.locked = locked;
        }
    }
}
