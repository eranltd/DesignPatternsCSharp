using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>

    /// The 'ConcretePrototype' class

    /// </summary>
    class Color : ColorPrototype
    {
        private static int _id = 0;
        private int _red;
        private int _green;
        private int _blue;

        // Constructor

        public Color(int red, int green, int blue)
        {
            this._id++;
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        // Create a shallow copy

        //public override ColorPrototype Clone()
        //{
        //    Console.WriteLine(
        //      "Cloning color RGB: {0,3},{1,3},{2,3}",
        //      _red, _green, _blue);

        //    return this.MemberwiseClone() as ColorPrototype; //Creates a shallow copy of the current Object.
        //}

        //can be implement a deep copy by returning a new instance of color with same fields.

        public override ColorPrototype Clone()
        {
            Console.WriteLine(
              "Cloning color RGB: {0,3},{1,3},{2,3}",
              _red, _green, _blue);

            return new Color
            {
                _red = this._red,
                _blue = this._blue,
                _green = this._green
            }
            as ColorPrototype; //Creates a shallow copy of the current Object.
        }

    }
}
