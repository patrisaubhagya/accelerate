using Accelerate.DataAccessLayer;
using System;

namespace Accelerate.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AccelerateRepository repository = new AccelerateRepository();

            //var verticals = repository.GetDashboard();
            //foreach (var vertical in verticals)
            //{
            //    Console.WriteLine("{0,-20} {1,-20} {2,-30}", vertical.Vertical, vertical.Horizontal, vertical.SearchWords);
            //}

            //var verticalRows = repository.GetDashboard();
            //foreach (var verticalrow in verticalRows)
            //{
            //    Console.WriteLine(verticalrow.Vertical);
            //}

            //var horizontalRows = repository.filterHorizontal("Manufacturing");
            //foreach(var horizontalRow in horizontalRows)
            //{
            //    Console.WriteLine("{0,-20} {1,-20} {2,-30}",horizontalRow.Vertical,horizontalRow.Horizontal,horizontalRow.SearchWords);
            //}

            //var searchWords = repository.filterSearchWords("Manufacturing", "Software Product");
            //foreach(var searchWord in searchWords)
            //{
            //    Console.WriteLine("{0,-20} {1,-20} {2,-30}", searchWord.Vertical, searchWord.Horizontal, searchWord.SearchWords);
            //}

            //var searchWordsLike = repository.filterSearchWordsLike("ome");
            //foreach (var searchWord in searchWordsLike)
            //{
            //    Console.WriteLine("{0,-20} {1,-20} {2,-30}", searchWord.Vertical, searchWord.Horizontal, searchWord.SearchWords);
            //}


        }
    }
}
