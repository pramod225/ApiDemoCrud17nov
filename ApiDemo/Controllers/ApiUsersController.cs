using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using ApiDemo.Models;

namespace ApiDemo.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ApiUsersController : ApiController
    {
       
        private ApiUserDbContext db = new ApiUserDbContext();

        // GET: api/ApiUsers
        public IQueryable<ApiUser> GetapiUsers()
        {
            return db.apiUsers;
        }

        // GET: api/ApiUsers/5
        [ResponseType(typeof(ApiUser))]
        public IHttpActionResult GetApiUser(int id)
        {
            ApiUser apiUser = db.apiUsers.Find(id);
            if (apiUser == null)
            {
                return NotFound();
            }

            return Ok(apiUser);
        }

        // PUT: api/ApiUsers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutApiUser(int id, ApiUser apiUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != apiUser.id)
            {
                return BadRequest();
            }

            db.Entry(apiUser).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApiUserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ApiUsers
        [ResponseType(typeof(ApiUser))]
        public IHttpActionResult PostApiUser(ApiUser apiUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.apiUsers.Add(apiUser);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = apiUser.id }, apiUser);
        }

        // DELETE: api/ApiUsers/5
        [ResponseType(typeof(ApiUser))]
        public IHttpActionResult DeleteApiUser(int id)
        {
            ApiUser apiUser = db.apiUsers.Find(id);
            if (apiUser == null)
            {
                return NotFound();
            }

            db.apiUsers.Remove(apiUser);
            db.SaveChanges();

            return Ok(apiUser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ApiUserExists(int id)
        {
            return db.apiUsers.Count(e => e.id == id) > 0;
        }
    }
}