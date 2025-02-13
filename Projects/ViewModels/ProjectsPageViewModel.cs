using Projects.Model;
using Projects.Repositories.Projects;

namespace Projects.ViewModels
{
    public partial class ProjectsPageViewModel() : ObservableObject
    {
        private readonly IProjectRepository _repository;

        public ObservableCollection<Project> Projects { get; set; }
        = new ObservableCollection<Project>();

        public ProjectsPageViewModel(IProjectRepository repository) : this()
        {
            _repository = repository;
        }

        [RelayCommand]
        public async Task GetAllProjects()
        {
            Projects.Clear();

            try
            {
                var allProject = await _repository.GetAllProjectAsync();

                foreach (var project in allProject)
                {
                    Project newProject = new(project.ProjectName, project.UserName, project.FinishedAt.ToShortDateString(), project.DeadLine.ToShortDateString(), project.IdUser,project.IsFinished);

                    Projects.Add(newProject);
                }
                
            }
            catch (Exception ex)
            {

            }
        }

        [RelayCommand]
        public async Task GoToAddProjectPage()
   => await Shell.Current.GoToAsync(nameof(AddProjectPage));


        [RelayCommand]
        public void GoToDetailsProjectPage(Project project)
        {
            try
            {
                var navigationParams = new Dictionary<string, object>
                {
                {"Project", project }
                };

                Shell.Current.GoToAsync(nameof(DetailsProjectPage), navigationParams);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
  
    }
}
