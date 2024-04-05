using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelpers.TagHelpers
{
    public class ModelTestTagHelper : TagHelper
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            output.Content.SetContent($"{FirstName} {LastName}");
        }
    }
}
