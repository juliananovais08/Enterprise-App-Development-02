using _10.Fiap.Web.MVC.Persistencia;
using _10.Fiap.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _10.Fiap.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {

        private PassaporteContext _context = new PassaporteContext();

        private PessoaRepository _pessoaRepository;
        private PaisRepository _paisRepository;


        public IPaisRepository PaisRepository
        {
            get
            {
                if(_paisRepository == null)
                {
                    _paisRepository = new PaisRepository(_context);
                }

                return _paisRepository;
            }
           
        }

        public IPessoaRepository PessoaRepository
        {
            get
            {
                if(_pessoaRepository == null)
                {
                    _pessoaRepository = new PessoaRepository(_context);
                }
                return _pessoaRepository;
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}