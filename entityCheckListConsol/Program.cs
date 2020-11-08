using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityCheckListConsol
{
    class Program
    {
        public Category AddCategory()
        {
            Console.WriteLine("Enter a Name Category :");
            string _Name = Console.ReadLine();
          
            using (CheckListContext db = new CheckListContext())
            {
                foreach (Category categor in db.Categories)
                {
                    if (categor.Name == _Name)
                    {
                        Console.WriteLine(" Category existing ");
                        return categor;
                    }
                   
                }
                Category category = new Category { Name = _Name };
                db.Categories.Add(category);
                db.SaveChanges();
                Console.WriteLine(" Category add ");
                return category;
            }
           

        }
        void AddTask()
        {
            //Console.WriteLine("Enter a Name Category for Task :");
            //string _NameForTask = Console.ReadLine();
           Category categoryName= AddCategory();
            Console.WriteLine("Enter a Name Task :");
            string _Name = Console.ReadLine();
            //Console.WriteLine("Enter  Task isDone :");
            //string _isDone = Console.ReadLine();
            Console.WriteLine("Enter  Deadline :");
            string _Deadline = Console.ReadLine();
            Console.WriteLine("Enter  Priority :");
            string _Priority = Console.ReadLine();
            using (CheckListContext db = new CheckListContext())
            {
                Task task = new Task { Name = _Name, isDone = false, category = db.Categories.Where(p => p.Name == categoryName.Name).First<Category>(), Deadline = _Deadline, Priority = _Priority };
                db.Tasks.Add(task);
                db.SaveChanges();
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            // using (CheckListContext db=new CheckListContext())
            //{
            //    Category category_1 = new Category { Name = "workout" };
            //    Category category_2 = new Category { Name = "cleaning" };
            //    Category category_3 = new Category { Name = "homework" };
            //    Category category_4 = new Category { Name = "job" };
            //    Category category_5 = new Category { Name = "shoping" };
            //    db.Categories.AddRange(new List<Category> { category_1, category_2, category_3, category_4, category_5 });
            //    db.SaveChanges();
            //    Task task_1=new Task { Name="do workout",isDone=false,category= db.Categories.Where(p => p.Name == "workout").First<Category>(),Deadline="10,11,2020" ,Priority="high"};
            //    Task task_2 = new Task { Name = "cleaning", isDone = true, category = db.Categories.Where(p => p.Name == "cleaning").First<Category>(), Deadline = "11,11,2020", Priority = "high" };
            //    Task task_3 = new Task { Name = "do homework", isDone = false, category = db.Categories.Where(p => p.Name == "homework").First<Category>(), Deadline = "12,11,2020", Priority = "high" };
            //    Task task_4 = new Task { Name = "get a job", isDone = false, category = db.Categories.Where(p => p.Name == "job").First<Category>(), Deadline = "10,02,2021", Priority = "high" };
            //    Task task_5 = new Task { Name = "go shoping", isDone = false, category = db.Categories.Where(p => p.Name == "shoping").First<Category>(), Deadline = "08,11,2020", Priority = "low" };
            //    db.Tasks.AddRange(new List<Task> { task_1, task_2, task_3, task_4, task_5 });
            // db.SaveChanges();



            // program.AddCategory();
            //program.AddTask();
          
            // }
        }

    }
}
