using System;
using System.Web.Mvc;
using Wedding_Website.Models;

namespace Wedding_Website.Controllers
{
    public class RSVPController : Controller
    {
        //This is used for mapping to RSVP model
        private readonly Wedding_DataEntities db = new Wedding_DataEntities();

        public ActionResult RSVP()
        {
            ViewBag.BodyID = "rsvp";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RSVP([Bind(Include = "RSVPId,FirstName,Surname,Email,Response,Adult,StarterChoice,DietaryRequirements,DietaryRequirementsDetails")] RSVP rSVP, AdditionalRSVP[] additionalRSVP)
        {
            if (ModelState.IsValid)
            {
                rSVP.CreatedDate = DateTime.Now;
                db.RSVPs.Add(rSVP);
                db.SaveChanges();

                // The if statement below checks to see if there are any additional RSVPs added to the main RSVP.
                if (additionalRSVP != null)
                {
                    foreach (var item in additionalRSVP)
                    {
                        AdditionalRSVP rsvp = new AdditionalRSVP
                        {
                            RSVPId = rSVP.RSVPId,
                            FirstName = item.FirstName,
                            Surname = item.Surname,
                            Adult = item.Adult,
                            StarterChoice = item.StarterChoice,
                            DieatryRequirements = item.DieatryRequirements,
                            DietaryRequirementsDetails = item.DietaryRequirementsDetails,
                            CreatedDate = DateTime.Now
                        };
                        db.AdditionalRSVPs.Add(rsvp);
                        db.SaveChanges();
                    }
                }
                return RedirectToAction("Confirmation");
            }

            return RedirectToAction("../Home/Error");
        }

        public ActionResult Confirmation()
        {
            return View();
        }
    }
}