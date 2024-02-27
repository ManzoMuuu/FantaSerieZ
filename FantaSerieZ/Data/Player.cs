

using System.ComponentModel.DataAnnotations;

namespace FantaSerieZ.Data{
    public class Player{
        public string? TwitchName { get; set; }
        [Key]
        public string TwitchToken { get; set; }
        public int Points { get; set; }
        public bool HasPlayed { get; set; }
        public bool Manager { get; set; }
    }
}