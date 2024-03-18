using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Abstract;

namespace Core_Project.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactManager contactManager=new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {

            var values = contactManager.TGetList();
            return View(values);
        }

    }
}
