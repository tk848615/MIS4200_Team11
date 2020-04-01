using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200_Team11.Models
{
    public class Recognition
    {
        [Key]
        public int recognitionID { get; set; }


        [Display(Name = "Employee")]
        public string employeeName{ get; set; }
       




        [Display(Name = "Recognition Description")]
        [Required(ErrorMessage = "Description is Required")]
        public string description { get; set; }


        [Display(Name = "Date of Recognition")]
        [Required(ErrorMessage = "Date is Required")]
        [DataType(DataType.Date)]
        public DateTime dateOfRecognition { get; set; }


        public virtual UserDetails UserDetails { get; set; }

    }
}