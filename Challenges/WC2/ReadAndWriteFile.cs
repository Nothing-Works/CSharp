using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Challenges.WC2
{
    public class ReadAndWriteFile
    {
        private const string Path = "./WC2/StandardDataSet.csv";

        public void ReadFile()
        {
            var models = new List<User>();

            var data = File.ReadAllLines(Path).ToList();

            var headers = data.First().Split(",");

            data.RemoveAt(0);

            data.ForEach(c =>
            {
                var singleUser = c.Split(",");
                var user = new User();


                for (var i = 0; i < headers.Length; i++)
                {
                    var property = user.GetType().GetProperty(headers[i]);

                    var value = property.PropertyType == typeof(bool)
                        ? Convert.ChangeType(Convert.ToInt32(singleUser[i]), property.PropertyType)
                        : Convert.ChangeType(singleUser[i], property.PropertyType);

                    property.SetValue(user, value);
                }

                models.Add(user);
            });
            foreach (var model in models)
            {
                Console.WriteLine(model.DisplayText);
            }
        }
    }
}