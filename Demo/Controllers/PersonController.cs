using System.Reflection.PortableExecutable;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PersonController
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Name)
        {
            ViewBag.thongbao= "Xin chào "+Name;
            return View();
        }
        public IActionResult Giaiptb2()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Giaiptb2(string hesoA, string hesoB, string hesoC)
    {
        double delta, x1, x2, a=0, b=0, c=0;
        string ketqua;
        if(!String.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
        if(!String.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
        if(!String.IsNullOrEmpty(hesoC)) c = Convert.ToDouble(hesoC);
        if(a==0) ketqua = "Khong phai phuong trinh bac 2";
        else{
            //tinh delta
            delta = Math.Pow(b,2) - 4*a*c;
            // Giai phuong trinh
            if(delta<0) ketqua ="Phuong trinh vo nghiem";
            else if(delta==0)
            {
                x1 = -b/(2*a);
                ketqua ="Phuong trinh co nghiem kep = "+ x1;
            }
            else 
            {
                x1= (-b + Math.Sqrt(delta))/(2*a);
                x2= (-b - Math.Sqrt(delta))/(2*a);
                ketqua = "Phuong trinh co 2 nghiem phan biet: x1= "+ x1 + ", x2= "+x2;
            }
        }
        ViewBag.gpt = ketqua;
        return View();
    }
    }
}