namespace BlazorServerApp.Data
{
    public class ToDoItem
    {
        public string Text { get; set; }
        public int Id { get; set; }
        public bool isCompleted { get; set; }
        public DateTime CreatedDate { get; init; } = DateTime.UtcNow;
        // public DateTime DueDate { get; set; }
        // public string Description { get; set; }

    }
}
