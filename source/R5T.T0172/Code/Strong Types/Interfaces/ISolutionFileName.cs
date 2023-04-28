using System;

using R5T.T0178;
using R5T.T0181;


namespace R5T.T0172
{
    /// <summary>
    /// Strongly-types a string as a Visual Studio solution file name.
    /// </summary>
    [StrongTypeMarker]
    public interface ISolutionFileName : IStrongTypeMarker,
        ITextFileName
    {
    }
}
