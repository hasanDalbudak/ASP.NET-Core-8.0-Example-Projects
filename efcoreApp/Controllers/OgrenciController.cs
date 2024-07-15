using efcoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Controllers
{
    public class OgrenciController: Controller
    {

        private readonly DataContext _context;

        public OgrenciController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            var ogrenciler = await _context.Ogrenciler.ToListAsync();
            return View(ogrenciler);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Ogrenci model)
        {
            _context.Ogrenciler.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound(); //404 Durum kodu response döndürür. Başka bir şablon da oluşturulabilir.
            }

            var ogr = await _context
                            .Ogrenciler
                            .Include(o => o.KursKayitlari)
                            .ThenInclude(o => o.Kurs)
                            .FirstOrDefaultAsync(o => o.OgrenciId == id);
                            // var ogr = await _context.Ogrenciler.FirstOrDefaultAsync(o => o.OgrenciId == id);

            if(ogr == null)
            {
                return NotFound();
            }

            return View(ogr);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // data açığı için önemli, kullanıcı token,'nin integrity'si için //Formu yükleyen kişi ile güncelleyen kişi aynı mı diye kontrol ettiğimiz token.
        public async Task<IActionResult> Edit(int id, Ogrenci model)
        {
            if(id != model.OgrenciId)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if(!_context.Ogrenciler.Any(o => o.OgrenciId == model.OgrenciId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var ogrenci = await _context.Ogrenciler.FindAsync(id);

            if(ogrenci == null)
            {
                return NotFound();
            }

            return View(ogrenci);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm]int id)
        {
            var ogrenci = await _context.Ogrenciler.FindAsync(id);
            if(ogrenci == null)
            {
                return NotFound();
            }
            _context.Ogrenciler.Remove(ogrenci);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}