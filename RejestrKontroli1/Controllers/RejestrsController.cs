using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RejestrKontroli1.DAL;
using RejestrKontroli1.Models;

namespace RejestrKontroli1.Controllers
{
    public class RejestrsController : Controller
    {
        private RejestrContext db = new RejestrContext();

        // GET: Rejestrs
        public ActionResult Index()
        {
            return View(db.Rejestr.ToList());
        }

        // GET: Rejestrs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rejestr rejestr = db.Rejestr.Find(id);
            if (rejestr == null)
            {
                return HttpNotFound();
            }
            return View(rejestr);
        }

        // GET: Rejestrs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rejestrs/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Działanie,Poddziałanie,NrProjektu,TytułProjektu,Beneficjent,Zespół,RodzajKontroli,TerminKontroli,DataZakończenia,WizytaMonitoringowa,Pzp,Konkurencyjnosc,RozeznanieRynku,DataPierwszejInformacji,ZastrzezeniaDoInf,DataOstatecznejInfo,DataPodpisaniaInfo,DataWpisuDoSL,UchybieniaNIeprawidlowoci,Zalecenia,DataWykonaniaZalecen,KontrolaZakonczona")] Rejestr rejestr)
        {
            if (ModelState.IsValid)
            {
                db.Rejestr.Add(rejestr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rejestr);
        }

        // GET: Rejestrs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rejestr rejestr = db.Rejestr.Find(id);
            if (rejestr == null)
            {
                return HttpNotFound();
            }
            return View(rejestr);
        }

        // POST: Rejestrs/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Działanie,Poddziałanie,NrProjektu,TytułProjektu,Beneficjent,Zespół,RodzajKontroli,TerminKontroli,DataZakończenia,WizytaMonitoringowa,Pzp,Konkurencyjnosc,RozeznanieRynku,DataPierwszejInformacji,ZastrzezeniaDoInf,DataOstatecznejInfo,DataPodpisaniaInfo,DataWpisuDoSL,UchybieniaNIeprawidlowoci,Zalecenia,DataWykonaniaZalecen,KontrolaZakonczona")] Rejestr rejestr)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rejestr).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rejestr);
        }

        // GET: Rejestrs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rejestr rejestr = db.Rejestr.Find(id);
            if (rejestr == null)
            {
                return HttpNotFound();
            }
            return View(rejestr);
        }

        // POST: Rejestrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rejestr rejestr = db.Rejestr.Find(id);
            db.Rejestr.Remove(rejestr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
