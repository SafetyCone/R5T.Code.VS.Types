using System;


namespace R5T.Code.VisualStudio
{
    public static class ProjectTypes
    {
        public static ConsoleProjectType Console => ConsoleProjectType.Instance;
        public static LibraryProjectType Library => LibraryProjectType.Instance;
        public static TestingProjectType Testing => TestingProjectType.Instance;
        public static UnspecifiedProjectType Unspecified => UnspecifiedProjectType.Instance;
    }
}
