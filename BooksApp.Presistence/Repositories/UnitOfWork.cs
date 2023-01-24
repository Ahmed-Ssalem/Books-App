using BooksApp.Core.Entities;
using BooksApp.Core.Interfaces;
using BooksApp.Core.Interfaces.Repositories;
using BooksApp.Presistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Presistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IGenericRepository<Book> Books { get; private set; }



        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Books = new GenericRepository<Book>(_context);
        }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
