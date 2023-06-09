using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersClient.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public List<string> Phones { get; set; }

        public ResponseServerViewModel? response { get; set; }
    }
}
