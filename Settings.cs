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
    public class AppSettings
    {
        public bool _saveEnabled;
        public List<string> _selectedSources = new List<string>();

        public AppSettings()
        {
            _saveEnabled = false;
        }

        public void SaveSettings(AppSettings currentSettings)
        {
            this._saveEnabled = currentSettings._saveEnabled;
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
    }
    public class SourceCollection
    {
        private Sources _sourceList = new Sources();

        //Constructor
        public SourceCollection()
        {
            _sourceList = loadSourcesFromFile(@"\sources.config",_sourceList);
        }

        public SourceCollection(List<string> raw, List<string> formatted)
        {
            _sourceList._rawList = raw;
            _sourceList._formattedList = formatted;
        }

        private Sources loadSourcesFromFile(string fileName, Sources newList)
        {
            try
            {
                string filePath = AppDomain.CurrentDomain.BaseDirectory + fileName;
                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    newList = (Sources)serializer.Deserialize(file, typeof(Sources));
                }
            }
            catch (Exception e)
            {
                string errorText = e.ToString();
                string caption = "Error loading sources.config file";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(errorText, caption, buttons, MessageBoxIcon.Error);   
            }
            return newList;
        }

        public void SaveToFile(string fileName)
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + fileName;
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, _sourceList);
            }
        }

        public List<string> getRawList()
        {
            return _sourceList._rawList;
        }
        public List<string> getFormattedList()
        {
            return _sourceList._formattedList;
        }

        private class Sources
        {
            public List<string> _rawList = new List<string>();
            public List<string> _formattedList = new List<string>();
        }
    };
}
