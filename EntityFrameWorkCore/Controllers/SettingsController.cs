using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameWorkCore.Data;
using EntityFrameWorkCore.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWorkCore.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingsRepository settingsRepository;

        public SettingsController(ISettingsRepository settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        // GET: api/Settings
        [HttpGet]
        public IEnumerable<SettingsModel> Get()
        {
          return this.settingsRepository.GetAllSettings();
        }

        // GET: api/Settings/5
        [HttpGet("{id}", Name = "Get")]
        public SettingsModel Get(int id)
        {
            return this.settingsRepository.GetSetting(id);
        }

        // POST: api/Settings
        [HttpPost]
        public SettingsModel Post([FromBody] SettingsModel settingsModel)
        {
            return this.settingsRepository.Add(settingsModel);
        }

        // PUT: api/Settings/5
        [HttpPut("{id}")]
        public SettingsModel Put(int id, [FromBody] SettingsModel settingsModel)
        {
            return this.settingsRepository.Update(settingsModel);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public SettingsModel Delete(int id)
        {
            return this.settingsRepository.Delete(id);
        }
    }
}
