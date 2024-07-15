using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="You must fill the Name field")]
        public string? Name { get; set; } //null
        
        [Required(ErrorMessage ="You must fill the Phone field")]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="You must fill the Email Address field")]
        [EmailAddress(ErrorMessage ="You must give a valid E-Mail address")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="You must select an Attend State")]
        public bool? WillAttend{ get; set; } // true, false, null       //default of bool is --> false
    }
}