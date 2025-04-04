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
    /// 
    /// </summary>
    public class Target 
    {
        /// <summary>
        /// 对象类型。 - INSTANCE：表示桌面。   target_id：为桌面的SID。   target_name：为桌面name。 - USER：表示用户。   target_id：为用户ID。   target_name：为用户name。 - USERGROUP：表示用户组。   target_id：为用户组ID。   target_name：为用户组name。 - CLIENTIP：终端IP地址。   target_id：终端IP地址。   target_name：终端IP地址。 - OU：组织单元。   target_id：OUID。   target_name：OU名称。 - DESKTOPSPOOL：表示桌面池。   target_id：为桌面池的ID。   target_name：为桌面池name。 - ALL：表示所有桌面。   target_id：default-apply-all-targets。   target_name：All-Targets。
        /// </summary>
        /// <value>对象类型。 - INSTANCE：表示桌面。   target_id：为桌面的SID。   target_name：为桌面name。 - USER：表示用户。   target_id：为用户ID。   target_name：为用户name。 - USERGROUP：表示用户组。   target_id：为用户组ID。   target_name：为用户组name。 - CLIENTIP：终端IP地址。   target_id：终端IP地址。   target_name：终端IP地址。 - OU：组织单元。   target_id：OUID。   target_name：OU名称。 - DESKTOPSPOOL：表示桌面池。   target_id：为桌面池的ID。   target_name：为桌面池name。 - ALL：表示所有桌面。   target_id：default-apply-all-targets。   target_name：All-Targets。</value>
        [JsonConverter(typeof(EnumClassConverter<TargetTypeEnum>))]
        public class TargetTypeEnum
        {
            /// <summary>
            /// Enum INSTANCE for value: INSTANCE
            /// </summary>
            public static readonly TargetTypeEnum INSTANCE = new TargetTypeEnum("INSTANCE");

            /// <summary>
            /// Enum DESKTOPSPOOL for value: DESKTOPSPOOL
            /// </summary>
            public static readonly TargetTypeEnum DESKTOPSPOOL = new TargetTypeEnum("DESKTOPSPOOL");

            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            public static readonly TargetTypeEnum USER = new TargetTypeEnum("USER");

            /// <summary>
            /// Enum CLIENTIP for value: CLIENTIP
            /// </summary>
            public static readonly TargetTypeEnum CLIENTIP = new TargetTypeEnum("CLIENTIP");

            /// <summary>
            /// Enum OU for value: OU
            /// </summary>
            public static readonly TargetTypeEnum OU = new TargetTypeEnum("OU");

            /// <summary>
            /// Enum USERGROUP for value: USERGROUP
            /// </summary>
            public static readonly TargetTypeEnum USERGROUP = new TargetTypeEnum("USERGROUP");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly TargetTypeEnum ALL = new TargetTypeEnum("ALL");

            private static readonly Dictionary<string, TargetTypeEnum> StaticFields =
            new Dictionary<string, TargetTypeEnum>()
            {
                { "INSTANCE", INSTANCE },
                { "DESKTOPSPOOL", DESKTOPSPOOL },
                { "USER", USER },
                { "CLIENTIP", CLIENTIP },
                { "OU", OU },
                { "USERGROUP", USERGROUP },
                { "ALL", ALL },
            };

            private string _value;

            public TargetTypeEnum()
            {

            }

            public TargetTypeEnum(string value)
            {
                _value = value;
            }

            public static TargetTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TargetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TargetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TargetTypeEnum a, TargetTypeEnum b)
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

            public static bool operator !=(TargetTypeEnum a, TargetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 对象ID。
        /// </summary>
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetId { get; set; }

        /// <summary>
        /// 对象名称。
        /// </summary>
        [JsonProperty("target_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetName { get; set; }

        /// <summary>
        /// 对象类型。 - INSTANCE：表示桌面。   target_id：为桌面的SID。   target_name：为桌面name。 - USER：表示用户。   target_id：为用户ID。   target_name：为用户name。 - USERGROUP：表示用户组。   target_id：为用户组ID。   target_name：为用户组name。 - CLIENTIP：终端IP地址。   target_id：终端IP地址。   target_name：终端IP地址。 - OU：组织单元。   target_id：OUID。   target_name：OU名称。 - DESKTOPSPOOL：表示桌面池。   target_id：为桌面池的ID。   target_name：为桌面池name。 - ALL：表示所有桌面。   target_id：default-apply-all-targets。   target_name：All-Targets。
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public TargetTypeEnum TargetType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Target {\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("  targetName: ").Append(TargetName).Append("\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Target);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Target input)
        {
            if (input == null) return false;
            if (this.TargetId != input.TargetId || (this.TargetId != null && !this.TargetId.Equals(input.TargetId))) return false;
            if (this.TargetName != input.TargetName || (this.TargetName != null && !this.TargetName.Equals(input.TargetName))) return false;
            if (this.TargetType != input.TargetType) return false;

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
                if (this.TargetId != null) hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                if (this.TargetName != null) hashCode = hashCode * 59 + this.TargetName.GetHashCode();
                hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                return hashCode;
            }
        }
    }
}
