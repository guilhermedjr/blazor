using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;

namespace BlazorWebAssemblyApp.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        protected IJSRuntime JsRuntime { get; set; }

        protected class TodoItem
        {
            public string Title { get; set; }
            public bool IsDone { get; set; }
        }

        protected string newTodo = "";
        protected List<TodoItem> todos = new();

        protected async void AddNewTask()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                string todoName = newTodo;
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = "";
                await JsRuntime.InvokeVoidAsync("showMessage", todoName);
            }
        }

        protected void CheckTask(TodoItem todo)
        {
            todos.Remove(todo);
        }
    }
}
