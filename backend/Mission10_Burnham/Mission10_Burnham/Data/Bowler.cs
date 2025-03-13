using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Burnham.Data;
public class Bowler
{
    [Key]
    public int BowlerID { get; set; }

    [Required]
    public string BowlerFirstName { get; set; }

    public string? BowlerMiddleInit { get; set; } 

    [Required]
    public string BowlerLastName { get; set; }
    
    public string BowlerAddress { get; set; }
    
    public string BowlerCity { get; set; }

    public string BowlerState { get; set; } = string.Empty; // Initialize with a default value
    public string BowlerZip { get; set; } = string.Empty;  // Initialize with a default value
    
    public string BowlerPhoneNumber { get; set; }

    [Required]
    [ForeignKey("Team")]
    public int TeamID { get; set; }

    public Team Team { get; set; }  // Navigation property

}
