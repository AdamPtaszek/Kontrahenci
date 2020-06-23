using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestKontrahenci.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(80)]
        [DisplayName("Miasto")]
        public string City { get; set; }
        [StringLength(6)]
        [RegularExpression(@"[0-9]{2}-[0-9]{3}", ErrorMessage = "Format kodu pocztowego xx-xxx")]
        [DisplayName("Kod pocztowy")]
        public string PostalCode { get; set; }
        [Required]
        [MaxLength(60)]
        [DisplayName("Ulica")]
        public string Street { get; set; }
        [Required]
        [MaxLength(10)]
        [DisplayName("Numer domu")]
        public string HouseNumber { get; set; }
    }
}