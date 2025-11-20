using CarWashManagement.Core.Features;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

public class PasswordStrengthEvaluator
{
    private readonly List<PasswordRequirement> _requirements;
    private readonly Dictionary<int, StrengthLevel> _strengthLevels;

    public PasswordStrengthEvaluator()
    {
        // Define all your rules in one place. Easy to add, remove, or change!
        _requirements = new List<PasswordRequirement>
        {
            new PasswordRequirement(p => p.Length >= 8, "At least 8 characters"),
            new PasswordRequirement(p => p.Any(char.IsUpper), "Contains an uppercase letter"),
            new PasswordRequirement(p => p.Any(char.IsLower), "Contains a lowercase letter"),
            new PasswordRequirement(p => p.Any(char.IsDigit), "Contains a digit"),
            new PasswordRequirement(p => p.Any(ch => !char.IsLetterOrDigit(ch)), "Contains a special character")
        };

        // Define the mapping from score to strength level.
        _strengthLevels = new Dictionary<int, StrengthLevel>
        {
            { 0, new StrengthLevel("Very Weak", Color.Red) },
            { 1, new StrengthLevel("Very Weak", Color.Red) },
            { 2, new StrengthLevel("Weak", Color.OrangeRed) },
            { 3, new StrengthLevel("Medium", Color.Orange) },
            { 4, new StrengthLevel("Strong", Color.YellowGreen) },
            { 5, new StrengthLevel("Very Strong", Color.Green) }
        };
    }

    public int MaxScore => _requirements.Count;

    public (int Score, StrengthLevel Level) Evaluate(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            return (0, _strengthLevels[0]);
        }

        // Count how many requirements are met.
        int score = _requirements.Count(r => r.IsMet(password));

        return (score, _strengthLevels[score]);
    }
}