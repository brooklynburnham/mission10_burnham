using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Burnham.Data;
public class Team
{
    [Key]
    public int TeamID { get; set; }

    [Required]
    public string TeamName { get; set; }

    // Navigation property for related Bowlers
    public ICollection<Bowler> Bowlers { get; set; }
}
