﻿using Shop.Core.Providers;
using Shop.Core.Providers.Interfaces;
using Shop.DAL.Data.Entities;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Shop.UI.Clients.APICLIENTS
{
    public class AdvertApiClient
    {
        private readonly string baseUrl;
        private readonly IJwtTokenProvider _jwtTokenProvider;
        private readonly HttpClient _httpClient;
        private readonly HttpRequestMessage requestMessage;
        public AdvertApiClient(IJwtTokenProvider tokenProvider)
        {
            this.baseUrl = baseUrl;
            _jwtTokenProvider = tokenProvider;
            _httpClient = new HttpClient();
            requestMessage = new HttpRequestMessage();
        }
        public void Get(Guid id)
        {

        }

        public void GetAll()
        {
            
        }

        public void Take(int skip, int n)
        {
            
        }

        public async void Add(string userId)
        {
            string token = await _jwtTokenProvider.GenerateTokenAsync(userId);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Item item = new Item()
            {
                
                ItemName = "Test",
                Description = "Test",
                ItemPrice = 100,
                ImageUrl = "Test",
                OwnerID = new Guid("c9c9c9c9-c9c9-c9c9-c9c9-c9c9c9c9c9c9")
            };

            var response = await _httpClient.PostAsJsonAsync(new Uri("https://localhost:7102/" + "api/advert/create"), item);
        }

        public void Delete()
        {
            
        }

        public void Update()
        {
            
        }
    }
}
