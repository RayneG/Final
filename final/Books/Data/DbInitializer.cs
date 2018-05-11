using Books.Models;
using System;
using System.Linq;

namespace Books.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any()){

                return;  
            }

            var students = new Book[]{

                new Book{Author="J.K Rowling",Title="Harry Pooter",Copies = 1},
                new Book{Author="George R.R. Martin",Title="Books",Copies = 0},
                new Book{Author="George R.R. Martin",Title="Not",Copies = 0},
                new Book{Author="George R.R. Martin",Title="Coming",Copies = 0},
                new Book{Author="Dr. Seuss",Title="Green Eggs and Ham",Copies = 123},
                new Book{Author="Rain Gopeng",Title="Please Give Me an A",Copies = 1000000},
                new Book{Author="J.R.R. Tolkien",Title="Hobbit in Da Hood",Copies = 2},
                new Book{Author="Stephen King",Title="Megh",Copies = 1}
            };

            foreach (Book s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
        }
    }
}