using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestKontrahenci.Models
{
    public class Kontractor
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(60)]
        [DisplayName("Imie")]
        public string Name { get; set; }
        [MaxLength(60)]
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }
        [StringLength(11, MinimumLength = 11)]
        [MaxLength(11)]
        [DisplayName("Pesel")]
        public string Pesel { get; set; }
        public virtual Address Address { get; set; }
    }
}