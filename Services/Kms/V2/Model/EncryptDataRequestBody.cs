using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EncryptDataRequestBody 
    {
        /// <summary>
        /// 数据加密算法，仅使用非对称密钥需要指定该参数，默认值为“SYMMETRIC_DEFAULT”，合法枚举值如下：  - SYMMETRIC_DEFAULT  - RSAES_OAEP_SHA_256  - SM2_ENCRYPT
        /// </summary>
        /// <value>数据加密算法，仅使用非对称密钥需要指定该参数，默认值为“SYMMETRIC_DEFAULT”，合法枚举值如下：  - SYMMETRIC_DEFAULT  - RSAES_OAEP_SHA_256  - SM2_ENCRYPT</value>
        [JsonConverter(typeof(EnumClassConverter<EncryptionAlgorithmEnum>))]
        public class EncryptionAlgorithmEnum
        {
            /// <summary>
            /// Enum SYMMETRIC_DEFAULT for value: SYMMETRIC_DEFAULT
            /// </summary>
            public static readonly EncryptionAlgorithmEnum SYMMETRIC_DEFAULT = new EncryptionAlgorithmEnum("SYMMETRIC_DEFAULT");

            /// <summary>
            /// Enum RSAES_OAEP_SHA_256 for value: RSAES_OAEP_SHA_256
            /// </summary>
            public static readonly EncryptionAlgorithmEnum RSAES_OAEP_SHA_256 = new EncryptionAlgorithmEnum("RSAES_OAEP_SHA_256");

            /// <summary>
            /// Enum SM2_ENCRYPT for value: SM2_ENCRYPT
            /// </summary>
            public static readonly EncryptionAlgorithmEnum SM2_ENCRYPT = new EncryptionAlgorithmEnum("SM2_ENCRYPT");

            private static readonly Dictionary<string, EncryptionAlgorithmEnum> StaticFields =
            new Dictionary<string, EncryptionAlgorithmEnum>()
            {
                { "SYMMETRIC_DEFAULT", SYMMETRIC_DEFAULT },
                { "RSAES_OAEP_SHA_256", RSAES_OAEP_SHA_256 },
                { "SM2_ENCRYPT", SM2_ENCRYPT },
            };

            private string _value;

            public EncryptionAlgorithmEnum()
            {

            }

            public EncryptionAlgorithmEnum(string value)
            {
                _value = value;
            }

            public static EncryptionAlgorithmEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as EncryptionAlgorithmEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EncryptionAlgorithmEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EncryptionAlgorithmEnum a, EncryptionAlgorithmEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(EncryptionAlgorithmEnum a, EncryptionAlgorithmEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 密钥ID，36字节，满足正则匹配“^[0-9a-z]{8}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{12}$”。 例如：0d0466b0-e727-4d9c-b35d-f84bb474a37f。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 明文数据，1~4096字节，满足正则匹配“^.{1,4096}$”，且转化为byte数组后长度取值范围为1~4096字节。
        /// </summary>
        [JsonProperty("plain_text", NullValueHandling = NullValueHandling.Ignore)]
        public string PlainText { get; set; }

        /// <summary>
        /// 数据加密算法，仅使用非对称密钥需要指定该参数，默认值为“SYMMETRIC_DEFAULT”，合法枚举值如下：  - SYMMETRIC_DEFAULT  - RSAES_OAEP_SHA_256  - SM2_ENCRYPT
        /// </summary>
        [JsonProperty("encryption_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public EncryptionAlgorithmEnum EncryptionAlgorithm { get; set; }
        /// <summary>
        /// 身份验证的非敏感额外数据。任意字符串，长度不超过128字节。
        /// </summary>
        [JsonProperty("additional_authenticated_data", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalAuthenticatedData { get; set; }

        /// <summary>
        /// 请求消息序列号，36字节序列号。 例如：919c82d4-8046-4722-9094-35c3c6524cff
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptDataRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  plainText: ").Append(PlainText).Append("\n");
            sb.Append("  encryptionAlgorithm: ").Append(EncryptionAlgorithm).Append("\n");
            sb.Append("  additionalAuthenticatedData: ").Append(AdditionalAuthenticatedData).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EncryptDataRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EncryptDataRequestBody input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.PlainText != input.PlainText || (this.PlainText != null && !this.PlainText.Equals(input.PlainText))) return false;
            if (this.EncryptionAlgorithm != input.EncryptionAlgorithm) return false;
            if (this.AdditionalAuthenticatedData != input.AdditionalAuthenticatedData || (this.AdditionalAuthenticatedData != null && !this.AdditionalAuthenticatedData.Equals(input.AdditionalAuthenticatedData))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.KeyId != null) hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.PlainText != null) hashCode = hashCode * 59 + this.PlainText.GetHashCode();
                hashCode = hashCode * 59 + this.EncryptionAlgorithm.GetHashCode();
                if (this.AdditionalAuthenticatedData != null) hashCode = hashCode * 59 + this.AdditionalAuthenticatedData.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
