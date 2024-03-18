using System.ComponentModel.DataAnnotations;

namespace GestaoDeLaboratorios.Models
{
    public class Computador
    {
        [Key]
        private int id;
        private string marca;
        private string processador;
        private string placaMae;
        private string memoria;
        private string hd;
        private int numeroPatrimonio;
        private DateTime dataCompra;

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Processador { get => processador; set => processador = value; }
        public string PlacaMae { get => placaMae; set => placaMae = value; }
        public string Memoria { get => memoria; set => memoria = value; }
        public string Hd { get => hd; set => hd = value; }
        public int NumeroPatrimonio { get => numeroPatrimonio; set => numeroPatrimonio = value; }
        public DateTime DataCompra { get => dataCompra; set => dataCompra = value; }
    }
}
