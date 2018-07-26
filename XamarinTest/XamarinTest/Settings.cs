using Newtonsoft.Json;
using Plugin.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinTest
{
    static class Settings
    {
        public static User User
        {
            get
            {
                var json = CrossSettings.Current.GetValueOrDefault("token", null);
                if (json == null)
                    return null;

                var str = JsonConvert.DeserializeObject<User>(json);
                return str;
            }

            set
            {
                var json = JsonConvert.SerializeObject(value);
                CrossSettings.Current.AddOrUpdateValue("user", json);
            }
        }

        public static string Token
        {
            get => CrossSettings.Current.GetValueOrDefault("token", null);
            set => CrossSettings.Current.AddOrUpdateValue("token", value);
        }
    }
}
