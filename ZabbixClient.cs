using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using ZabbixApi.Agents;
using ZabbixApi.Common;

//https://www.zabbix.com/documentation/2.2/manual/api/reference
namespace ZabbixApi
{

    public class ZabbixClient
    {
        private readonly string _url;
        private readonly string _login;
        private readonly string _password;
        private string _authHash;

        public ActionAgent Actions;
        public AlertAgent Alerts;
        public ApplicationAgent Applications;
        public ConfigurationAgent Configurations;
        public DiscoveredHostAgent DiscoveredHosts;
        public DiscoveredServiceAgent DiscoveredServices;
        public DiscoveryCheckAgent DiscoveryChecks;
        public DiscoveryRuleAgent DiscoveryRules;
        public EventAgent Events;
        public GraphAgent Graphs;
        public GraphItemAgent GraphItems;
        public GraphPrototypeAgent GraphPrototypes;
        public HistoryAgent Historys;
        public HostAgent Hosts;
        public HostGroupAgent HostGroups;
        public HostInterfaceAgent HostInterfaces;
        public HostPrototypeAgent HostPrototypes;
        public ITServiceAgent ITServices;
        public IconMapAgent IconMaps;
        public ImageAgent Images;
        public ItemAgent Items;
        public ItemPrototypeAgent ItemPrototypes;
        public LLDRuleAgent LLDRules;
        public MaintenanceAgent Maintenances;
        public MapAgent Maps;
        public MediaTypeAgent MediaTypes;
        public MediaAgent Media;
        public ProxyAgent Proxys;
        public ScreenAgent Screens;
        public ScreenItemAgent ScreenItems;
        public ScriptAgent Scripts;
        public TemplateAgent Templates;
        public TemplateScreenAgent TemplateScreens;
        public TemplateScreenItemAgent TemplateScreenItems;
        public TriggerAgent Triggers;
        public TriggerPrototypeAgent TriggerPrototypes;
        public TrendsAgent Trends;
        public UserAgent Users;
        public UserGroupAgent UserGroups;
        public UserMacroAgent UserMacros;
        public WebScenarioAgent WebScenarios;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public ZabbixClient(string url, string login, string password)
        {
            if(string.IsNullOrWhiteSpace(url))
                throw new ArgumentException("значение параметра 'url' не может быть пустым или состоять из пробелов!");
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentException("значение параметра 'login' не может быть пустым или состоять из пробелов!");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("значение параметра 'password' не может быть пустым или состоять из пробелов!");
            if (!url.EndsWith("/"))
                url += "/";
            if (!url.StartsWith("http://"))
                url = "http://" + url;
            /*
            Uri uriResult;
            if (!(Uri.TryCreate(url, UriKind.Absolute, out uriResult) && uriResult.Scheme == Uri.UriSchemeHttp))
                throw new Exception(string.Format("Неверный адрес! '{0}'", url));*/

            _url = string.Format(@"{0}zabbix/api_jsonrpc.php", url);
            _login = login;
            _password = password;
            Actions = new ActionAgent(this);
            Alerts = new AlertAgent(this);
            Applications = new ApplicationAgent(this);
            Configurations = new ConfigurationAgent(this);
            DiscoveredHosts = new DiscoveredHostAgent(this);
            DiscoveredServices = new DiscoveredServiceAgent(this);
            DiscoveryChecks = new DiscoveryCheckAgent(this);
            DiscoveryRules = new DiscoveryRuleAgent(this);
            Events = new EventAgent(this);
            Graphs = new GraphAgent(this);
            GraphItems = new GraphItemAgent(this);
            GraphPrototypes = new GraphPrototypeAgent(this);
            Historys = new HistoryAgent(this);
            Hosts = new HostAgent(this);
            HostGroups = new HostGroupAgent(this);
            HostInterfaces = new HostInterfaceAgent(this);
            HostPrototypes = new HostPrototypeAgent(this);
            ITServices = new ITServiceAgent(this);
            IconMaps = new IconMapAgent(this);
            Images = new ImageAgent(this);
            Items = new ItemAgent(this);
            ItemPrototypes = new ItemPrototypeAgent(this);
            LLDRules = new LLDRuleAgent(this);
            Maintenances = new MaintenanceAgent(this);
            Maps = new MapAgent(this);
            MediaTypes = new MediaTypeAgent(this);
            Media = new MediaAgent(this);
            Proxys = new ProxyAgent(this);
            Screens = new ScreenAgent(this);
            ScreenItems = new ScreenItemAgent(this);
            Scripts = new ScriptAgent(this);
            Templates = new TemplateAgent(this);
            TemplateScreens = new TemplateScreenAgent(this);
            TemplateScreenItems = new TemplateScreenItemAgent(this);
            Triggers = new TriggerAgent(this);
            TriggerPrototypes = new TriggerPrototypeAgent(this);
            Trends = new TrendsAgent(this);
            Users = new UserAgent(this);
            UserGroups = new UserGroupAgent(this);
            UserMacros = new UserMacroAgent(this);
            WebScenarios = new WebScenarioAgent(this);
        }

        #region BASE
        private string GetWebRequest(BaseRequest request)
        {
            string responseFromServer;
            try
            {
                var wb = WebRequest.Create(_url);
                wb.ContentType = @"application/json-rpc";
                wb.Credentials = CredentialCache.DefaultCredentials;
                var encoding = new ASCIIEncoding();
                var postData = JsonConvert.SerializeObject(request, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                var data = encoding.GetBytes(postData);
                wb.Method = "POST";
                wb.ContentLength = data.Length;
                var newStream = wb.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();
                var response = (HttpWebResponse)wb.GetResponse();
                var dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка отправки запроса!", ex);
            }
            return responseFromServer;
        }

        public T Call<T>(string method = null, object param = null)
        {
            var result = default(T);
            // проверка авторизации перед исполнением метода
            if (_authHash == null && method != "user.authenticate")
            {
                // попытка подключения
                if (!Connect())
                    return result;
            }
            // проверка наличия метода
            if (!string.IsNullOrWhiteSpace(method))
            {
                try
                {
                    // выполнение запроса
                    var requestResult = GetWebRequest(new BaseRequest
                                                          {
                                                              auth = _authHash,
                                                              method = method,
                                                              @params = param
                                                          });
                    result = JsonConvert.DeserializeObject<T>(requestResult);
                }
                catch (Exception e)
                {
                    throw new Exception("Ошибка исполнения запроса!", e);
                }
            }
            else
            {
                throw new Exception("Не указан вызываемый метод!");
            }
            return result;
        }

        public bool Connect()
        {
            try
            {
                // авторизация
                var auth = GetWebRequest(new BaseRequest
                                             {
                                                 method = "user.authenticate",
                                                 @params = new { user = _login, password = _password }
                                             });
                var authDeserialize = JsonConvert.DeserializeObject<StringResponse>(auth);
                if (authDeserialize.error != null)
                {
                    throw new Exception(string.Format(@"{0}\n{1}", authDeserialize.error.message, authDeserialize.error.data));
                }
                _authHash = authDeserialize.result;
            }
            catch (Exception e)
            {
                throw new Exception("Ошибка исполнения запроса авторизации!", e);
            }
            return !string.IsNullOrWhiteSpace(_authHash);
        }
        #endregion
    }
}
