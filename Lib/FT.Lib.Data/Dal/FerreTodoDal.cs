using FT.Lib.Data.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Lib.Data.Dal
{
    public class FerreTodoDal : IDisposable
    {

        public FerreTodoDal()
        {

        }

        private Database.FerreTodosContext dbContext;

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

        public async Task<PagedList.PagedList<ElementoInvModel>> ObtenerInventario()
        {
            

            return null;
        }
        public async Task<PagedList.PagedList<ElementoInvModel>> ObtenerCuentasPorCobrar()
        {


            return null;
        }
        public async Task<PagedList.PagedList<ElementoInvModel>> ObtenerCuentasPorPagar()
        {


            return null;
        }
        public async Task<PagedList.PagedList<ElementoInvModel>> ObtenerClientes()
        {


            return null;
        }
        public async Task<PagedList.PagedList<ElementoInvModel>> ObtenerProveedores()
        {


            return null;
        }

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
                    Dbcontext.Dispose();
                }

                disposedValue = true;
            }
        }
        #endregion
    }
}
