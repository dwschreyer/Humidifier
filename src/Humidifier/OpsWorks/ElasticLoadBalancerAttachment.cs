namespace Humidifier.OpsWorks
{
    using System.Collections.Generic;

    public class ElasticLoadBalancerAttachment : Humidifier.Resource
    {
        /// <summary>
        /// ElasticLoadBalancerName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-elbattachment.html#cfn-opsworks-elbattachment-elbname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ElasticLoadBalancerName
        {
            get;
            set;
        }

        /// <summary>
        /// LayerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-elbattachment.html#cfn-opsworks-elbattachment-layerid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LayerId
        {
            get;
            set;
        }
    }
}