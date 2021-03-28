using Primeiro.ApiWeb.Data.VO;
using Primeiro.ApiWeb.Models;

namespace Primeiro.ApiWeb.Services.Repository.Generic
{
    public interface IUserRepository
    {
        //Temos um metodo que valide as info do usuario

        User ValidateCredentials(UserVO user);
        User RefrashUserInfo(User user);
    }
}
