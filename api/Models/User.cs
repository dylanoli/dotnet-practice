using System;

using System.ComponentModel.DataAnnotations.Schema;
using api.Models.Core;

namespace api.Models
{
    [Table("user")]
    public class User : Entity
    {
        [Column("login")]
        public string Login { get; set; }

        [Column("password")]
        public string Password { get; set; }
        [Column("refresh_token")]
        public string RefreshToken { get; set; }
        [Column("refresh_token_expiry_time")]
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}