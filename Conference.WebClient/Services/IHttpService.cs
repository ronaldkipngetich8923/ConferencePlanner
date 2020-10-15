using System.Threading.Tasks;

namespace Conference.WebClient
{
    public interface IHttpService
    {
        Task<T> GetAsync<T>(string url);
        Task<T> PostAsync<T>(string url, object data);
        //string GetToken();
    }
}
