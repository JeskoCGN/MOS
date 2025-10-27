using CommunityToolkit.Mvvm.Input;
using MOS.Models;

namespace MOS.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}