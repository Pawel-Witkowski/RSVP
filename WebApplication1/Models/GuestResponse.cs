using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models {
    public class GuestResponse {
        [Required(ErrorMessage = "Prosze podac imie i nazwisko")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Prosze podac poprawny email")]
        [RegularExpression(".+\\@.+\\..+")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Prosze podac poprawny numer telefonu")]
        [RegularExpression("[0-9]{9,}")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "No wez powiedz czy przyjdziesz")]
        public bool?  WillAttend { get; set; }
    }
}