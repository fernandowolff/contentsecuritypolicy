using System.Text;

namespace Jhoose.Security.Core.Models
{
    public class SchemaSource 
    {
        public SchemaSource() 
        {
            this.Http = false;
            this.Https = false;
            this.Data = false;
            this.Mediastream = false;
            this.Blob = false;
            this.Filesystem = false;
        }

        public bool Http {get;set;}
        public bool Https {get;set;}
        public bool Data {get;set;}
        public bool Mediastream {get;set;}
        public bool Blob {get;set;}
        public bool Filesystem {get;set;}


        public override string ToString()
        {
            var sb = new StringBuilder();

            if(this.Http) sb.Append("http: ");
            if(this.Https) sb.Append("https: ");

            if(this.Data) sb.Append("data: ");
            if(this.Mediastream) sb.Append("mediastream: ");
            if(this.Blob) sb.Append("blob: ");
            if(this.Filesystem) sb.Append("filesystem: ");

            return sb.ToString();
        }

        public bool HasSchemaSource => this.Http | this.Https | this.Data | this.Mediastream | this.Blob | this.Filesystem;
    }
}