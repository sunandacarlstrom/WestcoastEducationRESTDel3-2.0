using System.ComponentModel.DataAnnotations;

namespace WestcoastEducation.Api.Models;
public class TeacherModel
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    //Navigation... 

    // The Many-Side (aggregation)
    public ICollection<CourseModel> Courses { get; set; }

    // The Many-Side (aggregation)
    // En lärare kan besitta kunskaper inom flera områden...  
    public ICollection<TeacherSkillsModel> Skills { get; set; }
}
