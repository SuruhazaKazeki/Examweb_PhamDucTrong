using Examweb_PhamDucTrong.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examweb_PhamDucTrong.Controllers
{
    public class MusicController : Controller
    {
        private readonly AppDbContext _db;
        public MusicController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var list = _db.DiaNhacs.ToList();
            return View(list);        
        }
        // Giao diện thêm đĩa nhạc
        public IActionResult Add()
        {
            return View();
        }

        // Xử lý thêm
        [HttpPost]
        public IActionResult Add(DiaNhac dia)
        {
            if (ModelState.IsValid)
            {
                _db.DiaNhacs.Add(dia);
                _db.SaveChanges();
                TempData["success"] = "Thêm thành công";
                return RedirectToAction("Index");
            }
            return View(dia);
        }
        // Giao diện sửa
        public IActionResult Update(int id)
        {
            var dia = _db.DiaNhacs.Find(id);
            if (dia == null)
                return NotFound();
            return View(dia);
        }

        // Xử lý sửa
        [HttpPost]
        public IActionResult Update(DiaNhac dia)
        {
            if (ModelState.IsValid)
            {
                var exist = _db.DiaNhacs.Find(dia.Id);
                if (exist == null) return NotFound();

                exist.TuaCD = dia.TuaCD  ;
                exist.NgheSi = dia.NgheSi;
                exist.TrongNuoc = dia.TrongNuoc;
                exist.GiaBan = dia.GiaBan;
                exist.SoLuong = dia.SoLuong;

                _db.SaveChanges();
                TempData["success"] = "Cập nhật thành công";
                return RedirectToAction("Index");
            }
            return View(dia);
        }
        // Giao diện xác nhận xóa
        public IActionResult Delete(int id)
        {
            var dia = _db.DiaNhacs.Find(id);
            if (dia == null)
                return NotFound();
            return View(dia);
        }

        // Xử lý xóa
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var dia = _db.DiaNhacs.Find(id);
            if (dia == null) return NotFound();

            _db.DiaNhacs.Remove(dia);
            _db.SaveChanges();
            TempData["success"] = "Đã xóa đĩa nhạc";
            return RedirectToAction("Index");
        }
    }
}
