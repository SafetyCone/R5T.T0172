using System;

using R5T.T0178;
using R5T.T0179;

using R5T.T0172.Extensions;


namespace R5T.T0172
{
    /// <inheritdoc cref="IAssemblyFilePath"/>
    [StrongTypeImplementationMarker]
    public class AssemblyFilePath : TypedBase<string>, IStrongTypeMarker,
        IAssemblyFilePath
    {
        public AssemblyFilePath(string value)
            : base(value)
        {
        }
    }
}
