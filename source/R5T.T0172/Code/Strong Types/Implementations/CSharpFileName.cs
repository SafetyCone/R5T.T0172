using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0172
{
    /// <inheritdoc cref="ICSharpFileName"/>
    [StrongTypeImplementationMarker]
    public class CSharpFileName : TypedBase<string>, IStrongTypeMarker,
        ICSharpFileName
    {
        public CSharpFileName(string value)
            : base(value)
        {
        }
    }
}
