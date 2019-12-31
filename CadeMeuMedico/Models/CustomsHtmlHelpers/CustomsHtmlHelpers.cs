using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Models.CustomsHtmlHelpers
{
    public static class CustomsHtmlHelpers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="id">id of the component to be manipulated, for example, by javascript</param>
        /// <param name="name">a string that names this component</param>
        /// <param name="value">string showed for the user</param>
        /// <returns></returns>
        public static MvcHtmlString CustomButton(this HtmlHelper helper, string id, string name, string value)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"<input ");
            str.Append("type='button' ");
            str.Append($"id={id}' ");
            str.Append($"name='{name}' ");
            str.Append($"value='{value}' ");
            str.Append("/>");

            return MvcHtmlString.Create(str.ToString());
        }

        /// <summary>
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="id">id of the component to be manipulated, for example, by javascript</param>
        /// <param name="value">string showed for the user</param>
        /// <returns></returns>
        public static MvcHtmlString CustomButton(this HtmlHelper helper, string id, string value)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"<input ");
            str.Append("type='button' ");
            str.Append($"id={id}' ");
            str.Append($"value='{value}' ");
            str.Append("/>");

            return MvcHtmlString.Create(str.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="value">string showed for the user</param>
        /// <returns></returns>
        public static MvcHtmlString CustomButton(this HtmlHelper helper, string value)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"<input ");
            str.Append("type='button' ");
            str.Append($"value='{value}' ");
            str.Append("/>");

            return MvcHtmlString.Create(str.ToString());
        }
    }
}