using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.Client.Model;
using TurntablRoleManager.Client.Services;

namespace TurntablRoleManager.Client.Components
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        [Inject]
        public IRoleDataService RoleDataService { get; set; }

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        public UpdateEmployeeModel UpdateEmployeeModel { get; set; } = new UpdateEmployeeModel();
        public IEnumerable<RoleModel> Roles { get; set; } = new List<RoleModel>();
        public EmployeeDetailsModel EmployeeDetailsModel { get; set; } = new EmployeeDetailsModel();
        public bool ShowDialog { get; set; }
        public bool ShowBackdrop { get; set; }
        public Guid SelectedRole { get; set; }

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
            Roles = (await RoleDataService.GetAllRoles()).ToList();
            SelectedRole = EmployeeDetailsModel.Roles[0].Id;
            StateHasChanged();
         }
        protected async Task HandleValidSubmit()
        {
        UpdateEmployeeModel.EmployeeFirstName = EmployeeDetailsModel.EmployeeFirstName;
        UpdateEmployeeModel.EmployeeLastName = EmployeeDetailsModel.EmployeeLastName;
        UpdateEmployeeModel.EmployeeEmail = EmployeeDetailsModel.EmployeeEmail;
        UpdateEmployeeModel.EmployeeAddress = EmployeeDetailsModel.EmployeeAddress;
        UpdateEmployeeModel.EmployeeId = EmployeeDetailsModel.EmployeeId;
        UpdateEmployeeModel.RoleIds.Add(SelectedRole);

        await EmployeeDataService.UpdateEmployee(UpdateEmployeeModel);
        await CloseEventCallback.InvokeAsync(true);

        ShowDialog = false;
        ShowBackdrop = false;
        StateHasChanged();
        }
    }
}
