namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region answer_01
            // a) Both variables end up referring to the same object in memory,
            //  No copy is made  you simply now have two names pointing to one object.
            // b) no The assignment only copies the reference, not the object
            //  Since both variables point to the same object, changing it through one variable will show up when you access it through the other.
            //c)Copying a reference means two variables point to the same single object,
            //so any change affects both. Copying the object itself means a brand new,
            //independent object is created in memory, so changes to one no longer affect the other.
            #endregion
        }
    }
}
