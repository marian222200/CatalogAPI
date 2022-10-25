using Catalog.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.Repositories
{
    public class SqlExpressItemsRepository : IItemsRepository
    {
        private readonly DataContext _dataContext;

        public SqlExpressItemsRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task CreateItemAsync(Item item)
        {
            _dataContext.Items.Add(item);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteItemAsync(Guid id)
        {
            var item = await _dataContext.Items.FindAsync(id);
            _dataContext.Items.Remove(item);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Item> GetItemAsync(Guid id)
        {
            return await _dataContext.Items.FindAsync(id);
        }

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await _dataContext.Items.ToListAsync();
        }

        public async Task UpdateItemAsync(Item item)
        {
            var oldItem = await _dataContext.Items.FindAsync(item.Id);
            _dataContext.Items.Remove(oldItem);
            _dataContext.Items.Add(item);
            await _dataContext.SaveChangesAsync();
        }
    }
}
