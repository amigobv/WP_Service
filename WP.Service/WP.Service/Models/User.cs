using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WP.Service.Models
{
    public class User
    {
        public int UserId { get; set; }
        [ConcurrencyCheck, Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public ICollection<Alternative> Tasks { get; set; }

        public User()
        {
            Tasks = new HashSet<Alternative>();
        }
    }
}