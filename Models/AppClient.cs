using System.ComponentModel.DataAnnotations;

namespace AuthDeadlyTrade.Api.Models
{
    public class AppClient
    {   
        public long Id { get; set; }

        [Required]
        public string ClientId { get; set; }

        [Required]
        public string ClientSecret { get; set; }

        [Required]
        public string RedirectUri { get; set; }

        [Required]
        public bool IsExpired { get; set; }
    }
}