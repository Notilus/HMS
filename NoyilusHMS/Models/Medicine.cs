using NotilusHMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NoyilusHMS.Models
{
    public class Medicine
    {
        [Key]
        public int PatientId { get; set; }

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

        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Recidence")]
        public string Address1 { get; set; }

        [Display(Name = "Address")]
        public string Address2 { get; set; }

        [Display(Name = "Assigned Doctor")]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Registered Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegisteredDate { get; set; }

        [Display(Name = "Details")]
        [DataType(DataType.MultilineText)]
        public string Details { get; set; }
    }
}