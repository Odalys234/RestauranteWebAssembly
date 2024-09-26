using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestauranteAsemmbly.Helpers;
using RestauranteAsemmbly.Models;
using RestauranteAsemmbly.Servicios.Interfaces;

namespace RestauranteAsemmbly.Servicios.Implementaciones
{
    public class CategoriaService : ICategoriaService
    {
        private readonly HttpClientHelper _httpClientHelper;

        public CategoriaService(HttpClientHelper httpClientHelper)
        {
            _httpClientHelper = httpClientHelper;
        }

        
        public async Task<Categoria> CrearCategoriaAsync(Categoria categoria)
        {
            return await _httpClientHelper.PostAsync("http://localhost:5183/api/Categoria", categoria);
        }

       
        public Task<List<Categoria>> ObtenerCategoriasAsync()
        {
            return  _httpClientHelper.GetTAsync<List<Categoria>>("http://localhost:5183/api/Categoria");
        }

        
        public async Task<Categoria> ObtenerCategoriaPorIdAsync(int id)
        {
            return await _httpClientHelper.GetTAsync<Categoria>($"http://localhost:5183/api/Categoria/{id}");
        }

       
        public async Task<Categoria> ActualizarCategoriaAsync(Categoria categoria)
        {
            return await _httpClientHelper.PutAsync($"http://localhost:5183/api/Categoria/{categoria.id}", categoria);
        }

        
        public async Task<Categoria> EliminarCategoriaAsync(int id)
        {
            return await _httpClientHelper.DeleteAsync<Categoria>($"http://localhost:5183/api/Categoria/{id}");
        }
    }
}
