namespace Humidifier.IAM
{
    using System.Collections.Generic;
    using RoleTypes;

    public class Role : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        /// <summary>
        /// AssumeRolePolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-assumerolepolicydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic AssumeRolePolicyDocument
        {
            get;
            set;
        }

        /// <summary>
        /// ManagedPolicyArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-managepolicyarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ManagedPolicyArns
        {
            get;
            set;
        }

        /// <summary>
        /// Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-path
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Path
        {
            get;
            set;
        }

        /// <summary>
        /// Policies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-policies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Policy
        /// </summary>
        public List<Policy> Policies
        {
            get;
            set;
        }

        /// <summary>
        /// RoleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-rolename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleName
        {
            get;
            set;
        }
    }

    namespace RoleTypes
    {
        public class Policy
        {
            /// <summary>
            /// PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html#cfn-iam-policies-policydocument
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic PolicyDocument
            {
                get;
                set;
            }

            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html#cfn-iam-policies-policyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyName
            {
                get;
                set;
            }
        }
    }
}