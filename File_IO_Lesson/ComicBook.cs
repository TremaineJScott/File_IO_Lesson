using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Lesson
{
    internal class ComicBook
    {
        public string UpcCode { get; set; }
        public string Title { get; set; }
        public double PurchasePrice { get; set; }

        public ComicBook(string code, string title, double price)
        {
            UpcCode = code;
            Title = title;
            PurchasePrice = price;
        }
    }

}
