using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TurntablRoleManager.Client.Model;

namespace TurntablRoleManager.Client.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient _httpClient;
        public EmployeeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<EmployeeDetailsModel>> GetAllEmployees()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<EmployeeDetailsModel>>
                   (await _httpClient.GetStreamAsync("api/employees"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<EmployeeResponse> AddEmployee(EmployeeModel employee)
        {
            var employeeJson =
                new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/employees", employeeJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<EmployeeResponse>(await response.Content.ReadAsStreamAsync());
            }

            return null;    
        }

        public async Task<EmployeeDetailsModel> GetEmployeeDetails(int employeeId)
        {
            return await JsonSerializer.DeserializeAsync<EmployeeDetailsModel>
              (await _httpClient.GetStreamAsync($"api/employees/{employeeId}"), new JsonSerializerOptions(){ PropertyNameCaseInsensitive = true }); 
        }

        public async Task UpdateEmployee(UpdateEmployeeModel employee)
        {
            var employeeJson =
            new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("api/employees", employeeJson);
        }

        public async Task DeleteEmployee(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/employees/{id}");
            Console.WriteLine("Result: " + result);
        }
    }
}
