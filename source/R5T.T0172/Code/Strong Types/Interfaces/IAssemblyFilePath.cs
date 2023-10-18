using System;

using R5T.T0178;
using R5T.T0181;

using R5T.T0172.Extensions;


namespace R5T.T0172
{
    /// <summary>
    /// Represents the file path an a .NET (dotnet) assembly file (.dll file, but note that not all DLLs are .NET DLLs).
    /// </summary>
    [StrongTypeMarker]
    public interface IAssemblyFilePath : IStrongTypeMarker,
        IDllFilePath
    {
        #region Static

        public static IAssemblyFilePath ToAssemblyFilePath(string value)
        {
            var output = value.ToAssemblyFilePath();
            return output;
        }

        #endregion
    }
}
