using WestcoastEducation.Api.Models;

namespace WestcoastEducation.Api.ViewModels;
public class CourseListViewModel
{
    public int Id { get; set; }
    public string Teacher { get; set; }
    public string Number { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}
