using System.ComponentModel.DataAnnotations;

namespace AuthDeadlyTrade.Api.Models
{
    public class AppClientUser
    {   

        [Required]
        public int AppClientId { get; set; }
        public AppClient AppClient { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        
    }
}