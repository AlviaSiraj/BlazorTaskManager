using System;

namespace BlazorApp.Models;

public class TodoItem
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int? Time { get; set; }
    public bool IsDone { get; set; } = false;
}
