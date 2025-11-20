using System;
using System.Drawing;

public class PasswordRequirement
{
    public Func<string, bool> IsMet { get; }
    public string Description { get; }

    public PasswordRequirement(Func<string, bool> predicate, string description)
    {
        IsMet = predicate;
        Description = description;
    }
}