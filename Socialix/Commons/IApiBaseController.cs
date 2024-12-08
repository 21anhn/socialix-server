namespace Socialix.Commons
{
    public interface IApiBaseController<TRquest, TResponse>
    {
        TResponse ErrorCheck(TRquest request, TResponse response);
        TResponse Exec(TRquest request, TResponse response);
    }
}
