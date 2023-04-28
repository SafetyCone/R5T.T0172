using System;

using R5T.T0142;


namespace R5T.T0172
{
    [DataTypeMarker]
    public interface IHasSolutionDirectoryPath
    {
        ISolutionDirectoryPath SolutionDirectoryPath { get; set; }
    }
}
