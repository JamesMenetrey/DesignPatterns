/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

namespace DesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// Define a door.
    /// </summary>
    public class Door
    {
        public Door(string name)
        {
            Name = name;
            IsOpened = false;
        }

        public string Name { get; set; }
        public bool IsOpened { get; set; }
    }
}
