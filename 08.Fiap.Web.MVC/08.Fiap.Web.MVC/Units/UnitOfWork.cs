using _08.Fiap.Web.MVC.Persistencia;
using _08.Fiap.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _08.Fiap.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    //IDisposable - esta implementando uma interface que vai liberar a conexão com o banco
    {
        private EscolaContext _context = new EscolaContext();

        //propfull tab tab

        private IResponsavelRepository _responsavelRepository;

        public IResponsavelRepository ResponsavelRepository
        {
            get
            {
                if (_responsavelRepository == null)
                {
                    _responsavelRepository = new ResponsavelRepository(_context);
                }
                return _responsavelRepository;
            }

        }

        //Liberar a conexão com o Banco
        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        //COMMITAR
        public void Salvar()
        {
            _context.SaveChanges();
        }

    }
}