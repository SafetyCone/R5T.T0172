using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0172
{
    /// <summary>
    /// Strongly-types the path of a directory containing a Visual Studio solution file.
    /// </summary>
    [StrongTypeMarker]
    public interface ISolutionDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}
