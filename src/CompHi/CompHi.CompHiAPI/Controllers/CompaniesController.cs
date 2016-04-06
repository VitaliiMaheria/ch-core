using CompHi.CompHiAPI.Core.Services;
using CompHi.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CompHi.CompHiAPI.Controllers
{
    [EnableCors("*","*","*")]
    [RoutePrefix("api/Companies")]
    public class CompaniesController : ApiController
    {
        private readonly CompaniesService _companiesService;
        public CompaniesController(CompaniesService companiesService)
        {
            _companiesService = companiesService;
        }

        #region Actions

        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_companiesService.Get());
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        public IHttpActionResult Get(Guid id)
        {
            try
            {
                return Ok(_companiesService.Get(id));
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        public IHttpActionResult Post([FromBody]Company company)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                company.Id = Guid.NewGuid();
                _companiesService.Create(company);
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        public IHttpActionResult Put([FromBody]Company company)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                _companiesService.Update(company);
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        public IHttpActionResult Delete(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                _companiesService.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        #endregion
    }
}
