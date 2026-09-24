using System.Drawing;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.AccessControl;
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
            #region answer_03
            //a)
            //A static field belongs to the class itself and is shared across all objects of that class,
            //meaning there's only one copy of it in memory. An instance field belongs to each individual object,
            //so every object has its own separate copy.
            //b) 
            //A static method belongs to the class rather than to any object,
            //and is called through the class name without needing to create an object first
            //It cannot directly access instance members,
            //because it has no specific object to operate on;
            //it would need an object passed to it as a parameter to reach those members.
            //c)
            //A static constructor is a special constructor used to initialize static members of a class. It runs automatically and only once, the first time the class is used, before any object is created or any static member is accessed.

            //d)
            //A static class is a class that can only contain static members and is typically used to group related utility functionality
            //You cannot create an object from it, since it has no accessible constructor and isn't meant to be instantiated.
            #endregion
            #region answer_04
            //a) 
            //A static method that lets you add new functionality to an existing type without modifying its source code
            //creating a subclass, or recompiling it
            //It appears to be called as if it were a regular instance method on that type.
            //b) 
            //The this keyword, placed before the first parameter's type, which specifies the type being extended.
            //c) 
            //Inside a static class, and the extension method itself must also be static.
            //d) 
            //No.An extension method has no special access to the class
            //it only sees what's publicly accessible, exactly like any outside code would.

            #endregion


        }
    }
}
