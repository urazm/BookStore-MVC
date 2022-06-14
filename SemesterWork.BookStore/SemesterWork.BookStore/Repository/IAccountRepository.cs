using Microsoft.AspNetCore.Identity;
using SemesterWork.BookStore.Models;
using System.Threading.Tasks;

namespace SemesterWork.BookStore.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);
        Task SignOutAsync();
    }
}