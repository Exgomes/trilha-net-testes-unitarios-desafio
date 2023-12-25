
namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }

        public IEnumerable<object> NaoDeveConterONumero10NaLista(List<int> lista, int numeroParaProcurar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> DeveMultiplicarOsElementosDaListaPor2(List<int> lista)
        {
            throw new NotImplementedException();
        }

        public string DeveRetornar9ComoMaiorNumeroDaLista(List<int> lista)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> DeveRetornarOitoNegativoComoMenorNumeroDaLista(List<int> lista)
        {
            throw new NotImplementedException();
        }
    }
}
