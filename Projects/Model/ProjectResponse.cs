namespace Projects.Model
{
    public class ProjectResponse
    {
        

        public string ProjectName { get; set; }
        public string UserName { get; set; }
        public DateTime FinishedAt { get; set; }
        public DateTime DeadLine { get; set; }
        public int IdUser { get; set; }
        public bool IsFinished { get; set; }
    }
}
