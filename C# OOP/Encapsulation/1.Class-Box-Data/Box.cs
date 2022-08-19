using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExerciseClassBoxData
{
    public class Box
    {
        public string propertyName = "";
        public double num = 0;
        public double length;
        public double width;
        public double height;
        public double result = 0;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return length; }
            private set 
            {
                propertyName = "Length";
                num = value;
                if (num <= 0)
                {
                    throw new Exception("Length cannot be zero or negative.");
                }
                length = value; 
            }
        }

        public double Width
        {
            get { return width; }
            private set 
            {
                num = value;

                if (num <= 0)
                {
                    throw new Exception("Width cannot be zero or negative.");
                }

                width = value; 
            }
        }

        public double Height
        { 
            get { return height; }
            private set 
            {
                num = value;

                if (num <= 0)
                {
                    throw new Exception("Height cannot be zero or negative.");
                }
                height = value; 
            }
        }

        public double SurfaceArea()
        {
            result = 2 * length * width + 2 * length * height + 2 * width * height;
            return result;
        }

        public double LateralSurfaceArea()
        {
            result = 2 * length * height + 2 * width * height;
            return result;
        }

        public double Volume()
        {
            result = length * width * height;
            return result;
        }
    }
}
