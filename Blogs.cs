   using System.Collections.Generic;

   namespace EFPart1.DataModels
   {
       public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        
        public List<Post> Posts { get; set; }
    }
   }
    
