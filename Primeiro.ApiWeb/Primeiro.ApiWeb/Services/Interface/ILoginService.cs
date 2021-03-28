using Primeiro.ApiWeb.Data.VO;

namespace Primeiro.ApiWeb.Services.Interface
{
    public interface ILoginService
    {
        TokenVO ValidateCredentials(UserVO user);
    }
}
