using AppInventario.Contexto;
using AppInventario.Models;

namespace AppInventario.Services
{
    public class PropriedadeService
    {
        private readonly ContextoBD _contex;

        public PropriedadeService(ContextoBD con) { _contex = con; }

        public async Task Add(List<Propriedade> bens)
        {
            if(bens != null)
            {
                await _contex.Propriedades.AddRangeAsync(bens);
            }
        }

        public async Task Add(Propriedade bens)
        {
            if(bens != null)
            {
                await _contex.Propriedades.AddAsync(bens);
            }
        }

        public async Task Salvar()
        {
            await _contex.SaveChangesAsync();
        }
    }
}
