using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.KMS
{
    /// <summary>Construction properties for a KMS Key object</summary>
    [JsiiInterface(typeof(IEncryptionKeyProps), "@aws-cdk/aws-kms.EncryptionKeyProps")]
    public interface IEncryptionKeyProps
    {
        /// <summary>
        /// A description of the key. Use a description that helps your users decide
        /// whether the key is appropriate for a particular task.
        /// </summary>
        [JsiiProperty("description", "{\"primitive\":\"string\",\"optional\":true}")]
        string Description
        {
            get;
            set;
        }

        /// <summary>Indicates whether AWS KMS rotates the key.</summary>
        /// <remarks>default: false</remarks>
        [JsiiProperty("enableKeyRotation", "{\"primitive\":\"boolean\",\"optional\":true}")]
        bool? EnableKeyRotation
        {
            get;
            set;
        }

        /// <summary>Indicates whether the key is available for use.</summary>
        /// <remarks>default: Key is enabled</remarks>
        [JsiiProperty("enabled", "{\"primitive\":\"boolean\",\"optional\":true}")]
        bool? Enabled
        {
            get;
            set;
        }

        /// <summary>Custom policy document to attach to the KMS key.</summary>
        /// <remarks>
        /// default: A policy document with permissions for the account root to
        /// administer the key will be created.
        /// </remarks>
        [JsiiProperty("policy", "{\"fqn\":\"@aws-cdk/cdk.PolicyDocument\",\"optional\":true}")]
        PolicyDocument Policy
        {
            get;
            set;
        }
    }
}