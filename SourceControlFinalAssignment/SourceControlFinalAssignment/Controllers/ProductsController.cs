using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SourceControlFinalAssignment.DAL;
using SourceControlFinalAssignment.Models;
using log4net;

namespace SourceControlFinalAssignment.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private ProductContext db = new ProductContext();
        private static readonly ILog Log = LogManager.GetLogger(typeof(ProductsController));
        // GET: Products
        public ActionResult Index()
        {
            try
            {
                Log.Info("Executing Index Method");
            }
            catch (Exception ex)
            {
                Log.Error("Exception occured", ex);
                ViewBag.Errors = "Unexpected exception occured.";
            }
            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProductName,Category,Price,Quantity,ShortDesc,LongDesc,ProductImage,DealerPhone,ProductRegion")] Product product)
        {
            Log.Info("Executing HttpPost Create Method");
            try
            {
                if (ModelState.IsValid)
                {
                    Log.Info("ModelState is valid");
                    //to save the product image
                    if (product.ProductImage != null)
                    {
                        string FileName = Path.GetFileName(product.ProductImage.FileName);
                        string FilePath = Path.Combine(Server.MapPath("~/ProductImages/"), FileName);

                        product.ProductImagePath = "~/ProductImages/" + FileName;

                        //To copy and save file into server.  
                        product.ProductImage.SaveAs(FilePath);
                    }

                    db.Products.Add(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                Log.Error("Exception occured:", ex);
                ViewBag.Errors = "Unexpected exception occured.";
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Product product = db.Products.Find(id);
                db.Products.Remove(product);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error("Exception occured:", ex);
                ViewBag.Errors = "Unexpected exception occured.";
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Log.Info("Disposing.");
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
