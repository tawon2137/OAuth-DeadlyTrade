using System.ComponentModel.DataAnnotations;

namespace AuthDeadlyTrade.Api.Models
{
    public class PoeAccount
    {   
        public int PoeAccountId { get; set; }

        [Required]
        public string Provider { get; set; }

        [Required]
        public string ConnectId { get; set; }

    }
}