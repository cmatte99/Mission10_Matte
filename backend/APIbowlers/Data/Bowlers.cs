using System.ComponentModel.DataAnnotations;

namespace APIbowlers.Data
{
    // Represents the Bowlers table in the database
    public class Bowlers
    {
        // Primary key for the Bowlers table
        [Key]
        public int BowlerId { get; set; }

        // Last name of the bowler
        public string? BowlerLastName { get; set; }

        // First name of the bowler
        public string? BowlerFirstName { get; set; }

        // Middle initial of the bowler
        public string? BowlerMiddleInit { get; set; }

        // Address of the bowler
        public string? BowlerAddress { get; set; }

        // City of the bowler
        public string? BowlerCity { get; set; }

        // State of the bowler
        public string? BowlerState { get; set; }

        // Zip code of the bowler
        public string? BowlerZip { get; set; }

        // Phone number of the bowler
        public string? BowlerPhoneNumber { get; set; }

        // Foreign key referencing the TeamID of the team the bowler belongs to
        public int TeamID { get; set; }
    }
}
