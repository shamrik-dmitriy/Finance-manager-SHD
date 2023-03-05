namespace FM.SHD.Infastructure.Impl.Providers
{
    internal enum TransactionState
    {
        Open,
        Rollbacked,
        Error,
        Commited
    }
}
