using System;
using System.Globalization;
using Play.Catalog.Service.Entities;
// using Play.Catalog.Service.Models; // Add missing using directive for 'Item' type

namespace Play.Catalog.Service;

public static class Extensions
{
    public static ItemDto AsDto(this Item item)
    {
        return new ItemDto(item.Id, item.Name, item.Description, item.Price, item.CreatedDate);
    }
}
