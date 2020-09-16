using System.ComponentModel.DataAnnotations;

namespace AuthDeadlyTrade.Api.Models
{
    public class AccessRole
    {   
        public int AccessRoleId { get; set; }

        [Required]
        public string Role { get; set; }

        public int UserId { get; set; }
        
        public User User { get; set; }

    }   
}