using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Student.Models;

namespace IDcard.Controllers
{
    public class IdCardController : Controller
    {
        // GET: IdCard
        public ActionResult Index()
        {
            if (Session["Data"] == null)
            {
                IdCardBL objIdCardBL = new IdCardBL();
                Session["Data"] = objIdCardBL.GetAllIds();
            }

            return View(((IEnumerable<IdCardStructure>)Session["Data"]).ToList());
        }

        // GET: IdCard/Details/5
        public ActionResult Details(int id)
        {
            return View(((IEnumerable<IdCardStructure>)Session["Data"]).ToList().Where(x => x.intStudentID == id).FirstOrDefault());
        }

        // GET: IdCard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IdCard/Create
        [HttpPost]
        public ActionResult Create(IdCardStructure ipIdCardStructure)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    List<IdCardStructure> lstIdCards = new List<IdCardStructure>();
                    if (Session["Data"] != null)
                        lstIdCards = ((IEnumerable<IdCardStructure>)Session["Data"]).ToList();
                    lstIdCards.Add(ipIdCardStructure);
                    Session["Data"] = lstIdCards;
                    return RedirectToAction("Index");
                }
            }
            catch
            {

            }
            return View();
        }

        // GET: IdCard/Edit/5
        public ActionResult Edit(int id)
        {
            if (Session["Data"] != null)
                return View(((IEnumerable<IdCardStructure>)Session["Data"]).ToList().Where(x => x.intStudentID == id).FirstOrDefault());
            else
                return View();
        }

        // POST: IdCard/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IdCardStructure ipIdCardStructure)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ((IEnumerable<IdCardStructure>)Session["Data"]).Where(x => x.intStudentID == id).ToList().ForEach(u =>
                {
                    u.strStudentName = ipIdCardStructure.strStudentName;
                    u.strDateOfBirth = ipIdCardStructure.strDateOfBirth;
                    u.lngContactNumber = ipIdCardStructure.lngContactNumber;
                    u.strAddress1 = ipIdCardStructure.strAddress1;
                    u.strAddress2 = ipIdCardStructure.strAddress2;
                    u.strLandMark = ipIdCardStructure.strLandMark;
                    u.strCity = ipIdCardStructure.strCity;
                    u.intPincode = ipIdCardStructure.intPincode;
                    u.strPhoto = ipIdCardStructure.strPhoto;
                    u.strAlternativeName = ipIdCardStructure.strAlternativeName;
                });
                    return RedirectToAction("Index");
                }
            }
            catch
            {

            }
            return View();
        }

        // GET: IdCard/Delete/5
        public ActionResult Delete(int id)
        {            
                return View(((IEnumerable<IdCardStructure>)Session["Data"]).ToList().Where(x => x.intStudentID == id).FirstOrDefault());
        }

        // POST: IdCard/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ((IEnumerable<IdCardStructure>)Session["Data"]).Where(x => x.intStudentID == id).ToList().Remove(((IEnumerable<IdCardStructure>)Session["Data"]).Where(x => x.intStudentID == id).ToList().FirstOrDefault());
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
