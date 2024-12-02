// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

namespace AxxesMarket.Shared.Components;

public class AntiforgeryHandler : DelegatingHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("X-CSRF", "1");
        return base.SendAsync(request, cancellationToken);
    }
}