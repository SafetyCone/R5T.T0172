using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0172
{
    /// <inheritdoc cref="IAssemblyFilePath"/>
    [StrongTypeMarker]
    public class AssemblyFilePath : TypedString, IStrongTypeMarker, IAssemblyFilePath
    {
        public AssemblyFilePath(string value)
            : base(value)
        {
        }
    }
}
