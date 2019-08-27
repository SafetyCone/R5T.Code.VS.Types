using System;


namespace R5T.Code.VisualStudio
{
    public class UnspecifiedProjectType : ProjectType
    {
        public static UnspecifiedProjectType Instance { get; } = new UnspecifiedProjectType();
    }
}
