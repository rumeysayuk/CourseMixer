namespace CourseMixer.Models
{
   public class Candidate{
    public String? Email { get; set; }=String.Empty;
    public String? FistName { get; set; }=String.Empty;
    public String? LastName { get; set; }=String.Empty;
    public String? FullName => $"{FistName} {LastName?.ToUpper()}";
    public int Age { get; set; }
    public String? SelectedCourse { get; set; }=String.Empty;
    public DateTime ApplyAt { get; set; }
    
    public Candidate(){
        ApplyAt=DateTime.Now;
    }
   }
}