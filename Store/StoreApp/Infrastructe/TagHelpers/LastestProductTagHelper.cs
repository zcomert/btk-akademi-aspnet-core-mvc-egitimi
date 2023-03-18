using Microsoft.AspNetCore.Razor.TagHelpers;
using Services.Contracts;

namespace StoreApp.Infrastructe.TagHelpers
{
    public class LastestProductTagHelper : TagHelper
    {
        private readonly IServiceManager _manager;

        public LastestProductTagHelper(IServiceManager manager)
        {
            _manager = manager;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
        }
    }
}