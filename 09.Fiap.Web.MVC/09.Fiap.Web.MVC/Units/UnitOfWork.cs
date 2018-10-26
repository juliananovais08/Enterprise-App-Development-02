using _09.Fiap.Web.MVC.Persistencia;
using _09.Fiap.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _09.Fiap.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    //IDisposable - esta implementando uma interface que vai liberar a conexão com o banco
    {
        private GameContext _context = new GameContext();

        private IJogoRepository _jogoRepository;
        private IGeneroRepository _generoRepository;


        public IJogoRepository JogoRepository
        {
            get
            {
                if(_jogoRepository == null)
                {
                    _jogoRepository = new JogoRepository(_context);
                }
                return _jogoRepository;                    
            }
        }

        public IGeneroRepository GeneroRepository
        {
            get
            {
                if (_jogoRepository == null)
                {
                    _generoRepository = new GeneroRepository(_context);
                }
                return _generoRepository;
            }
        }



        //Libera conexão com o banco
        public void Dispose()
        {
            _context.SaveChanges();
        }

        //COMMITAR
        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}