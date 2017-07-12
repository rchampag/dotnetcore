using Microsoft.Extensions.Options;

namespace RuntimeReloadExample
{
    public class MyService : IMyService
    {
        private readonly MySettings _settings;
        public MyService(IOptionsSnapshot<MySettings> settings)
        {
            _settings = settings.Value;
        }
        public string DoSomething()
        {
            string msg = "ClientSchemaVersion:" + _settings.ClientSchemaVersion
                + ", DbSchemaVersion:" + _settings.DbSchemaVersion;
            return msg;
        }
    }
}
