using System;

using R5T.NetStandard.IO.Paths;
using R5T.NetStandard.IO.Paths.Extensions;


namespace R5T.Code.VisualStudio
{
    public static class Constants
    {
        public static readonly DirectoryName BinDirectoryName = "bin".AsDirectoryName();
        public static readonly DirectoryName ObjDirectoryName = "obj".AsDirectoryName();

        public static readonly FileName DirectoryBuildPropsFileName = "Directory.Build.props".AsFileName();
    }
}
