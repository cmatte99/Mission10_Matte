using System.ComponentModel.DataAnnotations;

namespace APIbowlers.Data
{
    public class Teams
    {
        [Key]
        public int TeamID { get; set; }

        public string? TeamName { get; set; }
        public int? CaptainID { get; set; }


        // Include other properties corresponding to columns in the "Teams" table
    }
}
