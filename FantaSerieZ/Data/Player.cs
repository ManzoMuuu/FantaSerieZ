

using System.ComponentModel.DataAnnotations;

namespace FantaSerieZ.Data{
    public class Player{
        [Key]
        public int PlayerId { get; set; }
        public string? TwitchName { get; set; }
        public string? TwitchToken { get; set; }
        public int Points { get; set; }
        public bool HasPlayed { get; set; }
        public bool Manager { get; set; }
    }
}