using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ZabbixApi.Helpers
{
    public static class EnumExtension
    {
        /// <summary>
        /// Позволяет получить строковое описание энума
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum val)
        {
            var attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

        /// <summary>
        /// Возвращает энум лист
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }

        /// <summary>
        /// Возвращает список дискрипшенов энума
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<string> GetEnumDescriptionList<T>()
        {
            return (from Enum e in Enum.GetValues(typeof(T)) select e.GetDescription()).ToList();
        }
    }
}