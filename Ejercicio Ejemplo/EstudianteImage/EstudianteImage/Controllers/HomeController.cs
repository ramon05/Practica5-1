using EstudianteImage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstudianteImage.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult FileUpload(HttpPostedFileBase file)
		{
			
			if(file != null)
			{
				EstudianteDBEntities db = new EstudianteDBEntities();
				string ImageName = System.IO.Path.GetFileName(file.FileName);
				string physicalPath = Server.MapPath("~/Images/" + ImageName);
				file.SaveAs(physicalPath);
				tblEstudiante estudiante = new tblEstudiante();
				estudiante.Nombre = Request.Form["Nombre"];
				estudiante.Apellido = Request.Form["Apellido"];
				estudiante.Direccion = Request.Form["Direccion"];
				estudiante.Telefono = Request.Form["Telefono"];
				estudiante.Cedula = Request.Form["Cedula"];
				estudiante.ImageUrl = ImageName;
				db.tblEstudiantes.Add(estudiante);
				db.SaveChanges();
		    }	
		  return RedirectToAction("../home/Detalle");
		}

		public ActionResult Detalle()
		{
			return View();
		}

		public ActionResult Estudiantes( tblEstudiante est)
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}