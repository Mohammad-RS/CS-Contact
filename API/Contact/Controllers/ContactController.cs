﻿using Contact.Business;
using Contact.Model;
using Contact.Model.Contact;
using Contact.Model.Phone;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Controller
{
    [ApiController, Authorize]
    [Route("contact")]
    public class ContactController : ControllerBase
    {
        private ContactBusiness contactBusiness;

        public ContactController()
        {
            this.contactBusiness = new ContactBusiness();
        }

        // ...
        [HttpGet("get-phonetypes")]
        public BusinessResult<IEnumerable<PhoneTypeTable>> GetPhoneTypes()
        {
            return contactBusiness.GetPhoneTypesBusiness();
        }

        // ...
        [HttpPost("add-contact")]
        public BusinessResult<bool> AddContact(ContactTable request)
        {
            request.UserId = int.Parse(base.User.Identity.Name);

            return contactBusiness.AddContactBusiness(request);
        }

        // ...
        [HttpPost("add-phone")]
        public BusinessResult<bool> AddPhone(PhoneTable request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.AddPhoneBusiness(request, Id);
        }

        // ...
        [HttpPost("add-favorite")]
        public BusinessResult<bool> AddFavorite(FavoriteTable request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.AddFavoriteBusiness(request, Id);
        }

        // ...
        [HttpPost("add-group")]
        public BusinessResult<bool> AddGroup(GroupTable request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.AddGroupBusiness(request, Id);
        }

        // ...
        [HttpPost("add-group-contact")]
        public BusinessResult<bool> AddGroupContact(MembershipTable request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.AddGroupContactBusiness(request, Id);
        }

        // ...
        [HttpPut("edit-contact")]
        public BusinessResult<bool> EditContact(ContactTable request)
        {
            request.UserId = int.Parse(base.User.Identity.Name);

            return contactBusiness.EditContactBusiness(request);
        }

        // ...
        [HttpPut("edit-phone")]
        public BusinessResult<bool> EditPhone(PhoneTable request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.EditPhoneBusiness(request, Id);
        }

        // ...
        [HttpPut("edit-group")]
        public BusinessResult<bool> EditGroup(GroupTable request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.EditGroupBusiness(request, Id);
        }

        // ...
        [HttpGet("get-phones")]
        public BusinessResult<IEnumerable<PhoneTable>> GetPhones(int request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.GetPhonesBusiness(request, Id);
        }

        // ...
        [HttpGet("get-contact")]
        public BusinessResult<ContactTable> GetContact(int request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.GetContactBusiness(request, Id);
        }

        // ...
        [HttpGet("get-contacts")]
        public BusinessResult<IEnumerable<ContactTable>> GetContacts()
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.GetContactsBusiness(Id);
        }

        // ...
        [HttpGet("get-favorite-contacts")]
        public BusinessResult<IEnumerable<ContactTable>> GetFavoriteContacts(int request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.GetFavoriteContactsBusiness(Id);
        }

        // ...
        [HttpGet("get-group")]
        public BusinessResult<IEnumerable<GroupTable>> GetGroup()
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.GetGroupsBusiness(Id);
        }

        // ...
        [HttpGet("get-group-contacts")]
        public BusinessResult<IEnumerable<ContactTable>> GetGroupContacts()
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.GetGroupContactsBusiness(Id);
        }

        // ...
        [HttpDelete("remove-contact")]
        public BusinessResult<bool> RemoveContact(int request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.RemoveContactBusiness(request, Id);
        }

        // ...
        [HttpDelete("remove-phone")]
        public BusinessResult<bool> RemovePhone(int request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.RemovePhoneBusiness(request, Id);
        }

        // ...
        [HttpDelete("remove-favorite")]
        public BusinessResult<bool> RemoveFavorite(int request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.RemoveFavoriteBusiness(request, Id);
        }

        // ...
        [HttpDelete("remove-group")]
        public BusinessResult<bool> RemoveGroup(int request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.RemoveGroupBusiness(request, Id);
        }

        // ...
        [HttpDelete("remove-group-contact")]
        public BusinessResult<bool> RemoveGroupContact(int request)
        {
            int Id = int.Parse(base.User.Identity.Name);

            return contactBusiness.RemoveGroupContactBusiness(request, Id);
        }

        // ...
    }
}
