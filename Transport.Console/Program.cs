using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Transport.Infrastructure;
using Transport.Infrastructure.Repositories;
using Transport.Infrastructure.Services;
using Transport.Infrastructure.Models;

var services = new ServiceCollection();

// добавь строку подключения
services.AddDbContext<TransportContext>(options =>
    options.UseSqlite("Data Source=transport.db"));

// регистрируем зависимости
services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
services.AddScoped(typeof(ICrudServiceAsync<>), typeof(CrudServiceAsync<>));

// создаем провайдер
var provider = services.BuildServiceProvider();

// пример использования:
var busService = provider.GetRequiredService<ICrudServiceAsync<BusModel>>();
// await busService.CreateAsync(...);
