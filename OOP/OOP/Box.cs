using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Box
    {
        //member variables
        //private int length;
        //private int height;
        //properties
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Volume
        {
            get
            {
                return Length * Width * Height;
            }
        }
        public int FrontSurface 
        {
            get
            {
                return Height * Length;
            }
        }
        public Box(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        //public int Height
        //{
        //    get
        //    {
        //        return height;
        //    }
        //    set
        //    {
        //        //value = whatever value is set for height
        //        height = value;
        //    }
        //}

        // How getting and setting values would be if not for { get; set; }
        //public void SetLength(int length)
        //{
        //    this.length = length;
        //}
        //public int GetLength()
        //{
        //    return this.length;
        //}

        public void DisplayInfo()
        {
            Console.WriteLine($"Length: {Length}\n" +
                $"Width: {Width}\n" +
                $"height: {Height}\n" +
                $"volume: {Length * Width * Height}");
        }
    }
}
