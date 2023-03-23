using System;

using R5T.T0150;
using R5T.T0175;


namespace R5T.T0172
{
    /// <summary>
    /// Represents the file path a .NET project file.
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectFilePath : IStrongTypeMarker, IFilePath
    {
    }
}
