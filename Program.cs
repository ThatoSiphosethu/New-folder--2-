using System;
using System.Linq;
using EFPart1.DataModels;
using Microsoft.EntityFrameworkCore;

namespace EFPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Question();
        }
    }
}
