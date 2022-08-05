using System;
using System.ComponentModel.DataAnnotations;
using HelloWorld.Pages;

namespace HelloWorld.Model
{
    public class UserModel
    {
        //Register
        [Required]
        public string Anrede1 { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Vorname1 { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Nachname1 { get; set; }
        [Required]
        [EmailAddress]
        public string Email1 { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Passwort1 { get; set; }
        [Required]
        public string Strasse1 { get; set; }
        [Required]
        [Range(1, 9999)]
        public string PLZ1 { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Ort1 { get; set; }
        [Required]
        public string Land1 { get; set; }
        public bool EnableAddress { get; set; }

        //Zusatz-Adresse
        public string Anrede2 { get; set; }
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Vorname2 { get; set; }
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Nachname2 { get; set; }
        public string Strasse2 { get; set; }
        public string PLZ2 { get; set; }
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Ort2 { get; set; }
        public string Land2 { get; set; }

        //Login
        [Required]
        [EmailAddress]
        public string Email2 { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Passwort2 { get; set; }
    }
}