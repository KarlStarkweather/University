using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
  public class StudentLevel
  {
    public StudentLevel()
    {
      this.Students = new HashSet<Student>();
    }
    [Key]
    public int LevelId {get; set; }
    public string LevelName {get; set; }
    public virtual ICollection<Student> Students {get; set; }
  }
}