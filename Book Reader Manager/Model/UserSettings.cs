using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Reader_Manager.Model
{
    class UserSettings
    {
        ReadingSettings _readingSettings;

        public ReadingSettings ReadingSettings
        {
            set
            {
                _readingSettings = value;
            }
            get
            {
                if (_readingSettings == null)
                    _readingSettings = ReadingSettings.Default;
                return _readingSettings;
            }
        }
    }
}
