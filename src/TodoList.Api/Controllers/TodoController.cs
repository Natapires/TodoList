using Microsoft.AspNetCore.Mvc;
using TodoList.Application.UseCases.TodoList.Delete;
using TodoList.Application.UseCases.TodoList.Register;
using TodoList.Application.UseCases.TodoList.Update;
using TodoList.Communication.Requests;
using TodoList.Communication.Responses;

namespace TodoList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
       [HttpPost]
       [ProducesResponseType(typeof(ResponseRegisteredTodoJson), StatusCodes.Status201Created)]
       [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestTodoJson request)
        {
            var useCase = new RegisterTodoUseCase();
            var response = useCase.Execute(request);
            
            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("id")]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestTodoJson request)
        {
            var useCase = new UpdateTodoUseCase();
            useCase.Execute(id, request);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var useCase = new DeleteTodoUseCase();
            useCase.Execute(id);

            return NoContent();
        }
    }
}
