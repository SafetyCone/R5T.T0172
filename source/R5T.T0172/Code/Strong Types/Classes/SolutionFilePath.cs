using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0172
{
    /// <inheritdoc cref="ISolutionFilePath"/>
    [StrongTypeMarker]
    public class SolutionFilePath : TypedString, IStrongTypeMarker, ISolutionFilePath
    {
        public SolutionFilePath(string value)
            : base(value)
        {
        }
    }
}
