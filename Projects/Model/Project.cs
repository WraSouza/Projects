namespace Projects.Model
{
    public class Project
    {
        public Project(string projectName, string userName, string finishedAt, string deadLine, int idUser, bool isFinished)
        {
            ProjectName = projectName;
            UserName = userName;
            FinishedAt = finishedAt;
            DeadLine = deadLine;
            IdUser = idUser;
            IsFinished = isFinished;
        }

        public string ProjectName { get; set; }
        public string UserName { get; set; }
        public string FinishedAt { get; set; }
        public string DeadLine { get; set; }
        public int IdUser { get; set; }
        public bool IsFinished { get; set; }


    }
}
