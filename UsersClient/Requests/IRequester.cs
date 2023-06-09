using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersClient.ViewModels;

namespace UsersClient.Requests
{
    public interface IRequester
    {
        public Task<List<UserViewModel>> GetAllUsersAsync();

        public Task<UserViewModel> GetUserAsync(string phoneNumber);

        public Task<string> CreateUserAsync(UserViewModel userViewModel);

        public Task<string> ChangeUserAsync(UserViewModel userViewModel);

        public Task<string> DeleteUserAsync(string phoneNumber);
    }

}
