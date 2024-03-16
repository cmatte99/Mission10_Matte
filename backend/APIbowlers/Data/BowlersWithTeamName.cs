namespace APIbowlers.Data
{
    // Represents a bowler with their associated team name
    public class BowlerWithTeamName
    {
        // Unique identifier for the bowler
        public int BowlerId { get; set; }

        // First name of the bowler
        public string? BowlerFirstName { get; set; }

        // Middle name of the bowler
        public string? BowlerMiddleName { get; set; }

        // Last name of the bowler
        public string? BowlerLastName { get; set; }

        // Address of the bowler
        public string? BowlerAddress { get; set; }

        // City of the bowler
        public string? BowlerCity { get; set; }

        // State of the bowler
        public string? BowlerState { get; set; }

        // Zip code of the bowler
        public string? BowlerZip { get; set; }

        // Phone number of the bowler
        public string? BowlerPhone { get; set; }

        // Name of the team the bowler belongs to
        public string? TeamName { get; set; }
    }
}
