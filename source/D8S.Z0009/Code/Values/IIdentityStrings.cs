using System;

using R5T.T0131;
using R5T.T0143;


namespace D8S.Z0009
{
    [ValuesMarker]
    public partial interface IIdentityStrings : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z000.IIdentityStrings _StringlyTyped => Z000.IdentityStrings.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
