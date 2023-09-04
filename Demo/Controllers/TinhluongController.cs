using Microsoft.AspNetCore.Mvc;

namespace Demo.TinhluongController
{
    public class TinhluongController : Controller
    {
    [HttpPost]
    public IActionResult Tinhluong(string Luongcb, string heSo, string Phucap)
    {
        double cb =0, hs =0, pc =0, luong = 0;
        string trave;
        if(!String.IsNullOrEmpty(Luongcb)) cb = Convert.ToDouble(Luongcb);
        if(!String.IsNullOrEmpty(heSo)) hs = Convert.ToDouble(heSo);
        if(!String.IsNullOrEmpty(Phucap)) pc = Convert.ToDouble(Phucap);
        luong = cb*hs+pc;
        trave = "Lương của bạn hiện tại là: " + luong;
        ViewBag.tl = trave;
        return View();
    }
    }
}