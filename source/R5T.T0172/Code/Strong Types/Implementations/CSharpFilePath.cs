using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0172
{
    /// <inheritdoc cref="ICSharpFilePath"/>
    [StrongTypeImplementationMarker]
    public class CSharpFilePath : TypedBase<string>, IStrongTypeMarker,
        ICSharpFilePath
    {
        public CSharpFilePath(string value)
            : base(value)
        {
        }
    }
}
