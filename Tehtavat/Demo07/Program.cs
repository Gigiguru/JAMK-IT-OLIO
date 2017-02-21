using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Demo07
{
    [Serializable]
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
    class Program
    {
        static void TestaaSerialisointi()
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                // 3. write multiple persons to file
                // create list for persons
                List<Person> persons = new List<Person>();
                // add a few persons to list
                persons.Add(new Person { Firstname = "Kirsi", Lastname = "Kerneli" });
                persons.Add(new Person { Firstname = "Matti", Lastname = "Konsoli" });
                persons.Add(new Person { Firstname = "Teppo", Lastname = "Terävä" });

                // create a file for persons
                Stream writeMultipleStream = new FileStream("MyPersons.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                // write persons array to disk, note: uses formatter in previous code
                formatter.Serialize(writeMultipleStream, persons);
                // close file
                writeMultipleStream.Close();

                // create stream for reading persons
                Stream openStream = new FileStream("MyPersons.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                // create a list and read persons into it from disk
                List<Person> readPersons = (List<Person>)formatter.Deserialize(openStream);
                // close stream
                openStream.Close();

                // proof
                foreach (Person p in readPersons)
                {
                    Console.WriteLine("Person is {0} {0}", p.Firstname, p.Lastname);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
        static void TestaaLukeminen(string Filu) {
           // string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                string text = System.IO.File.ReadAllText(Filu);
                System.Console.WriteLine("Contents of test.txt:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
        static void TestaaAppend()
        {
            try
            {
                string path = @"d:\TestaaAppend.txt";
                // Tutkitaan onko tiedosto olemassa, ja jollei ole niin luodaan tiedosto, ja siihen kolme riviä
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Testitiedosto");
                        sw.WriteLine("luotu: " + DateTime.Now.ToString());
                        sw.WriteLine("luonut: Esa S");
                    }
                }

                // LisätäänAppendText-metodilla tekstiä olemassaolevaan
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Tässä");
                    sw.WriteLine("kolme");
                    sw.WriteLine("lisäriviä...");
                    sw.WriteLine("Blisäriviä...");
                }

                // Avataan tiedosto lukemista varten
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
    }
        static void TestaaMyDoc() {
            // find my documents folder
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // a few sample lines
            string[] lines = { "First line", "Second line", "Third line" };
            // write the string array to a new file named "WriteLines.txt".
            // IDisposable object use using, so resources will be disposed after using {}
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\WriteLines.txt")) // escape sequences are ignored
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }
            Console.WriteLine(string.Format("Tiesosto {0} success", mydocpath + @"\WriteLines.txt"));
        }
        static void TestaaTiedostonKirjoitus()
        {
            System.IO.StreamWriter outputFile = null;
            try
            {
                outputFile = new System.IO.StreamWriter(@"\\storage\home\mapas\test.txt");
                outputFile.WriteLine("Here is a sample text to file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Can't open file for writing (UnauthorizedAccessException)");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Opened stream is null (ArgumentNullException)");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Opened stream is not writable (ArgumentException)");
            }
            catch (IOException)
            {
                Console.WriteLine("An IO error happend (IOException)");
            }
            catch (Exception)
            {
                Console.WriteLine("Some other exception happend (Exception)");
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
            }
        
        static void Main(string[] args)
        {
            //TestaaTiedostonKirjoitus();
            // TestaaMyDoc();
            //TestaaAppend();
            //TestaaLukeminen(@"d:\TestaaAppend.txt");
            TestaaSerialisointi();

        }
    }
}
