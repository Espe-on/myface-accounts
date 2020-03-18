using Microsoft.AspNetCore.Http;

namespace MyFace.Services
{
    public interface IAuthservice
    {
        bool HasValidAuthorization(HttpRequest request);
    }
    
    public class AuthService : IAuthservice
    {
        public bool HasValidAuthorization(HttpRequest request) 
        {
            return true;
        }
    }
}