using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 参数模板信息。
    /// </summary>
    public class ConfigurationSummaryForCreate 
    {
        /// <summary>
        /// 引擎名。
        /// </summary>
        /// <value>引擎名。</value>
        [JsonConverter(typeof(EnumClassConverter<DatastoreNameEnum>))]
        public class DatastoreNameEnum
        {
            /// <summary>
            /// Enum MYSQL for value: mysql
            /// </summary>
            public static readonly DatastoreNameEnum MYSQL = new DatastoreNameEnum("mysql");

            /// <summary>
            /// Enum POSTGRESQL for value: postgresql
            /// </summary>
            public static readonly DatastoreNameEnum POSTGRESQL = new DatastoreNameEnum("postgresql");

            /// <summary>
            /// Enum SQLSERVER for value: sqlserver
            /// </summary>
            public static readonly DatastoreNameEnum SQLSERVER = new DatastoreNameEnum("sqlserver");

            private static readonly Dictionary<string, DatastoreNameEnum> StaticFields =
            new Dictionary<string, DatastoreNameEnum>()
            {
                { "mysql", MYSQL },
                { "postgresql", POSTGRESQL },
                { "sqlserver", SQLSERVER },
            };

            private string _value;

            public DatastoreNameEnum()
            {

            }

            public DatastoreNameEnum(string value)
            {
                _value = value;
            }

            public static DatastoreNameEnum FromValue(string value)
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

                if (this.Equals(obj as DatastoreNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DatastoreNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DatastoreNameEnum a, DatastoreNameEnum b)
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

            public static bool operator !=(DatastoreNameEnum a, DatastoreNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 参数组ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 参数组名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数组描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 引擎版本。
        /// </summary>
        [JsonProperty("datastore_version_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreVersionName { get; set; }

        /// <summary>
        /// 引擎名。
        /// </summary>
        [JsonProperty("datastore_name", NullValueHandling = NullValueHandling.Ignore)]
        public DatastoreNameEnum DatastoreName { get; set; }
        /// <summary>
        /// 创建时间，格式为\&quot;yyyy-MM-ddTHH:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 更新时间，格式为\&quot;yyyy-MM-ddTHH:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationSummaryForCreate {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  datastoreVersionName: ").Append(DatastoreVersionName).Append("\n");
            sb.Append("  datastoreName: ").Append(DatastoreName).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigurationSummaryForCreate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigurationSummaryForCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DatastoreVersionName == input.DatastoreVersionName ||
                    (this.DatastoreVersionName != null &&
                    this.DatastoreVersionName.Equals(input.DatastoreVersionName))
                ) && 
                (
                    this.DatastoreName == input.DatastoreName ||
                    (this.DatastoreName != null &&
                    this.DatastoreName.Equals(input.DatastoreName))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DatastoreVersionName != null)
                    hashCode = hashCode * 59 + this.DatastoreVersionName.GetHashCode();
                if (this.DatastoreName != null)
                    hashCode = hashCode * 59 + this.DatastoreName.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                return hashCode;
            }
        }
    }
}
