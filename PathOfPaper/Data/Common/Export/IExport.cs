using Newtonsoft.Json.Linq;

namespace PathOfPaper.Data.Common.Export
{
    public interface IExport
    {
        object Export();
    }
}