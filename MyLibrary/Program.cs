using MyLibrary.Entities;
using MyLibrary.Repositories;

namespace MyLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppContext())
            {
                var book1 = new Book { Title = "Война и мир", Author = "Лев Толстой", Genre = "Роман", DatePublished = new DateTime(1863-02-11)};
                var book2 = new Book { Title = "Отцы и дети", Author = "Тургенев", Genre = "Роман", DatePublished = new DateTime(1862-01-01)};
                var book3 = new Book { Title = "Метро 2033", Author = "Глуховский", Genre = "Фантастика", DatePublished = new DateTime(2010-03-16) };

                db.Books.AddRange(book1, book2, book3);

                var user1 = new User { Name = "Иваныч", Email = "Ivanov@gmail" };
                var user2 = new User { Name = "Ильич", Email = "Prdovich@mail" };
                var user3 = new User { Name = "Степаныч", Email = "Stepan@gmail" };

                book1.User = user1;
                book2.User = user2;
                book3.User = user3;

                db.Users.AddRange(user1, user2, user3);

                db.SaveChanges(); 
            }
        }
    }
}