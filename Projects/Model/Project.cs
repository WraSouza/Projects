namespace Projects.Model
{
    public class Project
    {
        public Project(string projectName,string userName, string finishedAt, string deadLine, int idUser)
        {
            ProjectName = projectName;
            UserName = userName;
            FinishedAt = finishedAt;
            DeadLine = deadLine;
            IdUser = idUser;
            IsFinished = false;
           
        }

        public string ProjectName { get; private set; }
        public string UserName { get; private set; }
        public string FinishedAt { get; private set; }
        public string DeadLine { get; private set; }
        public int IdUser { get; private set; }
        public bool IsFinished { get; private set; }

    }
}
