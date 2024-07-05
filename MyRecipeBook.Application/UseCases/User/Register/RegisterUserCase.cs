using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class RegisterUserCase
    {
        public ResponseRegisterUser Execute(RequestRegisterUser request)
        {
            Validate(request);
            return new ResponseRegisterUser()
            {
                Name = request.Name,
            };
        }


        private void Validate(RequestRegisterUser request)
        {
            var validator = new RegisterUserValidator();
            var result = validator.Validate(request);
            if (!result.IsValid)
            {
                var errorMessages = result.Errors.Select(e => e.ErrorMessage);
            }
        }
    }

}
