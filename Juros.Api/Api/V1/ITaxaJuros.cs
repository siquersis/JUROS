using Juros.Api;

namespace Juros.Api.Api.V1
{
    public interface ITaxaJuros : TaxaJurosController
    {
        double TaxaJuros();
    }
}