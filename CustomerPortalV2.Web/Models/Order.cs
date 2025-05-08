using System.ComponentModel.DataAnnotations;

namespace CustomerPortalV2.Web.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        public string? OrderNumber { get; set; } = ""; // Column must be NVARCHAR or VARCHAR in DB
        public string? PatientName { get; set; } = ""; // Column must be NVARCHAR or VARCHAR in DB
    }
}
