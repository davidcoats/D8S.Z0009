using System;

#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable IDE0051 // Remove unused private members

/// <summary>
/// Example enumeration for example identity strings from MS documentation.
/// (<inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>)
/// </summary>
/// <remarks>
/// ID string generated is "T:Color".
/// </remarks>
enum Color { Red, Blue, Green }

namespace Acme
{
    /// <summary>
    /// Example interface for example identity strings from MS documentation.
    /// (<inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>)
    /// </summary>
    /// <remarks>
    /// ID string generated is "T:Acme.IProcess".
    /// </remarks>
    interface IProcess { }

    /// <summary>
    /// Example struct for example identity strings from MS documentation.
    /// (<inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>)
    /// </summary>
    /// <remarks>
    /// ID string generated is "T:Acme.ValueType".
    /// </remarks>
    struct ValueType
    {
        private int total;

        public void M(int i) { throw new NotImplementedException(); }
    }

    /// <summary>
    /// Example class for example identity strings from MS documentation.
    /// (<inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>)
    /// </summary>
    /// <remarks>
    /// ID string generated is "T:Acme.Widget".
    /// </remarks>
    class Widget : IProcess
    {
        private string message;
        private static Color defaultColor;
        private const double PI = 3.14159;
        protected readonly double monthlyAverage;


        private long[] array1;
        private Widget[,] array2;
        private unsafe int* pCount;
        private unsafe float** ppValues;

        static Widget() { throw new NotImplementedException(); }
        public Widget() { throw new NotImplementedException(); }
        public Widget(string s) { throw new NotImplementedException(); }

        /// <summary>
        /// Example nested class for example identity strings from MS documentation.
        /// (<inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>)
        /// </summary>
        /// <remarks>
        /// ID string generated is "T:Acme.Widget.NestedClass".
        /// </remarks>
        public class NestedClass
        {
            private int value;

            public void M(int i) { throw new NotImplementedException(); }
        }

        public static void M0() { throw new NotImplementedException(); }
        public void M1(char c, out float f, ref ValueType v, in int i) { throw new NotImplementedException(); }
        public void M2(short[] x1, int[,] x2, long[][] x3) { throw new NotImplementedException(); }
        public void M3(long[][] x3, Widget[][,,] x4) { throw new NotImplementedException(); }
        public unsafe void M4(char* pc, Color** pf) { throw new NotImplementedException(); }
        public unsafe void M5(void* pv, double*[][,] pd) { throw new NotImplementedException(); }
        public void M6(int i, params object[] args) { throw new NotImplementedException(); }

        ~Widget() { throw new NotImplementedException(); }

        public int Width { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public int this[int i] { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public int this[string s, int i] { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public event Del AnEvent;

        public static Widget operator +(Widget x) { throw new NotImplementedException(); }

        public static Widget operator +(Widget x1, Widget x2) { throw new NotImplementedException(); }

        public static explicit operator int(Widget x) { throw new NotImplementedException(); }
        public static implicit operator long(Widget x) { throw new NotImplementedException(); }

        /// <summary>
        /// Example nested interface for example identity strings from MS documentation.
        /// (<inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>)
        /// </summary>
        /// <remarks>
        /// ID string generated is "T:Acme.Widget.IMenuItem".
        /// </remarks>
        public interface IMenuItem { }

        /// <summary>
        /// Example delegate for example identity strings from MS documentation.
        /// (<inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>)
        /// </summary>
        /// <remarks>
        /// ID string generated is "T:Acme.Widget.Del".
        /// </remarks>
        public delegate void Del(int i);

        /// <summary>
        /// Example enumeration for example identity strings from MS documentation.
        /// (<inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>)
        /// </summary>
        /// <remarks>
        /// ID string generated is "T:Acme.Widget.Direction".
        /// </remarks>
        public enum Direction { North, South, East, West }
    }

    /// <summary>
    /// Example class for example identity strings from MS documentation.
    /// (<inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>)
    /// </summary>
    /// <remarks>
    /// ID string generated is "T:Acme.MyList`1".
    /// </remarks>
    class MyList<T>
    {
        public void Test(T t) { throw new NotImplementedException(); }

        /// <summary>
        /// Example class for example identity strings from MS documentation.
        /// (<inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>)
        /// </summary>
        /// <remarks>
        /// ID string generated is "T:Acme.MyList`1.Helper`2".
        /// </remarks>
        class Helper<U, V> { }
    }

    class UseList
    {
        public void Process(MyList<int> list) { throw new NotImplementedException(); }
        public MyList<T> GetValues<T>(T value) { throw new NotImplementedException(); }
    }
}

#pragma warning restore IDE0044 // Add readonly modifier
#pragma warning restore IDE0051 // Remove unused private members