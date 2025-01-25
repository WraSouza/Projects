using Flurl.Http;
using Projects.Helpers;
using Projects.Model;

namespace Projects.Repositories.Projects
{
    public class ProjectRepository : IProjectRepository
    {
        public Task<bool> AddProjectAsync(Project project)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Project>> GetAllProjectAsync()
        {
            List<Project> project = [];
            try
            {
                var allProjects = await SitesURL.projectAPI.GetJsonAsync<List<Project>>();
                return allProjects;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw new Exception();
            }

            return project;
            
        }
    }
}
