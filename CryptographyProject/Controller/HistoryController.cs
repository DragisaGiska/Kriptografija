﻿using CryptographyProject.Model;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CryptographyProject.Helper;

namespace CryptographyProject.Controller
{
    /// <summary>
    /// Kontroler istorije sadrži instance datoteka istorije i operacije na tim instancama.
    /// Klasa datoteke istorije odnosi se na datoteke koje su već šifrirane / dešifrirane. /// </summary>
    public class HistoryController
    {
        public List<HistoryFiles> historyFiles;

        public HistoryController()
        {
            historyFiles = LoadHistoryFiles();
        }

        //Removes history.json file
        public void FlushHistory()
        {
            //If the file exists - remove it
            if (!File.Exists(Constants.History.HISTORY_FILE))
            {
                historyFiles.Clear();
                using (File.Create(Constants.History.HISTORY_FILE)) { }
                return;
            }
            //Fiel does not exsit, just create a new empty one
            File.WriteAllText(Constants.History.HISTORY_FILE, String.Empty);
            historyFiles.Clear();
        }

        //Create a new hisotry file object and write it to history.json
        public void AddToHistory(string filename, string path, string datemodified)
        {
            historyFiles.Add(new HistoryFiles()
            {
                FileName = filename,
                Path = path,
                DateModified = datemodified
            });
        }

        //Writing the history.json file data
        public void WriteHistory()
        {
            using (StreamWriter sw = new StreamWriter(Constants.History.HISTORY_FILE))
            {
                string json = JsonConvert.SerializeObject(historyFiles);
                sw.Write(json);
            }
        }

        //Učitajte podatke iz datoteke history
        public List<HistoryFiles> LoadHistoryFiles()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Constants.History.HISTORY_FILE))
                {
                    string json = sr.ReadToEnd();
                    if (string.IsNullOrEmpty(json))
                    {
                        return new List<HistoryFiles>();
                    }
                    return JsonConvert.DeserializeObject<List<HistoryFiles>>(json);
                }
            }
            catch (Exception)
            {
                using (File.Create(Constants.History.HISTORY_FILE)) { }
                return new List<HistoryFiles>(); // probably there is no history.json
            }
        }

        //Provjerite je li datoteka već šifrirana / dešifrirana i je li prisutna u datoteci history.json 
     
        public bool FileExists(FileInfo file)
        {
            var tmp = new HistoryFiles()
            {
                DateModified = file.LastWriteTime.ToString("dd/MM/yy HH:mm:ss"),
                FileName = file.Name,
                Path = file.FullName
            };

            foreach (var item in historyFiles)
            {
                if (item.Equals(tmp))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
