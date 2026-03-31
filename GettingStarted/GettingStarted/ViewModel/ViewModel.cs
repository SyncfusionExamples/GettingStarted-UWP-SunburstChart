using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>();
            Data.Add(new Model { Country = "America", JobDescription = "Sales", EmployeesCount = 70 });
            Data.Add(new Model
            {
                Country = "America",
                JobDescription = "Technical",
                JobGroup = "Testers",
                EmployeesCount = 35
            });
            Data.Add(new Model
            {
                Country = "America",
                JobDescription = "Technical",
                JobGroup = "Developers",
                JobRole = "Windows",
                EmployeesCount = 105
            });
            Data.Add(new Model
            {
                Country = "America",
                JobDescription = "Technical",
                JobGroup = "Developers",
                JobRole = "Web",
                EmployeesCount = 40
            });
            Data.Add(new Model { Country = "America", JobDescription = "Management", EmployeesCount = 40 });
            Data.Add(new Model { Country = "America", JobDescription = "Accounts", EmployeesCount = 60 });
            Data.Add(new Model
            {
                Country = "India",
                JobDescription = "Technical",
                JobGroup = "Testers",
                EmployeesCount = 25
            });
            Data.Add(new Model
            {
                Country = "India",
                JobDescription = "Technical",
                JobGroup = "Developers",
                JobRole = "Windows",
                EmployeesCount = 155
            });
            Data.Add(new Model
            {
                Country = "India",
                JobDescription = "Technical",
                JobGroup = "Developers",
                JobRole = "Web",
                EmployeesCount = 60
            });
            Data.Add(new Model
            {
                Country = "Germany",
                JobDescription = "Sales",
                JobGroup = "Executive",
                EmployeesCount = 30
            });
            Data.Add(new Model
            {
                Country = "Germany",
                JobDescription = "Sales",
                JobGroup = "Analyst",
                EmployeesCount = 40
            });
            Data.Add(new Model
            {
                Country = "UK",
                JobDescription = "Technical",
                JobGroup = "Developers",
                JobRole = "Windows",
                EmployeesCount = 100
            });
            Data.Add(new Model
            {
                Country = "UK",
                JobDescription = "Technical",
                JobGroup = "Developers",
                JobRole = "Web",
                EmployeesCount = 30
            });
            Data.Add(new Model { Country = "UK", JobDescription = "HR Executives", EmployeesCount = 60 });
            Data.Add(new Model { Country = "UK", JobDescription = "Marketing", EmployeesCount = 40 });
        }

    }
}
