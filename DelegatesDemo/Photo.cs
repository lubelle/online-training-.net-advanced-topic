﻿using System;

namespace DelegatesDemo
{
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
}
