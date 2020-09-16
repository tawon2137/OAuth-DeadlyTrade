using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AuthDeadlyTrade.Api.Models
{
    public class User
    {   
        public int UserId { get; set; }

        [Required]
        public string LoginId { get; set; }

        [Required]
        public string Provider { get; set; }

        [Required]
        public string AccessToken { get; set; }

        [Required]
        public string RefreshToken { get; set; }


        public int PoeAccountId { get; set; }
        public PoeAccount PoeAccount { get; set; }

        public List<AppClientUser> AppClientUsers { get; set; }
    }
}