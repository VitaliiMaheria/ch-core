using CompHi.CompHiAPI.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CompHi.CompHiAPI.Controllers
{

    [RoutePrefix("api/Companies")]
    public class CompaniesController : ApiController
    {
        private readonly CompaniesService _companiesService;
        public CompaniesController(CompaniesService companiesService)
        {
            _companiesService = companiesService;
        }

        #region Actions

        [Route("")]
        public IHttpActionResult GetCampanies()
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


        #endregion


    }
}
