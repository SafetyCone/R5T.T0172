using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0172
{
    /// <inheritdoc cref="IAssemblyFileName"/>
    [StrongTypeImplementationMarker]
    public class AssemblyFileName : TypedBase<string>, IStrongTypeMarker,
        IAssemblyFileName
    {
        public AssemblyFileName(string value)
            : base(value)
        {
        }
    }
}