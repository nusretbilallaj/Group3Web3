namespace Group3Web3.Models
{
    public class Studenti
    {
  
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

        public Studenti(string emri, string mbiemri)
        {
            Emri = emri;
            Mbiemri = mbiemri;
        }
    }
}
