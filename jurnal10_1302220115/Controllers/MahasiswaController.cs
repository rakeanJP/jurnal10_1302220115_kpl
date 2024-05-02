using Microsoft.AspNetCore.Mvc;

namespace jurnal10_1302220115.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MahasiswaController : Controller
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Rakean Ganteng","1302220115",["KPL","PBO","Basis Data"],2022),
            new Mahasiswa("Jati Permana","1302220115",["KPL","PBO","Basis Data"],2022),
            new Mahasiswa("Akbar Ganteng","1302220115",["KPL","PBO","Basis Data"],2022),
            new Mahasiswa("kiki koko","1302220115",["KPL","PBO","Basis Data"],2022),
            new Mahasiswa("Kezia Zahara","1302220115",["KPL","PBO","Basis Data"],2023),
            new Mahasiswa("Zahra tiada dua","1302220115",["KPL","PBO","Basis Data"],2022)

        };
        [HttpGet]
        public IEnumerable <Mahasiswa>Get()
        {
            return dataMahasiswa;
        }
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }
        [HttpPost]
        public void Post(Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
