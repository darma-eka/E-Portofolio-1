using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string path = "index.html";
        string text = File.ReadAllText(path, Encoding.UTF8);

        text = text.Replace("â–¾", "▾");
        text = text.Replace("â€¢", "•");
        text = text.Replace("â€\u0093", "–");
        text = text.Replace("â€\u0094", "—");
        text = text.Replace("â†—", "↗");
        text = text.Replace("â†\u0090", "←");
        text = text.Replace("â†'", "→");
        text = text.Replace("âœ•", "✕");
        text = text.Replace("â€œ", "\"");
        text = text.Replace("â€\u009d", "\"");
        text = text.Replace("â€˜", "'");
        text = text.Replace("â€™", "'");
        text = text.Replace("â€º", "›");
        text = text.Replace("âš ï¸", "⚠️");
        
        text = text.Replace("ðŸ\u0084", "📄");
        text = text.Replace("ðŸ\u0098", "📘");
        text = text.Replace("ðŸ\u009a", "📚");
        text = text.Replace("ðŸ\u008d", "🔍");
        text = text.Replace("ðŸ\u008e", "🔎");
        text = text.Replace("ðŸš€", "🚀");
        text = text.Replace("ðŸŽ¯", "🎯");
        text = text.Replace("ðŸŽ\u0093", "🎓");
        text = text.Replace("ðŸ'\u00bb", "💻");
        text = text.Replace("ðŸ›¡ï¸", "🛡️");
        text = text.Replace("ðŸ¤\u009d", "🤝");
        text = text.Replace("ðŸ'\u00a5", "👥");
        text = text.Replace("ðŸŒŸ", "🌟");
        text = text.Replace("ðŸ\u0097", "🔗");
        
        // Literal replacements
        text = text.Replace("ðŸ“„", "📄");
        text = text.Replace("ðŸ“˜", "📘");
        text = text.Replace("ðŸ“š", "📚");
        text = text.Replace("ðŸ” ", "🔍");
        text = text.Replace("ðŸ”Ž", "🔎");
        text = text.Replace("ðŸŽ“", "🎓");
        text = text.Replace("ðŸ’»", "💻");
        text = text.Replace("ðŸ¤ ", "🤝");
        text = text.Replace("ðŸ‘¥", "👥");
        text = text.Replace("ðŸ”—", "🔗");
        text = text.Replace("ðŸ“ ", "📝");
        text = text.Replace("âž”", "➔");

        File.WriteAllText(path, text, new UTF8Encoding(false));
        Console.WriteLine("Done replacing characters.");
    }
}
