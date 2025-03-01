using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 操作桌面池请求。
    /// </summary>
    public class DesktopPoolActionReq 
    {
        /// <summary>
        /// 执行类型。例如type为HARD，op_type为os-stop代表强制关机。 - SOFT：普通操作。 - HARD：强制操作。
        /// </summary>
        /// <value>执行类型。例如type为HARD，op_type为os-stop代表强制关机。 - SOFT：普通操作。 - HARD：强制操作。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SOFT for value: SOFT
            /// </summary>
            public static readonly TypeEnum SOFT = new TypeEnum("SOFT");

            /// <summary>
            /// Enum HARD for value: HARD
            /// </summary>
            public static readonly TypeEnum HARD = new TypeEnum("HARD");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "SOFT", SOFT },
                { "HARD", HARD },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 操作类型。 -os-start 开机。 -os-stop 关机。 -reboot 重启。 -hibernate 休眠。
        /// </summary>
        [JsonProperty("op_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OpType { get; set; }

        /// <summary>
        /// 执行类型。例如type为HARD，op_type为os-stop代表强制关机。 - SOFT：普通操作。 - HARD：强制操作。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopPoolActionReq {\n");
            sb.Append("  opType: ").Append(OpType).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopPoolActionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopPoolActionReq input)
        {
            if (input == null) return false;
            if (this.OpType != input.OpType || (this.OpType != null && !this.OpType.Equals(input.OpType))) return false;
            if (this.Type != input.Type) return false;

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
                if (this.OpType != null) hashCode = hashCode * 59 + this.OpType.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
