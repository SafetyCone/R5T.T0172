using System;


namespace R5T.T0172
{
    public static class Instances
    {
        public static IFilePathOperator FilePathOperator => T0172.FilePathOperator.Instance;
        public static Extensions.IStringOperator StringOperator_Extensions => Extensions.StringOperator.Instance;	
    }
}