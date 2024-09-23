using System;

using R5T.T0131;


namespace D8S.Z0009.Z000.Raw
{
    /// <inheritdoc cref="Z000.IIdentityStrings"/>
    [ValuesMarker]
    public partial interface IIdentityStrings : IValuesMarker
    {
        #region XML Documentation Reference

        /// <summary>
        /// <para><value>T:MyNamespace.MyClass</value></para>
        /// unsafe class MyClass
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_001 => "T:MyNamespace.MyClass";

        /// <summary>
        /// <para><value>M:MyNamespace.MyClass.#ctor</value></para>
        /// MyClass()
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_002 => "M:MyNamespace.MyClass.#ctor";

        /// <summary>
        /// <para><value>M:MyNamespace.MyClass.#ctor(System.Int32)</value></para>
        /// MyClass(int i)
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_003 => "M:MyNamespace.MyClass.#ctor(System.Int32)";

        /// <summary>
        /// <para><value>F:MyNamespace.MyClass.Message</value></para>
        /// string? Message
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_004 => "F:MyNamespace.MyClass.Message";

        /// <summary>
        /// <para><value>F:MyNamespace.MyClass.PI</value></para>
        /// const double PI = 3.14
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_005 => "F:MyNamespace.MyClass.PI";

        /// <summary>
        /// <para><value>M:MyNamespace.MyClass.Func</value></para>
        /// int Func()
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_006 => "M:MyNamespace.MyClass.Func";

        /// <summary>
        /// <para><value>M:MyNamespace.MyClass.SomeMethod(System.String,System.Int32@,System.Void*)</value></para>
        /// int SomeMethod(string str, ref int num, void* ptr)
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_007 => "M:MyNamespace.MyClass.SomeMethod(System.String,System.Int32@,System.Void*)";

        /// <summary>
        /// <para><value>M:MyNamespace.MyClass.AnotherMethod(System.Int16[],System.Int32[0:,0:])</value></para>
        /// int AnotherMethod(short[] array1, int[,] array)
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_008 => "M:MyNamespace.MyClass.AnotherMethod(System.Int16[],System.Int32[0:,0:])";

        /// <summary>
        /// <para><value>M:MyNamespace.MyClass.op_Addition(MyNamespace.MyClass,MyNamespace.MyClass)</value></para>
        /// static MyClass operator +(MyClass first, MyClass second)
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_009 => "M:MyNamespace.MyClass.op_Addition(MyNamespace.MyClass,MyNamespace.MyClass)";

        /// <summary>
        /// <para><value>P:MyNamespace.MyClass.Prop</value></para>
        /// int Prop { get { return 1; } set { } }
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_010 => "P:MyNamespace.MyClass.Prop";

        /// <summary>
        /// <para><value>E:MyNamespace.MyClass.OnHappened</value></para>
        /// event Del? OnHappened;
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_011 => "E:MyNamespace.MyClass.OnHappened";

        /// <summary>
        /// <para><value>P:MyNamespace.MyClass.Item(System.String)</value></para>
        /// int this[string s]
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_012 => "P:MyNamespace.MyClass.Item(System.String)";

        /// <summary>
        /// <para><value>T:MyNamespace.MyClass.Nested</value></para>
        /// class Nested
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_013 => "T:MyNamespace.MyClass.Nested";

        /// <summary>
        /// <para><value>T:MyNamespace.MyClass.Del</value></para>
        /// delegate void Del(int i)
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_014 => "T:MyNamespace.MyClass.Del";

        /// <summary>
        /// <para><value>M:MyNamespace.MyClass.op_Explicit(MyNamespace.MyClass)~System.Int32</value></para>
        /// static explicit operator int(MyClass myParameter)
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_015 => "M:MyNamespace.MyClass.op_Explicit(MyNamespace.MyClass)~System.Int32";

        #endregion

        #region Documentation Comments

        /// <summary>
        /// <para><value>T:Color</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_101 => "T:Color";

        /// <summary>
        /// <para><value>T:Acme.IProcess</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_102 => "T:Acme.IProcess";

        /// <summary>
        /// <para><value>T:Acme.ValueType</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_103 => "T:Acme.ValueType";

        /// <summary>
        /// <para><value>T:Acme.Widget</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_104 => "T:Acme.Widget";

        /// <summary>
        /// <para><value>T:Acme.Widget.NestedClass</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_105 => "T:Acme.Widget.NestedClass";

        /// <summary>
        /// <para><value>T:Acme.Widget.IMenuItem</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_106 => "T:Acme.Widget.IMenuItem";

        /// <summary>
        /// <para><value>T:Acme.Widget.Del</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_107 => "T:Acme.Widget.Del";

        /// <summary>
        /// <para><value>T:Acme.Widget.Direction</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_108 => "T:Acme.Widget.Direction";

        /// <summary>
        /// <para><value>T:Acme.MyList`1</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_109 => "T:Acme.MyList`1";

        /// <summary>
        /// <para><value>T:Acme.MyList`1.Helper`2</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_110 => "T:Acme.MyList`1.Helper`2";

        /// <summary>
        /// <para><value>F:Acme.ValueType.total</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_111 => "F:Acme.ValueType.total";

        /// <summary>
        /// <para><value>F:Acme.Widget.NestedClass.value</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_112 => "F:Acme.Widget.NestedClass.value";

        /// <summary>
        /// <para><value>F:Acme.Widget.message</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_113 => "F:Acme.Widget.message";

