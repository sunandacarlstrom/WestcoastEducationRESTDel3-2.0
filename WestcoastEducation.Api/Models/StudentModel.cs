using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WestcoastEducation.Api.Models;
public class StudentModel
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    //Navigation... 

    // The Many-Side (aggregation)
    // En student kan vara anmäld till flera kurser samtidigt... 
    public ICollection<StudentModelCourseModel> StudentCourses { get; set; }
}
