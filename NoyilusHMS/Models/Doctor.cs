using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NotilusHMS.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [Required(ErrorMessage = "A name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Phone]
        [Required(ErrorMessage = "The mobile number is required.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile Number")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "The email is required.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Recidence")]
        public string Address1 { get; set; }
        [Display(Name = "Address")]
        public string Address2 { get; set; }
        [Display(Name = "Speciality")]
        public string Speciality { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Registered Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegisteredDate { get; set; }
        [Display(Name = "Other Details")]
        [DataType(DataType.MultilineText)]
        public string Details { get; set; }

    }
}