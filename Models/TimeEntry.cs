namespace TimeLogMvc.Models
{
    public class TimeEntry
    {
        public int Id { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public double Hours { get; set; }

        public int ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}
