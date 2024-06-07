using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace OneToMany.Models
{
    public class Student
    {
        public int StudentId {get;set; }
        public string StudentName { get;set;}
        public int GradeId { get;set; }
        [ValidateNever]
        public Grade Grade { get;set; }
    }
}
