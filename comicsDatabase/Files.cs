using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comicsDatabase
{
    
    class Files
    {
        String fileName; // Class Variable

        public Files(string fileName)
        {
            this.fileName = fileName;
            if (!(File.Exists(this.fileName))){ // If file doesn't exist creates the file
                File.Create(this.fileName);
            }
        }

        public bool WriteLine(String line)
        {
            try
            {
                String contents = ReadAllFile(); // Gets current content
                contents = contents + "\n" + line; // Appends new content
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(contents);  // writes to file
                }
                return true;
            }catch
            {
                return false; // returns false to symbolise failure
            }
            
        }

        public String ReadAllFile()
        {
            try
            {
                return File.ReadAllText(fileName); // gets file contents
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
