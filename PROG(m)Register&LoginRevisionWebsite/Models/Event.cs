using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;

namespace PROG_m_Register_LoginRevisionWebsite.Models
{
    public class Event
    {

        [Key]
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventDateTime { get; set; }
        public string EventAddress { get; set; }
        public string AttendeeName { get; set; }
        public string  AttendeeEmail { get; set; }
        public string PaymentMethod { get; set; }
        public double PaymentAmount { get; set; }


        //constructor
        public Event()
        {

        }



    }
}
