using System;

using R5T.T0131;


namespace D8S.Z0009.Z000.Raw
{
    /// <inheritdoc cref="Z000.IIdentityStrings"/>
    [ValuesMarker]
    public partial interface IIdentityStrings : IValuesMarker
    {
        /// <summary>
        /// <para><value>T:MyNamespace.MyClass</value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_001 => "T:MyNamespace.MyClass";



        /// <summary>
        /// <para><value></value></para>
        /// </summary>
        /// <remarks>
        /// Source: <inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/>.
        /// <para>Implementation: See D8S.Z0009.T001</para>
        /// </remarks>
        public string N_ => "";
    }
}
