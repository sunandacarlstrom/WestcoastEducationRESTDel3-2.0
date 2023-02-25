namespace WestcoastEducation.Api.Models;

public class StudentModelCourseModel
{
    public CourseStatusEnum Status { get; set; }

    //Navigation... 

    public int? CourseId { get; set; }
    //P.S. här behövs inte en foreignkey eftersom EFCore är så pass intelligent som förstår detta ändå 
    public CourseModel Course { get; set; }

    public int StudentId { get; set; }
    //P.S. här behövs inte en foreignkey eftersom EFCore är så pass intelligent som förstår detta ändå 
    public StudentModel Student { get; set; }
}
