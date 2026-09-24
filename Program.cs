using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

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
            #region answer_02
            //a)
//A new object is created,
//but any reference type members inside it still point to the same underlying objects as the original,
//rather than being duplicated.

//b)
//A new object is created
//and every reference type member inside it is also duplicated into new,
//independent objects, so the copy is fully separate from the original.

//c) 
//They remain shared
//The original and the copy both point to the same inner object,
//so a change made through either one is reflected in both.

//d) 
//They are duplicated as well
// Each reference type member gets its own independent copy,
// so there is no shared state between the original and the copy.

//e)
//If an object contains a list or collection and you want to create a draft or test version to modify freely,
//a shallow copy would let changes to that draft accidentally affect the original, since they'd share the same underlying list. A deep copy avoids this by giving the draft its own independent data.
            #endregion

        }
    }
}
