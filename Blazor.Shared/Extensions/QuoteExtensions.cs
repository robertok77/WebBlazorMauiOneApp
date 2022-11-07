using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Blazor.Shared.Data;

namespace Blazor.Shared.Extensions;

public static class QuoteExtensions
{
    public static Quote Decode(this QuoteRow row) =>
        new(HttpUtility.HtmlDecode(row.title.rendered), HttpUtility.HtmlDecode(row.yoast_head_json.og_description));
}