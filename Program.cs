Console.WriteLine("Hello, World!");
#region 01
//int pages = 464;
//bool isAvailable = true;
//if (pages > 300 && isAvailable)
//{
//    Console.WriteLine("you can borrow this book");
//}
#endregion
#region 02
//    string title = "Refectoring";
//    switch (title)
//    {
//        case "clean code":
//            Console.WriteLine("Great choice!");
//            break;
//        case "Refectoring":
//            Console.WriteLine("Nice pick!");
//            break;

//        default:
//            Console.WriteLine("Never headd of it");
//            break;
//    }
#endregion
#region 03
//    #region 03
//    int Pages = 464;

//    string result = pages > 300 ? "Long Book" : "Short Book";
//    Console.WriteLine(result);
#endregion
#region 04
//    string[] books = { "clean code", "The pragmatic programmer", "Refactoring" };
//   for (int i = 0; i < 3; i++)
//    {
//       Console.WriteLine(books[i]);
//    }
#endregion
#region 05
//    int i = 0;
//    while (books.Length > 0) 
//    {
//        Console.WriteLine(books[i]);
//        i++;
//    }
#endregion
#region 06
//string books;
//bool isparsed;
//do
//{
//    Console.WriteLine("Checking book....");
//    isparsed =int.TryParse(Console.ReadLine(), out books);
//}
//while (books<3);
#endregion
#region 07
//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
//foreach (string book in books)
//{
//    Console.WriteLine($"{book}");
//}
#endregion
#region 08
//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

//    foreach(string book in books)
//    {
//      if (book == "Refactoring") ;
//      {
//        break;
//      }
//      Console.WriteLine(book);
//    }
#endregion
#region 09
//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

//foreach (string book in books)
//{
//    if (book == "The Pragmatic Programmer")
//    {
//        continue;
//    }

//    Console.WriteLine(book);
//}
#endregion