        /// <summary>
        /// <para><value>F:Acme.Widget.defaultColor</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_114 => "F:Acme.Widget.defaultColor";

        /// <summary>
        /// <para><value>F:Acme.Widget.PI</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_115 => "F:Acme.Widget.PI";

        /// <summary>
        /// <para><value>F:Acme.Widget.monthlyAverage</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_116 => "F:Acme.Widget.monthlyAverage";

        /// <summary>
        /// <para><value>F:Acme.Widget.array1</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_117 => "F:Acme.Widget.array1";

        /// <summary>
        /// <para><value>F:Acme.Widget.array2</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_118 => "F:Acme.Widget.array2";

        /// <summary>
        /// <para><value>F:Acme.Widget.pCount</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_119 => "F:Acme.Widget.pCount";

        /// <summary>
        /// <para><value>F:Acme.Widget.ppValues</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_120 => "F:Acme.Widget.ppValues";

        /// <summary>
        /// <para><value>M:Acme.Widget.#cctor</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_121 => "M:Acme.Widget.#cctor";

        /// <summary>
        /// <para><value>M:Acme.Widget.#ctor</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_122 => "M:Acme.Widget.#ctor";

        /// <summary>
        /// <para><value>M:Acme.Widget.#ctor(System.String)</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_123 => "M:Acme.Widget.#ctor(System.String)";

        /// <summary>
        /// <para><value>M:Acme.Widget.Finalize</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_124 => "M:Acme.Widget.Finalize";

        /// <summary>
        /// <para><value>M:Acme.ValueType.M(System.Int32)</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_125 => "M:Acme.ValueType.M(System.Int32)";

        /// <summary>
        /// <para><value>M:Acme.Widget.NestedClass.M(System.Int32)</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_126 => "M:Acme.Widget.NestedClass.M(System.Int32)";

        /// <summary>
        /// <para><value>M:Acme.Widget.M0</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_127 => "M:Acme.Widget.M0";

        /// <summary>
        /// <para><value>M:Acme.Widget.M1(System.Char,System.Single@,Acme.ValueType@,System.Int32@)</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_128 => "M:Acme.Widget.M1(System.Char,System.Single@,Acme.ValueType@,System.Int32@)";

        /// <summary>
        /// <para><value>M:Acme.Widget.M2(System.Int16[],System.Int32[0:,0:],System.Int64[][])</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_129 => "M:Acme.Widget.M2(System.Int16[],System.Int32[0:,0:],System.Int64[][])";

        /// <summary>
        /// <para><value>M:Acme.Widget.M3(System.Int64[][],Acme.Widget[0:,0:,0:][])</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_130 => "M:Acme.Widget.M3(System.Int64[][],Acme.Widget[0:,0:,0:][])";

        /// <summary>
        /// <para><value>M:Acme.Widget.M4(System.Char*,Color**)</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_131 => "M:Acme.Widget.M4(System.Char*,Color**)";

        /// <summary>
        /// <para><value>M:Acme.Widget.M5(System.Void*,System.Double*[0:,0:][])</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_132 => "M:Acme.Widget.M5(System.Void*,System.Double*[0:,0:][])";

        /// <summary>
        /// <para><value>M:Acme.Widget.M6(System.Int32,System.Object[])</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_133 => "M:Acme.Widget.M6(System.Int32,System.Object[])";

        /// <summary>
        /// <para><value>M:Acme.MyList`1.Test(`0)</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_134 => "M:Acme.MyList`1.Test(`0)";

        /// <summary>
        /// <para><value>M:Acme.UseList.Process(Acme.MyList{System.Int32})</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_135 => "M:Acme.UseList.Process(Acme.MyList{System.Int32})";

        /// <summary>
        /// <para><value>M:Acme.UseList.GetValues``1(``0)</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_136 => "M:Acme.UseList.GetValues``1(``0)";

        /// <summary>
        /// <para><value>P:Acme.Widget.Width</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_137 => "P:Acme.Widget.Width";

        /// <summary>
        /// <para><value>P:Acme.Widget.Item(System.Int32)</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_138 => "P:Acme.Widget.Item(System.Int32)";

        /// <summary>
        /// <para><value>P:Acme.Widget.Item(System.String,System.Int32)</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_139 => "P:Acme.Widget.Item(System.String,System.Int32)";

        /// <summary>
        /// <para><value>E:Acme.Widget.AnEvent</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_140 => "E:Acme.Widget.AnEvent";

        /// <summary>
        /// <para><value>M:Acme.Widget.op_UnaryPlus(Acme.Widget)</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_141 => "M:Acme.Widget.op_UnaryPlus(Acme.Widget)";

        /// <summary>
        /// <para><value>M:Acme.Widget.op_Addition(Acme.Widget,Acme.Widget)</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_142 => "M:Acme.Widget.op_Addition(Acme.Widget,Acme.Widget)";

        /// <summary>
        /// <para><value>M:Acme.Widget.op_Explicit(Acme.Widget)~System.Int32</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_143 => "M:Acme.Widget.op_Explicit(Acme.Widget)~System.Int32";

        /// <summary>
        /// <para><value>M:Acme.Widget.op_Implicit(Acme.Widget)~System.Int64</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T002</para>
        /// </remarks>
        public string N_144 => "M:Acme.Widget.op_Implicit(Acme.Widget)~System.Int64";

        #endregion
    }
}
