using Newtonsoft.Json.Linq;

namespace PathOfPaper.Data.Common.Import
{
    public interface IImport
    {
        void Import(JObject data);
    }
}