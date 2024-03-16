using System.ComponentModel.DataAnnotations;

namespace APIbowlers.Data
{
    // Represents a team entity in the database
    public class Teams
    {
        // Primary key for the Teams table
        [Key]
        public int TeamID { get; set; }

        // Name of the team
        public string? TeamName { get; set; }

        // ID of the team's captain (nullable)
        public int? CaptainID { get; set; }

        // Include other properties corresponding to columns in the "Teams" table
    }
}
