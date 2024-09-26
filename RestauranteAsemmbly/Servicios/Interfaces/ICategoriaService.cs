using System.Collections.Generic;
using System.Threading.Tasks;
using RestauranteAsemmbly.Models;

namespace RestauranteAsemmbly.Servicios.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> ObtenerCategoriasAsync();         
        Task<Categoria> ObtenerCategoriaPorIdAsync(int id);     
        Task<Categoria> CrearCategoriaAsync(Categoria categoria);  
        Task<Categoria> ActualizarCategoriaAsync(Categoria categoria);      
        Task<Categoria> EliminarCategoriaAsync(int id);                     
    }
}
