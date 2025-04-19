using TodoList.Communication.Responses;

namespace TodoList.Application.UseCases.TodoList.GetAll;

public class GetAllTodoJson
{
    public ResponseAllTodoJson Execute()
    {
        return new ResponseAllTodoJson
        {
            Todos = new List<ResponseShortTodoJson>
            {
                new ResponseShortTodoJson
                {
                    Id = 1,
                    Title = "Estudar C# .NET",
                    Description = "Completar exercícios",
                    Done = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            }
        };
    }
}