using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0172
{
    /// <inheritdoc cref="ICodeFilePath"/>
    [StrongTypeImplementationMarker]
    public class CodeFilePath : TypedBase<string>, IStrongTypeMarker,
        ICodeFilePath
    {
        public CodeFilePath(string value)
            : base(value)
        {
        }
    }
}
