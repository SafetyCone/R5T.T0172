using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0172
{
    /// <summary>
    /// Strongly-types a string as the name of an assebly file.
    /// </summary>
    [StrongTypeMarker]
    public interface IAssemblyFileName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}