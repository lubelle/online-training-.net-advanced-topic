using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filter = new PhotoFilters();

            Action<Photo> filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            photoProcessor.Process("C:\\abc.jpg", filterHandler);

            Console.ReadLine();
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply Remove red eye filter ...");
        }
    }
}
