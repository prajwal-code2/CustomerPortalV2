using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerPortalV2.Web.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int AutoID { get; set; }

        public string Username { get; set; } = "";
        public string Password { get; set; } = "";

        // Optional extra fields from your DB
        public string? FirstName { get; set; }
        public string? Lastname { get; set; }
        public string? Middle { get; set; }
        public string? Groups { get; set; }
        public string? Language { get; set; }
    }
}
