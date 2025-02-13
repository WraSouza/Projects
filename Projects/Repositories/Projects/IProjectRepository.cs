using Projects.Model;

namespace Projects.Repositories.Projects
{
    public interface IProjectRepository
    {
        Task<List<ProjectResponse>> GetAllProjectAsync();
        Task<bool> AddProjectAsync(ProjectInputModel project);

    }
}
