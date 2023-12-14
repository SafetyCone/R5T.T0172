using System;

using R5T.T0142;


namespace R5T.T0172
{
    [DataTypeMarker]
    public interface IWithProjectFilePath :
        IHasProjectFilePath
    {
        new IProjectFilePath ProjectFilePath { set; }
    }
}
