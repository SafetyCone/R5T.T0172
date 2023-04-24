using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0172
{
    /// <inheritdoc cref="IProjectDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class ProjectDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IProjectDirectoryPath
    {
        public ProjectDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
