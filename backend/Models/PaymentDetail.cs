using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace aspnetcoreapp.Models
{
    public class PaymentDetail{
        [Key]
        public int pmId { get; set; }[Required]
        [Column(TypeName = "nvarchar(100)")]
        public string cardOwner { get; set; }[Required]
        [Column(TypeName = "varchar(16)")]
        public string cardNumber { get; set; }[Required]
        [Column(TypeName = "varchar(5)")]
        public string expirationDate { get; set; }[Required]
        [Column(TypeName = "varchar(3)")]
        public string cvv { get; set; }

    }
}