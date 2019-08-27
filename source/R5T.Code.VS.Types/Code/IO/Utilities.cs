using System;

using R5T.NetStandard.IO.Paths;
using R5T.NetStandard.IO.Paths.Extensions;

using PathUtilities = R5T.NetStandard.IO.Paths.Utilities;
using PathUtilitiesExtra = R5T.NetStandard.IO.Paths.UtilitiesExtra;


namespace R5T.Code.VisualStudio.IO
{
    public static class Utilities
    {
        public static FileNameWithoutExtension GetProjectFileNameWithoutExtension(ProjectName projectName)
        {
            var projectFileNameWithoutExtension = projectName.Value.AsFileNameWithoutExtension();
            return projectFileNameWithoutExtension;
        }

        public static ProjectFileName GetCSharpProjectFileName(FileNameWithoutExtension projectfileNameWithoutExtension)
        {
            var projectFileName = PathUtilities.GetFileName(projectfileNameWithoutExtension, CSharpProjectFileExtension.Instance).AsProjectFileName();
            return projectFileName;
        }

        public static ProjectFilePath GetProjectFilePath(ProjectDirectoryPath projectDirectoryPath, ProjectFileName projectFileName)
        {
            var projectFilePath = PathUtilitiesExtra.GetFilePath(projectDirectoryPath, projectFileName).AsProjectFilePath();
            return projectFilePath;
        }

        public static ProjectFileName GetProjectFileName(ProjectFilePath projectFilePath)
        {
            var projectFileName = PathUtilities.GetFileName(projectFilePath).AsProjectFileName();
            return projectFileName;
        }

        /// <summary>
        /// The directory containing the project-file is the project-directory.
        /// </summary>
        public static ProjectDirectoryPath GetProjectDirectoryPath(ProjectFilePath projectFilePath)
        {
            var projectDirectoryPath = PathUtilities.GetDirectoryPath(projectFilePath).AsProjectDirectoryPath();
            return projectDirectoryPath;
        }

        public static SolutionFileName GetSolutionFileName(FileNameWithoutExtension solutionFileNameWithoutExtension)
        {
            var solutionFileName = PathUtilities.GetFileName(solutionFileNameWithoutExtension, FileExtensions.Sln).AsSolutionFileName();
            return solutionFileName;
        }

        public static SolutionFilePath GetSolutionFilePath(SolutionDirectoryPath solutionDirectoryPath, SolutionFileName solutionFileName)
        {
            var solutionFilePath = PathUtilitiesExtra.GetFilePath(solutionDirectoryPath, solutionFileName).AsSolutionFilePath();
            return solutionFilePath;
        }

        /// <summary>
        /// The directory containing the project-directory is the solution-directory.
        /// </summary>
        public static SolutionDirectoryPath GetSolutionDirectoryPath(ProjectDirectoryPath projectDirectoryPath)
        {
            var solutionDirectoryPath = PathUtilities.GetParentDirectoryPath(projectDirectoryPath).AsSolutionDirectoryPath();
            return solutionDirectoryPath;
        }

        /// <summary>
        /// The directory containing the solution-file is the solution-directory.
        /// </summary>
        public static SolutionDirectoryPath GetSolutionDirectoryPath(SolutionFilePath solutionFilePath)
        {
            var solutionDirectoryPath = PathUtilities.GetDirectoryPath(solutionFilePath).AsSolutionDirectoryPath();
            return solutionDirectoryPath;
        }

        public static FilePath GetDirectoryBuildPropsFilePath(ProjectDirectoryPath projectDirectoryPath)
        {
            var directoryBuildPropsFilePath = PathUtilities.Combine(projectDirectoryPath.Value, Constants.DirectoryBuildPropsFileName.Value).AsFilePath();
            return directoryBuildPropsFilePath;
        }
    }
}
