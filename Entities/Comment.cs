﻿namespace Entities;

public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }
}

