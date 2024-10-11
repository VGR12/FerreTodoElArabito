using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Lib.Data.Dal
{
    public class FerreTodoDal : IDisposable
    {
        private Database.FerreTodosContext dbContext;

        public FerreTodoDal()
        {
            
        }

        public Database.FerreTodosContext Dbcontext
        {
            get
            {
                dbContext ??= new();
                return dbContext;
            }
            set => dbContext = value;
        }

        //Agregar metodos *****************************



        //*********************************************
        #region dispose 
        private bool disposedValue;


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    dbContext.Dispose();    
                }

                disposedValue = true;
            }
        }
        #endregion
    }
}
