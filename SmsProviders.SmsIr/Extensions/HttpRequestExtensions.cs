﻿using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using SmsProviders.SmsIr.Exceptions;
using SmsProviders.SmsIr.Models.Results;

namespace SmsProviders.SmsIr.Extensions;

internal static class HttpRequestExtensions
{
    internal static async Task<SmsIrResult<TResult>> GetRequestAsync<TResult>(this HttpClient httpClient, string requestUri)
    {
        HttpResponseMessage response = await httpClient.GetAsync(requestUri);

        if (!response.IsSuccessStatusCode)
            await HandleUnsuccessfulResponse(response);

        return await response.Content.ReadFromJsonAsync<SmsIrResult<TResult>>();
    }

    internal static async Task<SmsIrResult<TResult>> PostRequestAsync<TResult>(this HttpClient httpClient, string requestUri, object data)
    {
        string payload = JsonSerializer.Serialize(data);

        StringContent httpContent = new(payload, Encoding.UTF8, MediaTypeNames.Application.Json);

        HttpResponseMessage response = await httpClient.PostAsync(requestUri, httpContent);

        if (!response.IsSuccessStatusCode)
            await HandleUnsuccessfulResponse(response);

        return await response.Content.ReadFromJsonAsync<SmsIrResult<TResult>>();
    }

    internal static async Task<SmsIrResult<TResult>> DeleteRequestAsync<TResult>(this HttpClient httpClient, string requestUri)
    {
        HttpResponseMessage response = await httpClient.DeleteAsync(requestUri);

        if (!response.IsSuccessStatusCode)
            await HandleUnsuccessfulResponse(response);

        return await response.Content.ReadFromJsonAsync<SmsIrResult<TResult>>();
    }

    private static async Task HandleUnsuccessfulResponse(HttpResponseMessage response)
    {
        SmsIrResult baseResponse = await response.Content.ReadFromJsonAsync<SmsIrResult>();
        int statusCode = (int)response.StatusCode;

        throw statusCode switch
        {
            401 => new UnauthorizedException(baseResponse.Status, baseResponse.Message),
            400 => new LogicalException(baseResponse.Status, baseResponse.Message),
            429 => new TooManyRequestException(baseResponse.Status, baseResponse.Message),
            500 => new UnexpectedException(baseResponse.Status, baseResponse.Message),
            _ => new InvalidOperationException(
                $"something went wrong, httpStatus code: {response.StatusCode}, message: {response.RequestMessage}, please contact support team.")
        };
    }
}