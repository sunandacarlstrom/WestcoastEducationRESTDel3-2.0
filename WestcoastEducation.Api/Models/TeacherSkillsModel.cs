using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WestcoastEducation.Api.Models;
public class TeacherSkillsModel
{
    [Key]
    public int Id { get; set; }
    public int? TeacherId { get; set; }
    public string Skill { get; set; }

    //Navigation... 

    // The Many-Side (aggregation)
    // Ett kunskapsområde kan vara kopplat till flera lärare... 
    public ICollection<TeacherModel> Teachers { get; set; }
}
