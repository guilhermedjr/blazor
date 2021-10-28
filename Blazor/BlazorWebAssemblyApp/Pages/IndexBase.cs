using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorWebAssemblyApp.Pages
{
    public class IndexBase : ComponentBase
    {
        protected class TodoItem
        {
            public string Title { get; set; }
            public bool IsDone { get; set; }
        }

        protected string newTodo = "";
        protected List<TodoItem> todos = new();

        protected void AddNewTask()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = "";
            }
        }
    }
}
