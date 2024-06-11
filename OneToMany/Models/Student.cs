using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace OneToMany.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GradeId { get; set; }
        [ValidateNever]
        public Grade Grade { get; set; }
    }
}
