namespace ZabbixApi.Common
{
    public class CommonGet
    {
        /// <summary>
        /// Return the number of records in the result instead of the actual data.
        /// </summary>
        public string countOutput;

        /// <summary>
        /// If set to true return only objects that the user has write permissions to. Default: false.
        /// </summary>
        public bool? editable;

        /// <summary>
        /// Return results that do not match the criteria given in the search parameter.
        /// </summary>
        public string excludeSearch;

        /// <summary>
        /// Return only those results that exactly match the given filter. 
        /// Accepts an array, where the keys are property names, and the values are either a single value or an array of values to match against.
        /// Doesn't work for text fields.
        /// </summary>
        public object filter;

        /// <summary>
        /// Limit the number of records returned.
        /// </summary>
        public int? limit;

        /// <summary>
        /// Returns objects that belong to the given nodes.
        /// </summary>
        public string[] nodeids;

        /// <summary>
        /// Object properties to be returned.
        /// </summary>
        public string output = "extend";

        /// <summary>
        /// Use IDs as keys in the resulting array.
        /// </summary>
        public string preservekeys;

        /// <summary>
        /// Return results that match the given wildcard search. Accepts an array, where the keys are property names, and the values are strings to search for.
        /// If no additional options are given, this will perform a LIKE ”%…%” search. Works only for string and text fields.
        /// </summary>
        public object search;

        /// <summary>
        /// If set to true return results that match any of the criteria given in the filter or search parameter instead of all of them. Default: false.
        /// </summary>
        public bool? searchByAny;

        /// <summary>
        /// If set to true enables the use of “*” as a wildcard character in the search parameter. Default: false.
        /// </summary>
        public bool? searchWildcardsEnabled;

        /// <summary>
        /// Sort the result by the given properties. Refer to a specific API get method description for a list of properties that can be used for sorting.
        /// </summary>
        public string[] sortfield;

        /// <summary>
        /// Order of sorting. If an array is passed, each value will be matched to the corresponding property given in the sortfield parameter.
        /// Possible values are: ASC - ascending; DESC - descending.
        /// </summary>
        public string[] sortorder;

        /// <summary>
        /// The search parameter will compare the beginning of fields, that is, perform a LIKE “…%” search instead.
        /// </summary>
        public string startSearch;
    }
}