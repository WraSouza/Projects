using Flurl.Http;
using Projects.Helpers;
using Projects.Model;

namespace Projects.Repositories.Projects
{
    public class ProjectRepository : IProjectRepository
    {
        public async Task<bool> AddProjectAsync(ProjectInputModel project)
        {
            //throw new NotImplementedException();
            bool result = false;

            try
            {
                var newProject = await SitesURL.projectAPI.PostJsonAsync(project);

                if (newProject.ResponseMessage.IsSuccessStatusCode)
                {
                    result = true;
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());   
            }

            return result;
        }

        public async Task<List<ProjectResponse>> GetAllProjectAsync()
        {
            List<ProjectResponse> project = [];
            try
            {
                var allProjects = await SitesURL.projectAPI.GetJsonAsync<List<ProjectResponse>>();
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
