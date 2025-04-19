using TodoList.Communication.Requests;
using TodoList.Communication.Responses;

namespace TodoList.Application.UseCases.TodoList.Register;

public class RegisterTodoUseCase
{
    public ResponseRegisteredTodoJson Execute(RequestTodoJson request)
    {
        return new ResponseRegisteredTodoJson
        {
            Title = request.Title,
            Description = request.Description
        };
        
    }
}