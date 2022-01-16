using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IBuS_6._0.Models
{
    public class SendMail
    {
        public class Models
        {
            public class MailModel
            {
                [Required]
                [Display(Name = "Email")]
                [EmailAddress]
                public string From { get; set; }
                public string To { get; set; }
                [Required]
                [Display(Name = "Nome")]
                public string Subject { get; set; }
                [Required]
                [Display(Name = "Escreva sua menssagem")]
                public string Body { get; set; }
            }
        }
    }
}