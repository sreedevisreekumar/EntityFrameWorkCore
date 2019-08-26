using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkCore.Data.Repositories
{
    public class SqlSettingsRepository : ISettingsRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public SqlSettingsRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public SettingsModel Add(SettingsModel settingsModel)
        {
            this.applicationDbContext.Add(settingsModel);
            this.applicationDbContext.SaveChanges();
            return settingsModel;
        }

        public SettingsModel Delete(int id)
        {
            SettingsModel settingsModel = this.applicationDbContext.Settings.Find(id);
            if(settingsModel != null)
            {
                this.applicationDbContext.Remove(settingsModel);
                this.applicationDbContext.SaveChanges();
            }
            return settingsModel;
        }

        public IEnumerable<SettingsModel> GetAllSettings()
        {
            return this.applicationDbContext.Settings;
        }

        public SettingsModel GetSetting(int id)
        {
           return this.applicationDbContext.Settings.Find(id);
        }

        public SettingsModel Update(SettingsModel settingsModel)
        {
            var setting = this.applicationDbContext.Settings.Attach(settingsModel);
            setting.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.applicationDbContext.SaveChanges();
            return settingsModel;
        }
    }
}
