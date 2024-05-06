using HttpServer.HTTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.HTTP
{
    public class HttpResponse
    {
        public HttpResponse(byte[] body, string contentType, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }
            this.StatusCode = statusCode;
            this.Body = body;
            this.Headers = new List<Header>()
            {
                new Header("Content-Type", contentType),
                new Header("Content-LEngth", this.Body.Length.ToString())
            };

        }
        public HttpStatusCode StatusCode { get; set; }
        public ICollection<Header> Headers { get; set; }
        public byte[] Body { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"{(int)this.StatusCode} {this.StatusCode}" + HttpConstants.NEW_LINE);

            foreach (var header in this.Headers)  
            {
                sb.Append(header.ToString + HttpConstants.NEW_LINE);
            }

            sb.Append(HttpConstants.NEW_LINE);

            return sb.ToString();
        }
    }
}
