namespace WebApplication1.Models
{
    public class InterviewCalendarModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string CompanyName { get; set; }
        public string State { get; set; }
        public string Model { get; set; }
        public string Result { get; set; }
    }
}