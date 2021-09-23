using System;

namespace Blockfrost.Api.Http
{
    /// <summary>Decorates a Post Method with the route</summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class PostAttribute : Attribute
    {
        public string Route;
        public string Version;
        /// <summar></summar>
        /// <param name="route">The OAS route</param>
        /// <param name="version">The OAS version</param>
        public PostAttribute(string route, string version)
        {
            Route = route;
            Version = version;
        }
    }
}
