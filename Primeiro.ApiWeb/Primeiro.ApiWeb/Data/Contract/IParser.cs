using System.Collections.Generic;

namespace Primeiro.ApiWeb.Data.Contract
{
    public interface IParser<O, D> // Dois tipos, Origem e Distino genéricos
    {
        D Parse(O origem);
        List<D> Parse(List<O> origem);
    }
}
