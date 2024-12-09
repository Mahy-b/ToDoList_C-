using System.ComponentModel.DataAnnotations;
using Microsoft.Build.Framework;

namespace TodoList2
{
    public class Todo
    {
        public int Id { get; set; }

        [Microsoft.Build.Framework.Required]
        public string Context { get; set; }
        [DataType(DataType.Date)]
        public bool IsDone { get; set; }

        public string TimeNedded { get; set; }
        public int Priority { get; set; }
        public int Urgent { get; set; }
        public string Regularity { get; set; }


    }
}
