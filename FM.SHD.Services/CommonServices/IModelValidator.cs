namespace FM.SHD.Services.CommonServices
{
    public interface IModelValidator
    {
        void ValidateModel<T>(T model);
    }
}