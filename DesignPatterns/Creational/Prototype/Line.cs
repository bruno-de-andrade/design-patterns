using System;

namespace DesignPatterns.Creational.Prototype
{
    [Serializable]
    class Line
    {
        public Point Start { get; set; }

        public Point End { get; set; }

        public Line()
        {
            Start = new Point();
            End = new Point();
        }
    }
}
