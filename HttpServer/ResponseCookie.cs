using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer.HTTP
{
    public class ResponseCookie : Cookie
    {
        public ResponseCookie(string key, string value) : base(key, value)
        {
        }

        public int MaxAge { get; set; }
        public bool HttpOnly { get; set; }
        public string Domain { get; set; }
        public string Path { get; set; } = "/";

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"{this.Key}: {this.Value}; Path={this.Path};");
            if (this.MaxAge != 0)
            {
                sb.Append($" MaxAge={MaxAge};");
            }
            if (this.HttpOnly != false)
            {
                sb.Append($" HttpOnly;");
            }

            return sb.ToString();
        }
    }
}
