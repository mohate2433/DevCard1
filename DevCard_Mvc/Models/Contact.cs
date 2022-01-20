using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="این فیلد اجباری است")]
        [MinLength(3,ErrorMessage ="حداقل 3 کاراکتر")]
        [MaxLength(100,ErrorMessage ="حداکثر 100 کاراکتر")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage ="لطفا ایمیل خود را صحیح وارد کنید")]
        public string Email { get; set; }
        public string message { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public SelectList Services { get; set; }
    }
}
