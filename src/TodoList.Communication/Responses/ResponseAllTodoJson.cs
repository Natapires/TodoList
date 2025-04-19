namespace TodoList.Communication.Responses;

public class ResponseAllTodoJson
{
    public List<ResponseShortTodoJson> Todos { get; set; } = [];
}