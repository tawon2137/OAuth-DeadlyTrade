using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AuthDeadlyTrade.Api.Models
{
    public class AppClient
    {   
        public int AppClientId { get; set; }

        [Required]
        public string ClientId { get; set; }

        [Required]
        public string ClientSecret { get; set; }

        [Required]
        public string RedirectUri { get; set; }

        [Required]
        public bool IsExpired { get; set; } 

        public string[] Grants { get; set; }

        public List<AppClientUser> AppClientUsers { get; set; }

    }
}