namespace NerdGolfTracker
{
    public interface IInterpreter
    {
        IOperation OperationFuer(string kommando);
    }
}