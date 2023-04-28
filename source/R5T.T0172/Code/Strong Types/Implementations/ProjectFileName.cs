using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0172
{
    /// <inheritdoc cref="IProjectFileName"/>
    [StrongTypeImplementationMarker]
    public class ProjectFileName : TypedBase<string>, IStrongTypeMarker,
        IProjectFileName
    {
        public ProjectFileName(string value)
            : base(value)
        {
        }
    }
}
