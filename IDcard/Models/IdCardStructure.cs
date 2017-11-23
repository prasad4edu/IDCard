using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Student.Models
{
    public class IdCardStructure
    {
      //  [HiddenInput(DisplayValue =false)]
        [DisplayName("ID")]
        [Required(ErrorMessage ="Please Enter Id Number")]
        public int intStudentID { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage ="Please Enter Student Name")]
        public string strStudentName { get; set; }
        
        [DisplayName("Date Of Birth")]       
        public string strDateOfBirth { get; set; }

        [DisplayName("Mobile Number")]       
        public long lngContactNumber { get; set; }

        [DisplayName("Address")]        
        public string strAddress1 { get; set; }

        [DisplayName("Street Name")]
        public string strAddress2 { get; set; }

        [DisplayName("Land Mark")]
        public string strLandMark { get; set; }

        [DisplayName("City")]
        public string strCity { get; set; }

        [DisplayName("Pincode")]
        public int intPincode { get; set; }

        [DisplayName("Photo")]
        public string strPhoto { get; set; }

        [DisplayName("Alternative Name")]
        public string strAlternativeName { get; set; }
    }
}