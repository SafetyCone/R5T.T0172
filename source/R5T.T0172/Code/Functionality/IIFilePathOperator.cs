using System;

using R5T.T0132;
using R5T.T0180;

using R5T.T0172.Extensions;


namespace R5T.T0172
{
    [FunctionalityMarker]
    public partial interface IFilePathOperator : IFunctionalityMarker
    {
        public IProjectFilePath AsProjectFilePath(IFilePath filePath)
        {
            return filePath.Value.ToProjectFilePath();
        }
    }
}
