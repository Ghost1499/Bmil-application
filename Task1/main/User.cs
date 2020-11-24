using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.main
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        public List<PasswordAction> PasswordActions { get; set; }
        public User() { }
        public User(string login)
        {
            Login = login;
            PasswordActions = new List<PasswordAction>();
        }
    }
}
