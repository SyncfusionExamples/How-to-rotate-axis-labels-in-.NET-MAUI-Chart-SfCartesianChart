using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis_LabelRotation
{
    public class ViewModel
    {
        public List<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Model>()
        {
            new Model { Name = "David", Height = 120 },
            new Model { Name = "Michael", Height = 136 },
            new Model { Name = "Steve", Height = 165 },
            new Model { Name = "Joel", Height = 153 },
            new Model { Name = "Bob", Height = 134 },
            new Model { Name = "Harry", Height = 170 },
            new Model { Name = "Jack", Height = 146 },
            new Model { Name = "Thomas", Height = 165 },
            new Model { Name = "James", Height = 142 },
            new Model { Name = "William", Height = 134 },
            new Model { Name = "Robert", Height = 130 },
            new Model { Name = "Joseph", Height = 146 },
            new Model { Name = "George", Height = 125 },
            new Model { Name = "Charlie", Height = 182 },
            new Model { Name = "smith", Height = 134 },
        };
        }
    }
}
