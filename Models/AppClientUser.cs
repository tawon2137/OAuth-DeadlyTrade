using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthDeadlyTrade.Api.Models
{
    public class AppClientUser
    {   

        [Required]
        public int AppClientId { get; set; }
        public AppClient AppClient { get; set; }

        [Column(TypeName="Date")]
        [Required]
        public DateTime ExpiresAt { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }


        [Required] 
        public int AppTokenId { get; set; }

        public AppToken AppToken { get; set;}
        

        
    }
}