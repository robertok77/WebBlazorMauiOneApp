using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blazor.Shared.Data;
using Refit;

namespace Blazor.Shared.Contract;

internal interface IQuotesApi
{
    [Get("/wp-json/wp/v2/posts/?orderby=rand&_={randomQuotes.Number}")]
    Task<QuoteRow[]> Get(RandomQuotes randomQuotes);
}

public record RandomQuotes(long Number)
{
    public static RandomQuotes Next => new(new Random().NextInt64(DateTime.Now.Ticks));
}