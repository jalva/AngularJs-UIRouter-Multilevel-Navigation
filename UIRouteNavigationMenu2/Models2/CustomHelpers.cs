using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.IO;
using System.Web.Mvc;

namespace UINavigation2Controller.Models2
{
    public static class CustomHelpers
    {
        public static MvcHtmlString GetUiRouterStates(this HtmlHelper helper)
        {
            var statesService = new UiRouterStatesService();
            var uiStates = statesService.GetUiRouteStates();
            var serializedStates = SerializeObject(uiStates);
            return serializedStates;
        }

        private static MvcHtmlString SerializeObject(object value)
        {
            using (var stringWriter = new StringWriter())
            using (var jsonWriter = new JsonTextWriter(stringWriter))
            {
                var serializer = new JsonSerializer
                {
                    // Let's use camelCasing as is common practice in JavaScript
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };

                // We don't want quotes around object names
                jsonWriter.QuoteName = false;
                serializer.Serialize(jsonWriter, value);

                return new MvcHtmlString(stringWriter.ToString());
            }
        }
    }
}
