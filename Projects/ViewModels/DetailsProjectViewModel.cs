using DevExpress.Utils.About;
using Projects.Model;

namespace Projects.ViewModels
{
    [QueryProperty(nameof(Project), nameof(Project))]
    public partial class DetailsProjectViewModel : ObservableObject
    {
        private Project _project;
        public Project Project
        {
            get => _project;
            set
            {
                SetProperty(ref _project, value);

                if (value != null)
                {
                    projectName = value.ProjectName;
                    owner = value.UserName;
                    deadLine = value.DeadLine;

                }
            }
        }


        [ObservableProperty]
        string? projectName;

        [ObservableProperty]
        string owner;

        [ObservableProperty]
        string deadLine;
    }
}
