using System;

using R5T.T0131;
using R5T.T0143;


namespace D8S.Z0009.Z000
{
    /// <summary>
    /// Stringly-typed example identity strings.
    /// </summary>
    /// <remarks>
    /// Sources:
    /// <list type="bullet">
    /// <item><inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_DocumentationCommentsLink" path="descendant::link"/></item>
    /// <item><inheritdoc cref="R5T.Y0006.Documentation.For_IDStrings.MSDocs_APIDocumentationLink" path="descendant::link"/></item>
    /// </list>
    /// </remarks>
    [ValuesMarker]
    public partial interface IIdentityStrings : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IIdentityStrings _Raw => Raw.IdentityStrings.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
