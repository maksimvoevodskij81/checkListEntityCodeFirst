using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityCheckListConsol
{
   public class Task
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isDone { get; set; }
        public string Priority { get; set; }
        public string Deadline { get; set; }

        public Category category { get; set; }

    }
}
