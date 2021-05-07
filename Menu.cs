using System;

namespace EFPart1
{
    public class Menu : IMenu
    {
        
        public void Question()
        {
            
            Console.WriteLine("1. Display Blogs\n2. Add new Blog\n3. Display Post\n4. Add new Post\n5. Exit");
 
        }
        public void Choice()
        {
           int option;
           var menu = new Menu();
           var repository = new Repository(); 
           
           option = Int32.Parse(Console.ReadLine());

           do
           {
                switch (option)
                {
                    case 1:repository.displayBlog();
                        break;
                    case 2: repository.createBlog();  
                        break;
                    case 3: repository.displayPost();
                        break;  
                    case 4: repository.insertPost();
                        break;        
                    
                }
                   
           } while (option != 5); 
        }
        //System.Console.Writeline("Your session has ended!!!");

    }
}