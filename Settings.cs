using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace NewsReader
{
     public class BuildInfo
    {
        [JsonProperty("Program Version")]
        private  string _version { get; set; }
        [JsonProperty("Author")]
        private  string _author { get; set; }
        [JsonProperty("Release Date")]
        private  string _date { get; set; }
        public BuildInfo()
        {
            _version = "1.0.0";
            _author = "Artem Slivka";
            _date = "03-24-2018";
        }
    }

    public class AppSettings
    {
        public BuildInfo _currentBuildInfo;
        public bool _saveEnabled;
        public List<string> _rawSources = new List<string>();
        public List<string> _formSources = new List<string>();
        public List<string> _selectedSources = new List<string>();


        public AppSettings()
        {
            _saveEnabled = false;
            _currentBuildInfo = new BuildInfo();
        }

        public void SaveSettings(AppSettings currentSettings)
        {
            this._saveEnabled = currentSettings._saveEnabled;
            this._rawSources = currentSettings.getRawList();
            this._currentBuildInfo = currentSettings._currentBuildInfo;
            this._formSources = currentSettings.getFormattedList();

            if (_saveEnabled)
            {
                this._selectedSources = currentSettings._selectedSources;
            }
            else
            {
                this._selectedSources.Clear();
            }
        }

        public void SaveToFile(string fileName)
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory +  fileName;
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, this);
            }
        }
        public AppSettings LoadFromFile(string fileName)
        {
            // deserialize JSON directly from a file
            try
            {
                string filePath = AppDomain.CurrentDomain.BaseDirectory + fileName;
                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    AppSettings newSettings = (AppSettings)serializer.Deserialize(file, typeof(AppSettings));
                    return newSettings;
                }
            }
            catch (Exception e)
            {
                string errorText = e.ToString();
                string caption = "Error loading program.config file";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(errorText, caption, buttons, MessageBoxIcon.Error);
                return new AppSettings();
            }       
        }

        public List<string> getRawList()
        {
            return _rawSources;
        }
        public List<string> getFormattedList()
        {
            return _formSources;
        }
    }
    
}
