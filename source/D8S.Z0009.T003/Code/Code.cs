using System;


/// Source: <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments#d51-c-source-code"/>

namespace Graphics
{
    /// <summary>
    /// Class <c>Point</c> models a point in a two-dimensional plane.
    /// </summary>
    public class Point
    {
        /// <value>
        /// Property <c>X</c> represents the point's x-coordinate.
        /// </value>
        public int X { get; set; }

        /// <value>
        /// Property <c>Y</c> represents the point's y-coordinate.
        /// </value>
        public int Y { get; set; }

        /// <summary>
        /// This constructor initializes the new Point to (0,0).
        /// </summary>
        public Point() : this(0, 0) { }

        /// <summary>
        /// This constructor initializes the new Point to
        /// (<paramref name="xPosition"/>,<paramref name="yPosition"/>).
        /// </summary>
        /// <param name="xPosition">The new Point's x-coordinate.</param>
        /// <param name="yPosition">The new Point's y-coordinate.</param>
        public Point(int xPosition, int yPosition)
        {
            X = xPosition;
            Y = yPosition;
        }

        /// <summary>
        /// This method changes the point's location to
        /// the given coordinates. <see cref="Translate"/>
        /// </summary>
        /// <param name="xPosition">The new x-coordinate.</param>
        /// <param name="yPosition">The new y-coordinate.</param>
        public void Move(int xPosition, int yPosition)
        {
            X = xPosition;
            Y = yPosition;
        }

        /// <summary>
        /// This method changes the point's location by
        /// the given x- and y-offsets.
        /// <example>For example:
        /// <code>
        /// Point p = new Point(3, 5);
        /// p.Translate(-1, 3);
        /// </code>
        /// results in <c>p</c>'s having the value (2, 8).
        /// <see cref="Move"/>
        /// </example>
        /// </summary>
        /// <param name="dx">The relative x-offset.</param>
        /// <param name="dy">The relative y-offset.</param>
        public void Translate(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        /// <summary>
        /// This method determines whether two Points have the same location.
        /// </summary>
        /// <param name="o">
        /// The object to be compared to the current object.
        /// </param>
        /// <returns>
        /// True if the Points have the same location and they have
        /// the exact same type; otherwise, false.
        /// </returns>
        /// <seealso cref="operator=="/>
        /// <seealso cref="operator!="/>
        public override bool Equals(object o)
        {
            if (o == null)
            {
                return false;
            }
            if ((object)this == o)
            {
                return true;
            }
            if (GetType() == o.GetType())
            {
                Point p = (Point)o;
                return (X == p.X) && (Y == p.Y);
            }
            return false;
        }

        /// <summary>
        /// This method returns a Point's hashcode.
        /// </summary>
        /// <returns>
        /// The int hashcode.
        /// </returns>
        public override int GetHashCode()
        {
            return X + (Y >> 4);    // a crude version
        }

        /// <summary>Report a point's location as a string.</summary>
        /// <returns>
        /// A string representing a point's location, in the form (x,y),
        /// without any leading, training, or embedded whitespace.
        /// </returns>
        public override string ToString() => $"({X},{Y})";

        /// <summary>
        /// This operator determines whether two Points have the same location.
        /// </summary>
        /// <param name="p1">The first Point to be compared.</param>
        /// <param name="p2">The second Point to be compared.</param>
        /// <returns>
        /// True if the Points have the same location and they have
        /// the exact same type; otherwise, false.
        /// </returns>
        /// <seealso cref="Equals"/>
        /// <seealso cref="operator!="/>
        public static bool operator ==(Point p1, Point p2)
        {
#pragma warning disable IDE0041 // Use 'is null' check
            if ((object)p1 == null || (object)p2 == null)
            {
                return false;
            }
#pragma warning restore IDE0041 // Use 'is null' check

            if (p1.GetType() == p2.GetType())
            {
                return (p1.X == p2.X) && (p1.Y == p2.Y);
            }
            return false;
        }

        /// <summary>
        /// This operator determines whether two Points have the same location.
        /// </summary>
        /// <param name="p1">The first Point to be compared.</param>
        /// <param name="p2">The second Point to be compared.</param>
        /// <returns>
        /// True if the Points do not have the same location and the
        /// exact same type; otherwise, false.
        /// </returns>
        /// <seealso cref="Equals"/>
        /// <seealso cref="operator=="/>
        public static bool operator !=(Point p1, Point p2) => !(p1 == p2);
    }
}
