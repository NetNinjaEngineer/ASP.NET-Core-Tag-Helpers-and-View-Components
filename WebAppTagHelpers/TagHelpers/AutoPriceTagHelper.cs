using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelpers.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("auto-price")]
    public class AutoPriceTagHelper : TagHelper
    {
        public string? Make { get; set; }

        [HtmlAttributeName("ModelName")]
        public string? Model { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {


        }
    }
}
