using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkCore.Data.Repositories
{
   public interface ISettingsRepository
    {
        SettingsModel GetSetting(int id);
        IEnumerable<SettingsModel> GetAllSettings();
        SettingsModel Add(SettingsModel settingsModel);
        SettingsModel Update(SettingsModel settingsModel);
        SettingsModel Delete(int id);
    }
}
