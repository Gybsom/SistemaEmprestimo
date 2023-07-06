namespace SistemaEmprestimo.Models
{
    public class EmprestimoModel
    {
        public int Id { get; set; }
        public string Recebedor { get; set; }
        public float ValorEmprestado { get; set; }
        public float TaxaJuros { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;
    }
}
