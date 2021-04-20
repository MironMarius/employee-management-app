using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta
{
    public class PaginiListaAngajati<T> : List<T>
    {
        public int PaginaIndex { get; private set; }
        public int TotalPagini { get; private set; }

        public PaginiListaAngajati(List<T> items, int numar, int paginaIndex, int paginaSize)
        {
            PaginaIndex = paginaIndex;
            TotalPagini = (int)Math.Ceiling(numar / (double)paginaSize);
            this.AddRange(items);

        }
        //Activeaza / dezactiveaza butonul de pagina anterioara
        public bool ExistaPaginaAnterioara => PaginaIndex > 1;
        public bool ExistaPaginaUrmatoare => PaginaIndex < TotalPagini;

        public static PaginiListaAngajati<T> Create(IList<T> sursa, int paginaIndex, int paginaSize)
        {
            var numar = sursa.Count();
            var items = sursa.Skip((paginaIndex - 1) * paginaSize).Take(paginaSize).ToList();
            return new PaginiListaAngajati<T>(items, numar, paginaIndex, paginaSize);

        }
    }
}
