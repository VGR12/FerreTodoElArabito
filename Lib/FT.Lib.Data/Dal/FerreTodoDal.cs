using FT.Lib.Data.Database.FerreTodo;
using FT.Lib.Data.Models.Filtro;
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

        public async Task<string> ObtenerProducto(Guid? token)
        {

            return null;
        }

        public async Task<IQueryable<Producto>> FiltrarProducto(FiltroInventario? filtro)
        {
            var retorno = Dbcontext.Producto.Where(t => t.Estado);

            if (!string.IsNullOrEmpty(filtro.Nombre))
            {
                //retorno= retorno.Where(t=>t.)
            }
            else if (!string.IsNullOrEmpty(filtro.Codigo))
            {
                retorno = retorno.Where(t => t.Codigo.Contains(filtro.Codigo));
            }
            //else if ()
            //{

            //}

            return retorno;
        }

        public async Task<PagedList.PagedList<ElementoInvModel>> ObtenerInventario(FiltroInventario? filtro)
        {
            var resultados = await FiltrarProducto(filtro);





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
