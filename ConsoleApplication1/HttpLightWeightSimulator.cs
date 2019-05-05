using Subtext.TestLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.SessionState;

namespace ConsoleApplication1
{
    class HttpLightWeightSimulator
    {
        static void Main()
        {
           SetHttpContextWithSimulatedRequest("SimulatorApplication", "Application");
           HttpContext.Current.Items["CacheKey"] = "";
           Console.ReadKey();
        }

        static void SetHttpContextWithSimulatedRequest(string host, string application)
        {
            //string appVirtualDir = "/";
            //string appPhysicalDir = @"F:\CopyDVD\AllWebApp\";
            //string page = application.Replace("/", string.Empty) + "/Caching.aspx";
            //string query = string.Empty;
            //TextWriter output = null;

            Uri url = new Uri("http://localhost/CopyDvd/Caching.aspx");
            HttpSimulator simulator = new HttpSimulator(@"F:\CopyDVD\AllWebApp\", @"c:\inetpub\wwwroot\");
            simulator.SimulateRequest(url);
             HttpSessionState state= HttpContext.Current.Session;

            //HttpSimulator workerRequest = new HttpSimulator(appVirtualDir, appPhysicalDir, page, query, output, host);
            //HttpContext.Current = new HttpContext(workerRequest);

            //Console.WriteLine("Request.FilePath: " + HttpContext.Current.Request.FilePath);
            //Console.WriteLine("Request.Path: " + HttpContext.Current.Request.Path);

            //Console.WriteLine("Request.RawUrl: " + HttpContext.Current.Request.RawUrl);

            //Console.WriteLine("Request.Url: " + HttpContext.Current.Request.Url);

            //Console.WriteLine("Request.ApplicationPath: " + HttpContext.Current.Request.ApplicationPath);

            //Console.WriteLine("Request.PhysicalPath: " + HttpContext.Current.Request.PhysicalPath);
        }
    }
    
    class SimulatedHttpRequest : SimpleWorkerRequest
    {
        string _host;

        /// <summary>
        /// Creates a new <see cref="SimulatedHttpRequest"/> instance.
        /// </summary>
        /// <param name="appVirtualDir">App virtual dir.</param>
        /// <param name="appPhysicalDir">App physical dir.</param>
        /// <param name="page">Page.</param>
        /// <param name="query">Query.</param>
        /// <param name="output">Output.</param>
        /// <param name="host">Host.</param>
        public SimulatedHttpRequest(string appVirtualDir, string appPhysicalDir, string page, string query, TextWriter output, string host)
            : base(appVirtualDir, appPhysicalDir, page, query, output)
        {
            if (host == null || host.Length == 0)
                throw new ArgumentNullException("host", "Host cannot be null nor empty.");
            _host = host;
        }

        /// <summary>
        /// Gets the name of the server.
        /// </summary>
        /// <returns></returns>
        public override string GetServerName()
        {
            return _host;
        }

        /// <summary>
        /// Maps the path to a filesystem path.
        /// </summary>
        /// <param name="virtualPath">Virtual path.</param>
        /// <returns></returns>
        public override string MapPath(string virtualPath)
        {
            return Path.Combine(this.GetAppPath(), virtualPath);
        }
    }
}
