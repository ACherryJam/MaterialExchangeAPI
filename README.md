# Material Exchange API
API для биржи материалов на ASP.NET Core

## Установка
1. Клонируйте репозиторий `https://github.com/ACherryJam/MaterialExchangeAPI.git`
2. Создайте базы данных `materialExchange` и `hangfire`, при необходимости измените строки подключения в `appsettings.json`
3. Обновите миграции:
    - `dotnet ef database update` для .NET Core
    - `Update-Database` для Visual Studio
4. Запустите приложение
    - `dotnet run` для .NET Core
    - `Debug > Start Debugging/Run Without Debugging` для Visual Studio

## API
### Материал
- `GET /api/materials` - получение списка материалов
- `GET /api/materials/{id}` - получение материала по ID
- `POST /api/materials` - создание материала
- `PUT /api/materials/{id}` - изменение данных о материале
- `DELETE /api/materials/{id}` - удаление материала

### Продавец
- `GET /api/sellers` - получение списка продавцов
- `GET /api/sellers/{id}` - получение продавца по ID
- `POST /api/sellers` - создание продавца
- `PUT /api/sellers/{id}` - изменение данных о продавце
- `DELETE /api/sellers/{id}` - удаление продавца