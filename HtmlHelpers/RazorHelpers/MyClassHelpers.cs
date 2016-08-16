using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.RazorHelpers
{
    public static class MyClassHelpers
    {
        /// <summary>
        /// Custom Html Helper using Static Methods
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static HtmlString RegularModal(string name)
        {
            return new HtmlString("<div class=\"modal fade\" id=\"myModal\" tabindex=\"-1\" role=\"dialog\" data-backdrop=\"static\" data-show=\"true\" data-keyboard=\"false\" aria-labelledby=\"myModalLabel\">" +
                "<div class=\"modal-dialog\" role=\"document\">" +
                    "<div class=\"modal-content\">" +
                        "<div class=\"modal-header\">" +
                            "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>" +
                            "<div class=\"modal-title text-center\" id=\"myModalLabel\"><i class=\"glyphicon glyphicon-heart\"></i><br /> " + name + "</div>" +
                        "</div>" +
                        "<div class=\"modal-body\">" +
                        name +
                        "</div>" +
                        "<div class=\"modal-footer\">" +
                            "<button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>" +
                        "</div>" +
                    "</div>" +
                "</div>" +
            "</div>");
        }

        /// <summary>
        /// Extension Method
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="src"></param>
        /// <param name="alt"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static MvcHtmlString CustomImage(this HtmlHelper htmlHelper, string src, string alt, int width, int height)
        {
            var imageTag = new TagBuilder("image");
            imageTag.MergeAttribute("src", src);
            imageTag.MergeAttribute("alt", alt);
            imageTag.MergeAttribute("width", width.ToString());
            imageTag.MergeAttribute("height", height.ToString());

            return MvcHtmlString.Create(imageTag.ToString(TagRenderMode.SelfClosing));
        }

    }
}