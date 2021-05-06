using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeniyIdiotCommon
{
    public class FileProvider
    {
        public static void Save(string path, string value)
        {
            StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8);
            writer.Write(value);
            writer.Close();
        }

        public static void Replace(string path, string value)
        {
            StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.Write(value);
            writer.Close();
        }

        public static string Get(string path)
        {
            StreamReader reader = new StreamReader(path, Encoding.UTF8);
            var value = reader.ReadToEnd();
            reader.Close();

            return value;
        }

        public static bool IsExists(string path)
        {
            return File.Exists(path);
        }
    }
}
