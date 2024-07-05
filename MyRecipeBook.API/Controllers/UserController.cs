﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Application.UseCases.User.Register;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterUser),StatusCodes.Status201Created)]
        public IActionResult Register(RequestRegisterUser request)
        {
            var useCase = new RegisterUserCase();
            var result = useCase.Execute(request);
            return Created(string.Empty, result);
        }
    }
}
