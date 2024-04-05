using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelpers.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("view-ctx")]
    public class ViewContextTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; } = default!;
        public string? MiscString { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            bool isHttps = ViewContext.HttpContext.Request.IsHttps;
            MiscString = ViewContext.ExecutingFilePath;

            output.Content.SetContent($"IsHttps: {isHttps}");
            output.Content.SetContent($"ExecutingFilePath: {MiscString}");
        }
    }
}
