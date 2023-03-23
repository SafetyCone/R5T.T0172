using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0172
{
    /// <inheritdoc cref="IProjectFilePath"/>
    [StrongTypeMarker]
    public class ProjectFilePath : TypedString, IStrongTypeMarker, IProjectFilePath
    {
        public ProjectFilePath(string value)
            : base(value)
        {
        }
    }
}
