using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0172
{
    /// <summary>
    /// Strongly-types a string as the file name of a C# (.cs) code file.
    /// </summary>
    [StrongTypeMarker]
    public interface ICSharpFileName : IStrongTypeMarker,
        IFileName
    {
    }
}
