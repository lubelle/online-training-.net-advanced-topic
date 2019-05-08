using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class PhotoProcessor
    {
        public void Process(string path)
        {
            var photo = Photo.Load(path);

            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
    }

    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("Persist the photo to database ..");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            photoProcessor.Process("C:\\abc.jpg");


            Console.ReadLine();
        }
    }

    class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness...");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast...");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Apply resize...");
        }
    }
}
