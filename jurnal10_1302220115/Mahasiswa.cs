namespace jurnal10_1302220115
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string nim { get; set; }
        public List<string> Course { get; set; }  
        
        public int Year { get; set; }  
        
        public Mahasiswa(String nama, String nim,List<String>Course, int Year) {
            this.Nama = nama;
            this.nim = nim;
            this.Course = Course;
            this.Year = Year;
        }  
    }
}
