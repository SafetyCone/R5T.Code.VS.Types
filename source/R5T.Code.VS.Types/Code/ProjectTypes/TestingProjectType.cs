using System;


namespace R5T.Code.VisualStudio
{
    public class TestingProjectType : ProjectType
    {
        public static TestingProjectType Instance { get; } = new TestingProjectType();
    }
}
