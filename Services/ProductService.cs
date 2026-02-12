using ProductGallery.Models;

namespace ProductGallery.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product 
                { 
                    Id = 1, 
                    Name = "Smartphone X", 
                    Price = 999.99m, 
                    ImageUrl = "https://placehold.co/300x200?text=Smartphone+X",
                    Description = "O mais recente Smartphone X com recursos avançados de câmera, tela impressionante e bateria para o dia todo."
                },
                new Product 
                { 
                    Id = 2, 
                    Name = "Notebook Pro", 
                    Price = 1999.99m, 
                    ImageUrl = "https://placehold.co/300x200?text=Notebook+Pro",
                    Description = "Notebook Pro de alto desempenho projetado para profissionais. Possui um processador poderoso e design elegante."
                },
                new Product 
                { 
                    Id = 3, 
                    Name = "Fones de Ouvido Sem Fio", 
                    Price = 149.99m, 
                    ImageUrl = "https://placehold.co/300x200?text=Fones",
                    Description = "Fones de ouvido totalmente sem fio com cancelamento de ruído e qualidade de som imersiva."
                },
                new Product 
                { 
                    Id = 4, 
                    Name = "Relógio Inteligente", 
                    Price = 299.99m, 
                    ImageUrl = "https://placehold.co/300x200?text=Relógio",
                    Description = "Mantenha-se conectado e monitore sua saúde com o novo Relógio Inteligente. Inclui monitoramento de frequência cardíaca e GPS."
                },
                new Product 
                { 
                    Id = 5, 
                    Name = "Monitor Gamer", 
                    Price = 499.99m, 
                    ImageUrl = "https://placehold.co/300x200?text=Monitor",
                    Description = "Monitor Gamer de 27 polegadas com taxa de atualização de 144Hz e tempo de resposta de 1ms para jogos fluidos."
                },
                new Product 
                { 
                    Id = 6, 
                    Name = "Teclado Mecânico", 
                    Price = 129.99m, 
                    ImageUrl = "https://placehold.co/300x200?text=Teclado",
                    Description = "Teclado Mecânico RGB com switches personalizados para a melhor experiência de digitação e jogos."
                },
                new Product 
                { 
                    Id = 7, 
                    Name = "SSD Externo 1TB", 
                    Price = 89.99m, 
                    ImageUrl = "https://placehold.co/300x200?text=SSD+1TB",
                    Description = "SSD Externo de 1TB rápido e portátil. Perfeito para fazer backup de seus arquivos e levá-los com você."
                },
                new Product 
                { 
                    Id = 8, 
                    Name = "Mesa Digitalizadora", 
                    Price = 249.50m, 
                    ImageUrl = "https://placehold.co/300x200?text=Tablet",
                    Description = "Mesa Digitalizadora profissional para artistas digitais. Inclui caneta sensível à pressão."
                }
            };
        }
    }
}
