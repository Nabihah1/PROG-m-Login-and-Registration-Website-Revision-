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


        //constructor
        public Event()
        {

        }



    }
}
