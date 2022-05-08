using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace OiuTools.Api.Core.Tools
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class StaticExtend
    {
        /// <summary>
        /// DataTable是否为空
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this DataTable dt)
        {
            return dt == null || dt.Rows.Count == 0;
        }
        /// <summary>
        /// DataTable是否不为空
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty(this DataTable dt)
        {
            return !IsNullOrEmpty(dt);
        }
        /// <summary>
        /// 是否为空字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }
        /// <summary>
        /// 列表不为空
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty<T>(this IList<T> list)
        {
            return !IsNullOrEmpty(list);
        }

        /// <summary>
        /// 列表不为空
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty<T>(this EnumerableRowCollection<T> list)
        {
            return !IsNullOrEmpty(list);
        }

        /// <summary>
        /// 列表为空
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this EnumerableRowCollection<T> list)
        {
            return list == null || !list.Any();
        }

        /// <summary>
        /// 列表为空
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return list == null || !list.Any();
        }


        /// <summary>
        /// 是否不是空字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty(this string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }

        /// <summary>
        /// 是否为数字
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNumber(this string s)
        {
            return Regex.IsMatch(s, @"^[+-]?\d*[.]?\d*$");
        }


        /// <summary>
        /// 绝对路径转换为上传文件夹FileUpload的相对路径
        /// </summary>
        /// <param name="s">物理绝对路径</param>
        /// <returns></returns>
        public static string ToUploadRelativePath(this string s)
        {
            if (s.IsNullOrEmpty()) return string.Empty;
            var index = s.ToLower().IndexOf(@"\fileupload\");
            var result = s.Substring(index).Replace(@"\", "/");
            return result;
        }



        /// <summary>
        /// 对象转换为Int类型
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static int ToInt(this object o)
        {
            if (o == null) return 0;
            int.TryParse(o.ToString(), out var reValue);
            return reValue;
        }

        /// <summary>
        /// 将需要分隔的字符串，分隔成'1','2','3'格式的字符串
        /// </summary>
        /// <param name="o">要分隔的对象</param>
        /// <param name="separator">分隔符</param>
        /// <returns></returns>
        public static string ToStringSplit(this object o, char separator = ',')
        {
            if (o.ToString().IsNullOrEmpty())
            {
                return "";
            }
            var obj = "";
            var objs = o.ToString().Split(separator);
            if (objs != null && objs.Length > 0)
            {
                for (var i = 0; i < objs.Length; i++)
                {
                    obj += "'" + objs[i] + "',";
                }
                obj = obj.Substring(0, obj.Length - 1);
            }
            return obj;
        }

        /// <summary>
        /// 对象转换为Long类型
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static long ToLong(this object o)
        {
            if (o == null) return 0;
            long.TryParse(o.ToString(), out var reValue);
            return reValue;
        }


        /// <summary>
        /// 对象转换为decimal类型
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this object o)
        {
            if (o == null) return 0;
            decimal.TryParse(o.ToString(), out var reValue);
            return reValue;
        }

        /// <summary>
        /// 对象转换为bool类型
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static bool ToBoolean(this object o)
        {
            if (o == null) return false;
            var str = o.ToString().Trim().ToLower();
            if (str == "0" || str == "false" || str == string.Empty) return false;
            return true;
        }

        /// <summary>
        /// 对象转换为bool类型
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this object o)
        {
            if (o == null) return DateTime.MinValue;
            o = o.ToString().Trim();
            if (DateTime.TryParse(o.ToString(), out var reValue))
                return reValue;
            else
                return DateTime.MinValue;
        }

        /// <summary>
        /// 金额千位符123,856,也可保留小数位：123,856.00
        /// </summary>
        /// <param name="o">要转换的字符对象</param>
        /// <param name="isAlwaysRetainDecimal">是否总是保留小数，默认为true</param>
        /// <returns></returns>
        public static string DecimalFormat(this object o, bool isAlwaysRetainDecimal = true)
        {
            var i = o.ToDecimal();
            return isAlwaysRetainDecimal ? i.ToString("N") : i.ToString("N0");
        }

        public static T parse<T>(this string jsonString)
        {
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            {
                return (T)new DataContractJsonSerializer(typeof(T)).ReadObject(ms);
            }
        }

        public static string FileSizeFormat(this object objStr)
        {
            var ks = objStr.ToDecimal() / 1024;
            var unit = "kb";
            if (ks >= 1024)
            {
                ks = ks / 1024;
                unit = "mb";
            }
            if (ks >= 1024)
            {
                ks = ks / 1024;
                unit = "gb";
            }
            return Math.Round(ks, 2) + unit;
        }

        /// <summary>
        /// 对象序列化为json
        /// </summary>
        /// <param name="jsonObject"></param>
        /// <returns></returns>
        public static string ToJsonString(this object jsonObject)
        {
            using (var ms = new MemoryStream())
            {
                new DataContractJsonSerializer(jsonObject.GetType()).WriteObject(ms, jsonObject);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }


        /// <summary>
        /// bool类型转小写的true/false字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToLowerString(this bool obj)
        {
            return obj.ToString().ToLower();
        }

        /// <summary>
        /// 时间转化为英语文化格式
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="hasHours">是否有时和分</param>
        /// <returns></returns>
        public static string DateTimeToEnString(this object dateTime, bool hasHours = true)
        {
            var dt = dateTime.ToDateTime();
            return dt.ToString(hasHours ? "dd/MMM/yy HH:MM" : "dd/MMM/yy", new CultureInfo("en"));
        }

        public static string RestoreQuotes(this object obj)
        {
            return obj.ToString().Replace("\\\'", "'").Replace("\\\"", "\"");
        }

        /// <summary>
        /// 将集合转换成逗号分隔的字符串
        /// </summary>
        /// <param name="objList">对象集合</param>
        /// <returns></returns>
        public static string ToStringArray(this IEnumerable<long> objList)
        {
            if (objList == null || !objList.Any()) return string.Empty;
            return string.Join(",", objList);
        }

        /// <summary>
        /// 将集合转换成逗号分隔的字符串，如果objList为空，则返回0
        /// </summary>
        /// <param name="objList">对象集合</param>
        /// <returns></returns>
        public static string ToStringArrayOrZero(this IEnumerable<long> objList)
        {
            if (objList == null || !objList.Any()) return "0";
            return string.Join(",", objList);
        }

        /// <summary>
        /// 将集合转换成逗号分隔的字符串
        /// </summary>
        /// <param name="objList">对象集合</param>
        /// <param name="addApostrophe">是否添加单引号，默认为true</param>
        /// <returns></returns>
        public static string ToStringArray(this IEnumerable<string> objList, bool addApostrophe = true)
        {
            if (objList == null || !objList.Any()) return string.Empty;
            var sb = new StringBuilder();
            foreach (var obj in objList)
            {
                if (sb.Length > 0) sb.Append(",");
                sb.AppendFormat(addApostrophe ? "'{0}'" : "{0}", obj.Trim());
            }
            return sb.ToString();
        }
        /// <summary>
        /// 将http协议中的参数进行编码
        /// </summary>
        /// <param name="str"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string UrlEncode(this string str, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            return HttpUtility.UrlEncode(str, encoding);
        }
        /// <summary>
        /// 将http协议中的参数进行解码
        /// </summary>
        /// <param name="str"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string UrlDecode(this string str, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            return HttpUtility.UrlDecode(str, encoding);
        }
        /// <summary>
        /// 将前几个的集合数据转换成斜线“/”分隔的字符串
        /// </summary>
        /// <param name="objList"></param>
        /// <param name="num">从0开始的第几个</param>
        /// <returns></returns>
        public static string ToStringByCharSplit(this IEnumerable<string> objList, int num)
        {
            if (objList == null || !objList.Any()) return string.Empty;
            var sb = new StringBuilder();
            for (var i = 0; i <= num; i++)
            {
                if (sb.Length > 0) sb.Append("/");
                sb.AppendFormat("{0}", objList.ElementAt(i).Trim());
            }
            return sb.ToString();
        }

        /// <summary>
        /// 将特定符号分隔的数字字符串转换成集合
        /// </summary>
        /// <param name="str">分隔的字符串</param>
        /// <param name="sepChar">分隔符，默认为逗号</param>
        /// <returns></returns>
        public static List<long> ToListNum(this string str, char sepChar = ',')
        {
            var list = new List<long>();
            if (str.IsNullOrEmpty()) return list;
            foreach (var obj in str.Split(sepChar))
            {
                if (obj.IsNullOrEmpty()) continue;
                list.Add(obj.ToLong());
            }
            return list;
        }


        /// <summary>
        /// 将逗号分隔的字符串转换成字符串集合
        /// </summary>
        /// <param name="str">逗号分隔的字符串</param>
        /// <returns></returns>
        public static List<string> ToStringList(this string str)
        {
            var list = new List<string>();
            if (str.IsNullOrEmpty()) return list;
            list.AddRange(str.Split(','));
            return list;
        }


        /// <summary>
        /// 给用逗号分隔的字符串集合添加单引号
        /// </summary>
        /// <param name="stringList">逗号分隔的字符串集合</param>
        /// <returns></returns>
        public static string addApostrophetoStringList(this string stringList)
        {
            if (stringList.IsNullOrEmpty()) return string.Empty;
            var arr = stringList.Split(',');
            var sb = new StringBuilder();
            for (var i = 0; i < arr.Length; i++)
            {
                var s = arr[i].Trim();
                if (s.IsNullOrEmpty()) continue;
                if (i > 0) sb.Append(",");
                if (s.StartsWith("'")) { sb.Append(s); }
                else { sb.AppendFormat("'{0}'", s); };
            }
            return sb.ToString();
        }


        /// <summary>
        /// 时间转化为数据库可用的格式
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="hasHours"></param>
        /// <returns></returns>
        public static string DateTimeToDatabaseString(this object dateTime)
        {
            if (dateTime == null) return string.Empty;
            var hasHours = true;
            var time = dateTime.ToString().Trim().Split(' ');
            if (time.Length == 1) hasHours = false;
            var arr = time[0].Split('/');
            if (arr.Length != 3) return string.Empty;
            var month = "";
            switch (arr[1])
            {
                case "January":
                case "Jan":
                    month = "01";
                    break;
                case "February":
                case "Feb":
                    month = "02";
                    break;
                case "March":
                case "Mar":
                    month = "03";
                    break;
                case "April":
                case "Apr":
                    month = "04";
                    break;
                case "May":
                    month = "05";
                    break;
                case "June":
                case "Jun":
                    month = "06";
                    break;
                case "July":
                case "Jul":
                    month = "07";
                    break;
                case "August":
                case "Aug":
                    month = "08";
                    break;
                case "September":
                case "Sep":
                    month = "09";
                    break;
                case "October":
                case "Oct":
                    month = "10";
                    break;
                case "November":
                case "Nov":
                    month = "11";
                    break;
                case "December":
                case "Dec":
                    month = "12";
                    break;
                default:
                    month = arr[1];
                    break;

            }
            var str = new StringBuilder();
            str.AppendFormat("{0}/{1}/{2}", arr[2], month, arr[0]);
            if (hasHours)
            {
                var hours = time[1].Split(':');
                if (hours.Length == 2)
                {
                    str.AppendFormat(" {0}:{1}:00", hours[0], hours[1]);
                }
                else if (hours.Length == 3)
                {
                    str.AppendFormat(" {0}:{1}:{2}", hours[0], hours[1], hours[2]);
                }
            }
            else
            {
                str.Append(" 00:00:00");
            }
            return str.ToString();
        }

        /// <summary>
        /// OA返回的字符串结果转换成字典集合
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Dictionary<string, string> OaResultToDictionary(this string s)
        {
            s = s.TrimStart('{').TrimEnd('}');

            return s.Split(',').Select(result => result.Split('=')).ToDictionary(arr => arr[0], arr => arr[1]);
        }

        /// <summary>
        /// 该对象是否与字符串相等
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsEqualString(this object obj, string s)
        {
            if (obj == null || obj.ToString().IsNullOrEmpty())
            {
                return s.IsNullOrEmpty();
            }
            if (s.IsNullOrEmpty()) return false;
            return obj.ToString().Trim() == s.Trim();
        }


    }
}