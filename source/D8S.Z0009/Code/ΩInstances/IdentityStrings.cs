using System;


namespace D8S.Z0009
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
