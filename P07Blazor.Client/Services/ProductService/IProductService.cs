﻿using P05Sklep.Shared;

namespace P07Blazor.Client.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceReponse<Product[]>> GetProducts();
    }
}
