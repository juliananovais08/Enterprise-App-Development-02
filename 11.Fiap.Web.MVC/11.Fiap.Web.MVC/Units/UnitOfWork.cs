using _11.Fiap.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11.Fiap.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private LocadoraContext _context = new LocadoraContext();

        private IGeneroRepository _generoRepository;
        private IFilmeRepository _filmeRepository;

        public IGeneroRepository GeneroRepository
        {
            get
            {
                if (_generoRepository == null)
                {
                    _generoRepository = new GeneroRepository(_context);
                }
                return _generoRepository;
            }
        }


        public IFilmeRepository FilmeRepository
        {
            get
            {
                if(_filmeRepository == null)
                {
                    _filmeRepository = new FilmeRepository(_context);
                }
                return _filmeRepository;
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }


        public void Dispose()
        { if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

    }
}