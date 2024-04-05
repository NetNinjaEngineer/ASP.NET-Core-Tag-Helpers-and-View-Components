﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelpers.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("Company")]
    public class CompanyTagHelper : TagHelper
    {
        public string? Name { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string preContent = @"
                <div class='panel panel-default' style='padding: 20px'>
                    <div class='panel-heading' style='margin-bottom: 50px;'>
                        <img src='/images/{0}.png' height='20' >
                    </div>
            ";
            string postContent = @"
                </div>
            ";
            output.TagName = "div";
            output.PreContent.SetHtmlContent(
                string.Format(preContent, Name));
            output.PostContent.SetHtmlContent(postContent);
        }
    }
}
