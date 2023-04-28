using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0172
{
    /// <inheritdoc cref="ISolutionDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class SolutionDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        ISolutionDirectoryPath
    {
        public SolutionDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
