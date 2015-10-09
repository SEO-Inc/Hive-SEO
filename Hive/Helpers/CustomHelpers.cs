using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hive.Helpers
{
    public static class ImageHelper
    {
          public static MvcHtmlString CustomImage(this HtmlHelper htmlHelper,
                                                                   string src, string alt, int width, int height)
          {       
                   var imageTag = new TagBuilder("image");
                   imageTag.MergeAttribute("src", src);
                   imageTag.MergeAttribute("alt", alt);
                   imageTag.MergeAttribute("width", width.ToString());
                   imageTag.MergeAttribute("height", height.ToString());                   
                   
                   return MvcHtmlString.Create(imageTag.ToString(TagRenderMode.SelfClosing));           
            }
     }

    public static class HtmlRequestHelper
    {
        public static string Id(this HtmlHelper htmlHelper)
        {
            var routeValues = HttpContext.Current.Request.RequestContext.RouteData.Values;

            if (routeValues.ContainsKey("id"))
                return (string)routeValues["id"];
            else if (HttpContext.Current.Request.QueryString.AllKeys.Contains("id"))
                return HttpContext.Current.Request.QueryString["id"];

            return string.Empty;
        }

        public static string Controller(this HtmlHelper htmlHelper)
        {
            var routeValues = HttpContext.Current.Request.RequestContext.RouteData.Values;

            if (routeValues.ContainsKey("controller"))
                return (string)routeValues["controller"];

            return string.Empty;
        }

        public static string Action(this HtmlHelper htmlHelper)
        {
            var routeValues = HttpContext.Current.Request.RequestContext.RouteData.Values;

            if (routeValues.ContainsKey("action"))
                return (string)routeValues["action"];

            return string.Empty;
        }
    }

    //public static class MenuLinkHelper
    //{
    //    public static MvcHtmlString MenuLink(this HtmlHelper htmlHelper,
    //                                                             string icon, string alt, int width, int height)
    //    {
    //        var imageTag = new TagBuilder("image");
    //        imageTag.MergeAttribute("src", src);
    //        imageTag.MergeAttribute("alt", alt);
    //        imageTag.MergeAttribute("width", width.ToString());
    //        imageTag.MergeAttribute("height", height.ToString());

    //        return MvcHtmlString.Create(imageTag.ToString(TagRenderMode.SelfClosing));
    //    }
    //}
}