using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class RegisteredUserCase
    {
        public ResponseRegisteredUser Execute(RequestRegisterUser request)
        {
            return new ResponseRegisteredUser()
            {
                Name = request.Name,
            };
        }

    }
    private void Validate(RequestRegisterUser request)
    {        
        
    }
}
