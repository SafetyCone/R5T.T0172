using System;

using R5T.T0150;
using R5T.T0175;


namespace R5T.T0172
{
    /// <summary>
    /// Represents the file path an a .NET (dotnet) assembly file (.dll file, but note that not all DLLs are .NET DLLs).
    /// </summary>
    [StrongTypeMarker]
    public interface IAssemblyFilePath : IFilePath, IStrongTypeMarker
    {
    }
}
