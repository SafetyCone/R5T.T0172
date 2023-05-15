using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0172
{
    /// <inheritdoc cref="IProjectDirectoryRelativeDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class ProjectDirectoryRelativeDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IProjectDirectoryRelativeDirectoryPath
    {
        public ProjectDirectoryRelativeDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
