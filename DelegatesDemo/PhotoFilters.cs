﻿using System;

namespace DelegatesDemo
{
    public class PhotoFilters
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
