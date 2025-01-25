using Projects.Model;

namespace Projects.Repositories.Projects
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllProjectAsync();
        Task<bool> AddProjectAsync(Project project);

    }
}
