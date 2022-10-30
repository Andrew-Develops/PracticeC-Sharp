using System;
using System.Collections.Generic;
using System.IO;

namespace WrapUpDemo
{
    public class DataAccess<T> where T : new()
    {

        public event EventHandler<T> BadEntryFound;

        // salvam listele in text file
        // where T: new() - specificam ca T sa aiba un constructor gol,
        // T este obiectul care il introducem: PersonModel sau CarModel
        public void SaveToCSV(List<T> items, string filePath)
        {
            List<string> rows = new List<string>();
            // am creat o instanta de tip T
            T entry = new T();

            // GetProperties() ne returneaza in functie de obiectul T: FirstName,LastName,Email sau Manufacturer,Model
            var cols = entry.GetType().GetProperties();
            string row = "";

            foreach (var col in cols)
            {
                row += $",{col.Name}";
            }
            row = row.Substring(1); //"FirstName,LastName,Email"
            rows.Add(row);

            // trecem prin obiecte PersonModel1, PersonModel2
            foreach (var item in items)
            {
                row = "";
                bool badWordDetected = false;

                // trecem prin variabilele obiectului: FirstName, LastName, Email
                foreach (var col in cols)
                {
                    // verificam daca list anoastra contine cuvinte nepotrivite
                    string val = col.GetValue(item, null).ToString();
                    badWordDetected = BadWordDetector(val);

                    if (badWordDetected == true)
                    {
                        BadEntryFound?.Invoke(this, item);
                        break;
                    }

                    row += $",{col.GetValue(item, null)}";
                }

                if (badWordDetected == false)
                {
                    row = row.Substring(1); //"FirstName,LastName,Email"
                    rows.Add(row);
                }


            }

            File.WriteAllLines(filePath, rows);
        }

        private bool BadWordDetector(string stringToTest)
        {
            bool output = false;
            string lowerCaseTest = stringToTest.ToLower();
            if (lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("heck"))
            {
                output = true;
            }
            return output;
        }
    }
}
