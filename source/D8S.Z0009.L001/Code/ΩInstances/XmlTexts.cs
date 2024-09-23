using System;


namespace D8S.Z0009.L001
{
    public class XmlTexts : IXmlTexts
    {
        #region Infrastructure

        public static IXmlTexts Instance { get; } = new XmlTexts();


        private XmlTexts()
        {
        }

        #endregion
    }
}
