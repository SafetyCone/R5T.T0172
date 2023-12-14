using System;

using R5T.T0142;


namespace R5T.T0172.N001
{
    [DataTypeMarker]
    public interface IWithProjectFilePath :
        IHasProjectFilePath
    {
        new string ProjectFilePath { set; }
    }
}
