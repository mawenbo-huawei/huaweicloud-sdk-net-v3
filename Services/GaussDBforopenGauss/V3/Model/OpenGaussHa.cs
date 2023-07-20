using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 实例部署形态。
    /// </summary>
    public class OpenGaussHa 
    {
        /// <summary>
        /// GaussDB为分布式时，取值：enterprise；为集中式时，取值：centralization_standard。不区分大小写。
        /// </summary>
        /// <value>GaussDB为分布式时，取值：enterprise；为集中式时，取值：centralization_standard。不区分大小写。</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum ENTERPRISE for value: enterprise
            /// </summary>
            public static readonly ModeEnum ENTERPRISE = new ModeEnum("enterprise");

            /// <summary>
            /// Enum CENTRALIZATION_STANDARD for value: centralization_standard
            /// </summary>
            public static readonly ModeEnum CENTRALIZATION_STANDARD = new ModeEnum("centralization_standard");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "enterprise", ENTERPRISE },
                { "centralization_standard", CENTRALIZATION_STANDARD },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 指定实例一致性类型，当创建分布式模式实例时，该字段值必传，当创建主备模式实例时，该字段值不传。取值范围：strong（强一致性） | eventual(最终一致性)，不分区大小写。
        /// </summary>
        /// <value>指定实例一致性类型，当创建分布式模式实例时，该字段值必传，当创建主备模式实例时，该字段值不传。取值范围：strong（强一致性） | eventual(最终一致性)，不分区大小写。</value>
        [JsonConverter(typeof(EnumClassConverter<ConsistencyEnum>))]
        public class ConsistencyEnum
        {
            /// <summary>
            /// Enum STRONG for value: strong
            /// </summary>
            public static readonly ConsistencyEnum STRONG = new ConsistencyEnum("strong");

            /// <summary>
            /// Enum EVENTUAL for value: eventual
            /// </summary>
            public static readonly ConsistencyEnum EVENTUAL = new ConsistencyEnum("eventual");

            private static readonly Dictionary<string, ConsistencyEnum> StaticFields =
            new Dictionary<string, ConsistencyEnum>()
            {
                { "strong", STRONG },
                { "eventual", EVENTUAL },
            };

            private string _value;

            public ConsistencyEnum()
            {

            }

            public ConsistencyEnum(string value)
            {
                _value = value;
            }

            public static ConsistencyEnum FromValue(string value)
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

                if (this.Equals(obj as ConsistencyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConsistencyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConsistencyEnum a, ConsistencyEnum b)
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

            public static bool operator !=(ConsistencyEnum a, ConsistencyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 备机同步参数。  取值：  GaussDB为“sync\&quot;  说明： - “sync”为同步模式。
        /// </summary>
        /// <value>备机同步参数。  取值：  GaussDB为“sync\&quot;  说明： - “sync”为同步模式。</value>
        [JsonConverter(typeof(EnumClassConverter<ReplicationModeEnum>))]
        public class ReplicationModeEnum
        {
            /// <summary>
            /// Enum SYNC for value: sync
            /// </summary>
            public static readonly ReplicationModeEnum SYNC = new ReplicationModeEnum("sync");

            private static readonly Dictionary<string, ReplicationModeEnum> StaticFields =
            new Dictionary<string, ReplicationModeEnum>()
            {
                { "sync", SYNC },
            };

            private string _value;

            public ReplicationModeEnum()
            {

            }

            public ReplicationModeEnum(string value)
            {
                _value = value;
            }

            public static ReplicationModeEnum FromValue(string value)
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

                if (this.Equals(obj as ReplicationModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReplicationModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReplicationModeEnum a, ReplicationModeEnum b)
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

            public static bool operator !=(ReplicationModeEnum a, ReplicationModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// GaussDB为分布式时，取值：enterprise；为集中式时，取值：centralization_standard。不区分大小写。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 指定实例一致性类型，当创建分布式模式实例时，该字段值必传，当创建主备模式实例时，该字段值不传。取值范围：strong（强一致性） | eventual(最终一致性)，不分区大小写。
        /// </summary>
        [JsonProperty("consistency", NullValueHandling = NullValueHandling.Ignore)]
        public ConsistencyEnum Consistency { get; set; }
        /// <summary>
        /// 备机同步参数。  取值：  GaussDB为“sync\&quot;  说明： - “sync”为同步模式。
        /// </summary>
        [JsonProperty("replication_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ReplicationModeEnum ReplicationMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenGaussHa {\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  consistency: ").Append(Consistency).Append("\n");
            sb.Append("  replicationMode: ").Append(ReplicationMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenGaussHa);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenGaussHa input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Consistency == input.Consistency ||
                    (this.Consistency != null &&
                    this.Consistency.Equals(input.Consistency))
                ) && 
                (
                    this.ReplicationMode == input.ReplicationMode ||
                    (this.ReplicationMode != null &&
                    this.ReplicationMode.Equals(input.ReplicationMode))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Consistency != null)
                    hashCode = hashCode * 59 + this.Consistency.GetHashCode();
                if (this.ReplicationMode != null)
                    hashCode = hashCode * 59 + this.ReplicationMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
