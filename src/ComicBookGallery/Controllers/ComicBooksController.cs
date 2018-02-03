using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController:Controller
    {
        public ComicBookRepository _comicBookRepository = null;

        public ComicBooksController ()
        {
            _comicBookRepository = new ComicBookRepository();
        }


        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comincBook = _comicBookRepository.GetComicBook((int)id);

            return View(comincBook);
        }
    }
}