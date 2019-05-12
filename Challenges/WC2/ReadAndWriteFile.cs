using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Challenges.WC2
{
    public class ReadAndWriteFile
    {
        private const string StandardPath = "./WC2/StandardDataSet.csv";

        private const string AdvancedPath = "./WC2/AdvancedDataSet.csv";

        private readonly List<User> _usersModel = new List<User>();

        private List<string> _data = new List<string>();

        private List<string> _headers = new List<string>();

        private List<string> _users = new List<string>();

        public void ReadFile()
        {
            GetData();
            GetHeaders();
            GetUsers();
            MapToUserModel();
        }

        public void PrintOut() => _usersModel.ForEach(c => Console.WriteLine(c.DisplayText));


        private void MapToUserModel()
        {
            foreach (var u in _users) MapSingleRow(u);
        }

        private void MapSingleRow(string u)
        {
            var user = new User();

            var userArray = u.Split(",");

            for (var j = 0; j < _headers.Count; j++)
            {
                var property = user.GetType().GetProperty(_headers[j]);

                var value = property.PropertyType == typeof(bool)
                    ? Convert.ChangeType(Convert.ToInt32(userArray[j]), property.PropertyType)
                    : Convert.ChangeType(userArray[j], property.PropertyType);

                property.SetValue(user, value);
            }

            _usersModel.Add(user);
        }

        private void GetData() => _data = File.ReadAllLines(StandardPath).ToList();

        private void GetHeaders() => _headers = _data.First().Split(",").ToList();

        private void GetUsers() => _users = _data.Where((c, i) => i != 0).ToList();
    }
}