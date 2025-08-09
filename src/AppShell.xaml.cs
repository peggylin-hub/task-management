using System.Collections.ObjectModel;

namespace TaskManagementApp;

public partial class AppShell : Shell
{
	public ObservableCollection<TodoItem> FlyoutTodos { get; set; } = new();

	public AppShell()
	{
		InitializeComponent();
		
		// Initialize with sample todos
		FlyoutTodos.Add(new TodoItem { Title = "Review code", IsCompleted = false });
		FlyoutTodos.Add(new TodoItem { Title = "Update docs", IsCompleted = true });
		FlyoutTodos.Add(new TodoItem { Title = "Fix bug #123", IsCompleted = false });
		
		FlyoutTodoList.ItemsSource = FlyoutTodos;
	}

	private async void OnAddFlyoutTodoClicked(object sender, EventArgs e)
	{
		string result = await DisplayPromptAsync("New Todo", "Enter todo item:");
		if (!string.IsNullOrWhiteSpace(result))
		{
			FlyoutTodos.Add(new TodoItem { Title = result, IsCompleted = false });
		}
	}

	private async void OnHomeClicked(object sender, EventArgs e)
	{
		await GoToAsync("//MainPage");
		FlyoutIsPresented = false;
	}
}

public class TodoItem
{
	public string Title { get; set; } = string.Empty;
	public bool IsCompleted { get; set; }
}
