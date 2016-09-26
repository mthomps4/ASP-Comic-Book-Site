using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
	public class ComicBookController : Controller
	{
		//Action Method 
		public string Detail()
        {
            return "Hello from the comic book controller!";
        }
	}
}