using System.Collections.ObjectModel;

namespace TaskManagementApp;

public partial class AppShell : Shell
{
	public ObservableCollection<TodoItem> FlyoutTodos { get; set; } = new();
	private bool _isPinned = true;

	public AppShell()
	{
		InitializeComponent();
		
		// Initialize with sample todos
		FlyoutTodos.Add(new TodoItem { Title = "Review code", IsCompleted = false });
		FlyoutTodos.Add(new TodoItem { Title = "Update docs", IsCompleted = true });
		FlyoutTodos.Add(new TodoItem { Title = "Fix bug #123", IsCompleted = false });
		
		FlyoutTodoList.ItemsSource = FlyoutTodos;
		UpdatePinButtonText();
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
		if (!_isPinned)
			FlyoutIsPresented = false;
	}

	private void OnPinClicked(object sender, EventArgs e)
	{
		_isPinned = !_isPinned;
		
		if (_isPinned)
		{
			FlyoutBehavior = FlyoutBehavior.Locked;
		}
		else
		{
			FlyoutBehavior = FlyoutBehavior.Flyout;
		}
		
		UpdatePinButtonText();
	}

	private void OnHideClicked(object sender, EventArgs e)
	{
		if (_isPinned)
		{
			// Temporarily unpin to allow hiding
			FlyoutBehavior = FlyoutBehavior.Flyout;
			FlyoutIsPresented = false;
			// Set back to locked after hiding
			FlyoutBehavior = FlyoutBehavior.Locked;
		}
		else
		{
			FlyoutIsPresented = false;
		}
	}

	private void UpdatePinButtonText()
	{
		PinButton.Text = _isPinned ? "📍" : "📌";
	}
}

public class TodoItem
{
	public string Title { get; set; } = string.Empty;
	public bool IsCompleted { get; set; }
}
