namespace Socialix.Commons.ApiCommon
{
    public abstract class ApiBaseController<TRquest, TResponse>
    {
        public abstract TResponse ErrorCheck(TRquest request, TResponse response);
        public abstract TResponse Exec(TRquest request, TResponse response);
    }
}
