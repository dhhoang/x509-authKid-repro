using System;
using System.Security.Cryptography.X509Certificates;

namespace x509_authKid_repro
{
    class Program
    {
        static void Main(string[] args)
        {
            const string authorityKeyIdentifierOid = "2.5.29.35";
            var cert = new X509Certificate2("me.crt");
            var ext = cert.Extensions[authorityKeyIdentifierOid];
            Console.WriteLine(ext.Format(false));
        }
    }
}
