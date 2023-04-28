using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0172
{
    /// <inheritdoc cref="ISolutionFileName"/>
    [StrongTypeImplementationMarker]
    public class SolutionFileName : TypedBase<string>, IStrongTypeMarker,
        ISolutionFileName
    {
        public SolutionFileName(string value)
            : base(value)
        {
        }
    }
}
