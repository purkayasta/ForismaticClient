using System.Text.Json.Serialization;

namespace Forismatic.Models
{
    public class QuoteDto
    {
        [JsonPropertyName("quoteText")]
        public string? Quote { get; set; }

        [JsonPropertyName("quoteAuthor")]
        public string? Author { get; set; }

        [JsonPropertyName("senderName")]
        public string? Sender { get; set; }

        [JsonPropertyName("senderLink")]
        public string? SenderLink { get; set; }

        [JsonPropertyName("quoteLink")]
        public string? Link { get; set; }
    }
}