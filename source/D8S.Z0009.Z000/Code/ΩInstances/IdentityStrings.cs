using System;


namespace D8S.Z0009.Z000
{
    public class IdentityStrings : IIdentityStrings
    {
        #region Infrastructure

        public static IIdentityStrings Instance { get; } = new IdentityStrings();


        private IdentityStrings()
        {
        }

        #endregion
    }
}


namespace D8S.Z0009.Z000.Raw
{
    public class IdentityStrings : IIdentityStrings
    {
        #region Infrastructure

        public static IIdentityStrings Instance { get; } = new IdentityStrings();


        private IdentityStrings()
        {
        }

        #endregion
    }
}