using Projects.Model;
using Projects.Repositories.Projects;

namespace Projects.ViewModels
{
    public partial class ProjectsPageViewModel(IProjectRepository repository) : ObservableObject
    {
        public ObservableCollection<Project> Projects { get; set; }
        = new ObservableCollection<Project>();

        [RelayCommand]
        public async Task GetAllProjects()
        {
            Projects.Clear();

            try
            {
                var allProject = await repository.GetAllProjectAsync();

                foreach (var project in allProject)
                {
                    Project newProject = new(project.ProjectName, project.UserName, project.FinishedAt.ToShortDateString(), project.DeadLine.ToShortDateString(), project.IdUser);

                    Projects.Add(newProject);
                }
                
            }
            catch (Exception ex)
            {

            }
        }
    }
}
