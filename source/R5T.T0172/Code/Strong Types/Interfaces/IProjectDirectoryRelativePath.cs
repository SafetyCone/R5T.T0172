using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0172
{
    /// <summary>
    /// A path relative to a project directory.
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectDirectoryRelativePath : IStrongTypeMarker,
        IRelativePath
    {
    }
}
