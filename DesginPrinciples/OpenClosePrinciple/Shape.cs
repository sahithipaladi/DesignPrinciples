
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.Open_Close_Principle
{
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public double height { get; set; }
        public double width { get; set; }
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double Area()
        {
            return height * width;
        }
    }
    public class Circle : Shape
    {
        public double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return radius * radius * Math.PI;
        }
    }



}