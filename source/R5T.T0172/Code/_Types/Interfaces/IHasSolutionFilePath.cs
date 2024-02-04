using System;

using R5T.T0142;


namespace R5T.T0172
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// For stringly-typed complementary type, see R5T.L0095.T000.
    /// </remarks>
    [DataTypeMarker]
    public interface IHasSolutionFilePath
    {
        ISolutionFilePath SolutionFilePath { get; set; }
    }
}
