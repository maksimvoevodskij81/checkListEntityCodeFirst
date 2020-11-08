namespace entityCheckListConsol
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CheckListContext : DbContext
    {

        public CheckListContext()
            : base("name=CheckListContext")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
      
}