namespace InterfacePreview.Models
{
    public class Ocorrencia
    {
        public long ID { get; set; }
        public long ID_Tipo { get; set; }
        public long ID_Transportador { get; set; }
        public DateTime OcorreuEm { get; set; }
        public DateTime? SolucaoEm { get; set; }
        public Tipo Tipo { get; set; }
        public Transportador Transportador { get; set; }
    }
}
