using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFPart1
{
    public interface IBlog
    {
        void displayBlog();
        void createBlog();
        void displayPost();
        void insertPost();
        
    }
}