using RestSharp;
using RestSharp.Authenticators;
using System.Configuration;
using System.Security.Policy;
using UsersClient.ViewModels;

namespace UsersClient.Requests
{
    public class Requester : IRequester
    {
        private AppSettingsReader _appSettingsReader;
        private readonly RestClient _client;
        public Requester() 
        {
            _appSettingsReader = new AppSettingsReader();

            var options = new RestClientOptions((string)_appSettingsReader.GetValue("address", typeof(string)));

            _client = new RestClient(options);
        }

        public async Task<List<UserViewModel>> GetAllUsersAsync()
        {
            var request = new RestRequest();

            var response = await _client.ExecuteGetAsync<List<UserViewModel>>(request);

            return response.Data;
        }

        public async Task<UserViewModel> GetUserAsync(string phoneNumber)
        {
            var request = new RestRequest().AddParameter("phoneNumber", phoneNumber);

            var response = await _client.ExecuteGetAsync<UserViewModel>(request);

            if (response != null) 
            {

            }

            return response.Data;
        }

        public async Task<string> CreateUserAsync(UserViewModel userViewModel)
        {
            var request = new RestRequest();

            request.AddJsonBody(userViewModel);

            var response = await _client.ExecutePostAsync<ResponseServerViewModel>(request);

            if (response.Data.Error)
            {
                return response.Data.ErrorText;
            }
            else
            {
                return "Пользователь успешно создан.";
            }
        }

        public async Task<string> ChangeUserAsync(UserViewModel userViewModel)
        {
            var request = new RestRequest();

            request.AddJsonBody(userViewModel);

            var response = await _client.ExecutePutAsync<ResponseServerViewModel>(request);

            if (response.Data.Error)
            {
                return response.Data.ErrorText;
            }
            else
            {
                return "Данные успешно изменены.";
            }
        }
        public async Task<string> DeleteUserAsync(string phoneNumber)
        {
            var request = new RestRequest();

            request.AddJsonBody(new DeleteUserViewModel 
            {
                PhoneNumber = phoneNumber
            });

            var response = await _client.DeleteAsync<ResponseServerViewModel>(request);

            if (response.Error)
            {
                return response.ErrorText;
            }
            else 
            {
                return "Удаление прошло успешно.";
            }
        }

    }
}
