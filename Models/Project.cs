using System.Collections.Generic;

namespace TimeLogMvc.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<TimeEntry> TimeEntries { get; set; } = new();
    }
}
