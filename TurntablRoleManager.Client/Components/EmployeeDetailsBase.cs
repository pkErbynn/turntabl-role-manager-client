using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.Client.Model;
using TurntablRoleManager.Client.Services;

namespace TurntablRoleManager.Client.Components
{
    public class EmployeeDetailsBase: ComponentBase
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        public EmployeeDetailsModel EmployeeDetailsModel { get; set; } = new EmployeeDetailsModel();
        public bool ShowDialog { get; set; }
        public bool ShowBackdrop { get; set; }

        public void Show(int Id)
        {
            ResetDialog(Id);
            ShowDialog = true;
            ShowBackdrop = true;
            StateHasChanged();
        }

        public void Close()
        {
            ShowDialog = false;
            ShowBackdrop = false;
            StateHasChanged();
        }

        public async void ResetDialog(int Id)
        {
            EmployeeDetailsModel = await EmployeeDataService.GetEmployeeDetails(Id);
            StateHasChanged();
        }
    }
}
