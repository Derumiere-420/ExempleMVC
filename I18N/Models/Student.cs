using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace I18N.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [DisplayName("Name")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "ValidationStringMinMax")]
        public string StudentName { get; set; }
        [DisplayName("Email")]
        public string StudentEmail { get; set;}
        [DisplayName("Phone")]
        public string StudentPhone { get; set;}


    }
}
