using System;

using R5T.T0178;
using R5T.T0181;


namespace R5T.T0172
{
    /// <summary>
    /// Represents the file path a code file (any language).
    /// </summary>
    [StrongTypeMarker]
    public interface ICodeFilePath : IStrongTypeMarker,
        ITextFilePath
    {
    }
}
