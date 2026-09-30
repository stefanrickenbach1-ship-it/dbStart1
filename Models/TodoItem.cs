using System.ComponentModel.DataAnnotations;

namespace DbStart1.Models;

public sealed class TodoItem
{
    public int Id { get; set; }

    [Required]
    [MaxLength(160)]
    public string Title { get; set; } = string.Empty;

    public bool IsCompleted { get; set; }

    public DateTime CreatedAt { get; set; }
}