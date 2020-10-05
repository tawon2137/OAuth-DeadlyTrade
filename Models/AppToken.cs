using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AuthDeadlyTrade.Api.Models
{
    public class AppToken
    {   
        public int AppTokenId { get; set; }

        [Required]
        public string AccessToken { get; set; }
        
        [Required]
        [Column(TypeName="Date")]
        public DateTime AccessTokenExpiresAt { get; set; }

        [Required]
        public string RefreshToken { get; set; }
        
        [Required]
        [Column(TypeName="Date")]
        public DateTime RefreshTokenExpiresAt { get; set; }


    }
}