/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;

namespace CatsOfTheWorld
{
    /// <summary>
    /// Cat Model
    /// </summary>
    class Cat
    {
        private String mName;
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">Name of the cat</param>
        public Cat(String name)
        {
            // ToDo  4. If name is blank or null, throw an exception and don't create the new Cat object
            mName = name;
        }
        public String name
        {
            get { return name; }
            set { mName = value; }
        }
    }
}
