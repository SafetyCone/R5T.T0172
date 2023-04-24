using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0172
{
    /// <inheritdoc cref="IProjectDirectoryRelativePath"/>
    [StrongTypeImplementationMarker]
    public class ProjectDirectoryRelativePath : TypedBase<string>, IStrongTypeMarker,
        IProjectDirectoryRelativePath
    {
        public ProjectDirectoryRelativePath(string value)
            : base(value)
        {
        }
    }
}
