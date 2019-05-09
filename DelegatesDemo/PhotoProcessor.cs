namespace DelegatesDemo
{
    public delegate void PhotoFilterHandler(Photo photo);

    public class PhotoProcessor
    {
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
