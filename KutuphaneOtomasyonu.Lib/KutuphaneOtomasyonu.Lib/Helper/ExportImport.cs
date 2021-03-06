﻿using KutuphaneOtomasyonu.Lib.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Lib.Helper
{
    public class ExportImport
    {

        public string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/KutuphaneData.json";
        public void Export(Context context)
        {
            try
            {
                FileStream file = File.Open(path, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject(context));
                writer.Close();
                writer.Dispose();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Context Import()
        {
            FileStream file = File.Open(path, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            var content = reader.ReadToEnd();
            reader.Close();
            reader.Dispose();
            Context context = JsonConvert.DeserializeObject<Context>(content);
            return context;

        }

    }
}