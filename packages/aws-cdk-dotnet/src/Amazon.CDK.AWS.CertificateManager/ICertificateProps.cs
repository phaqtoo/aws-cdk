using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Amazon.CDK.AWS.CertificateManager
{
    /// <summary>Properties for your certificate</summary>
    [JsiiInterface(typeof(ICertificateProps), "@aws-cdk/aws-certificatemanager.CertificateProps")]
    public interface ICertificateProps
    {
        /// <summary>
        /// Fully-qualified domain name to request a certificate for.
        /// 
        /// May contain wildcards, such as ``*.domain.com``.
        /// </summary>
        [JsiiProperty("domainName", "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
            set;
        }

        /// <summary>
        /// Alternative domain names on your certificate.
        /// 
        /// Use this to register alternative domain names that represent the same site.
        /// </summary>
        [JsiiProperty("subjectAlternativeNames", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"string\"}},\"optional\":true}")]
        string[] SubjectAlternativeNames
        {
            get;
            set;
        }

        /// <summary>
        /// What validation domain to use for every requested domain.
        /// 
        /// Has to be a superdomain of the requested domain.
        /// </summary>
        /// <remarks>default: Apex domain is used for every domain that's not overridden.</remarks>
        [JsiiProperty("validationDomains", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"string\"}},\"optional\":true}")]
        IDictionary<string, string> ValidationDomains
        {
            get;
            set;
        }
    }
}