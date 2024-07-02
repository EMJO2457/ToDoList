using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;



namespace ToDoList
{
    public class ToDo_List
    {
        public int ID { get; set; }
        [StringLength(800)]
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "DateTime")]
        public DateTime DueDate { get; set; } = default(DateTime);
        [StringLength(30)]
        public string Status { get; set; } = "Active";
        [StringLength(30)]
        public string Priority { get; set; } = string.Empty;





    }
}
