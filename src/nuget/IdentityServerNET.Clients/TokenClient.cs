﻿using IdentityModel.Client;
using IdentityServerNET.Extensions;
using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace IdentityServerNET.Clients;

public class TokenClient
{
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly X509Certificate2 _clientCertificate = null;
    private readonly HttpClient _httpClient;

    public TokenClient(string clientId, string clientSecret, HttpClient httpClient = null)
    {
        _clientId = clientId;
        _clientSecret = clientSecret;
        _httpClient = httpClient;
    }

    public TokenClient(string clientId, X509Certificate2 clientCertificate, HttpClient httpClient = null)
    {
        _clientId = clientId;
        _clientCertificate = clientCertificate;
        _httpClient = httpClient;
    }

    public string AccessToken { get; private set; }

    // reuse http client
    private HttpClient _defaultHttpClient = null;
    protected HttpClient GetHttpClient()
    {
        if (_httpClient is not null)
        {
            return _httpClient;
        }

        if (_defaultHttpClient is null)
        {
            _defaultHttpClient = new HttpClient();
        }

        return _defaultHttpClient;
    }

    async public Task GetAccessToken(string identityServerAddress, string[] scopes)
    {
        var httpClient = GetHttpClient();
        var disco = await httpClient.GetDiscoveryDocumentAsync(identityServerAddress);

        if (disco.IsError)
        {
            throw new Exception(disco.Error);
        }

        TokenResponse tokenResponse;
        if (_clientCertificate != null)
        {
            var clientAssertion = new ClientAssertion()
            {
                Type = "urn:ietf:params:oauth:client-assertion-type:jwt-bearer",
                Value = _clientCertificate.ToAssertionToken(_clientId, identityServerAddress).ToTokenString()
            };

            tokenResponse = await httpClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,

                ClientId = _clientId,
                ClientAssertion = clientAssertion,

                Scope = String.Join(" ", scopes)
            });
        }
        else
        {
            tokenResponse = await httpClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,

                ClientId = _clientId,
                ClientSecret = _clientSecret,

                Scope = String.Join(" ", scopes)
            });
        }

        if (tokenResponse.IsError)
        {
            throw new Exception(tokenResponse.Error);
        }

        AccessToken = tokenResponse.AccessToken;
    }
}
