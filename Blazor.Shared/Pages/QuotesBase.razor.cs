using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using Blazor.Shared.Contract;
using Blazor.Shared.Data;
using Blazor.Shared.Extensions;
using Microsoft.AspNetCore.Components;

namespace Blazor.Shared.Pages;

public partial class QuotesBase : ComponentBase
{
    [Inject] 
    private IQuotesApi QuotesApi { get; set; } = null!;

    [Parameter]
    public RenderFragment PageHeader { get; set; } = null!;

    private Quote[] _quotesList = Array.Empty<Quote>();

    private async Task Show() => _quotesList = (await QuotesApi.Get(RandomQuotes.Next)).Select(x => x.Decode()).ToArray();
}