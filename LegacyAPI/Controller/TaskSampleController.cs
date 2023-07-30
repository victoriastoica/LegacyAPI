using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LegacyAPI.Controller
{
    public class TaskSampleController : BaseController
    {
        [HttpPut]
        [Route("api/init/{id}")]
        public string Init(int taskId)
        {
            return "OK";
        }

        [HttpPut]
        [Route("api/confirm/{id}")]
        public string Confirm(int taskId)
        {
            return "OK";
        }

        [HttpPut]
        [Route("api/reject/{id}")]
        public string Reject(int taskId)
        {
            return "OK";
        }

        [HttpPut]
        [Route("api/update/{id}")]
        public string Update(int taskId)
        {
            return "OK";
        }
    }
}
