using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_Hunter.ViewModel
{

    public class DataSource
    {
        //Insatnces
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

       
    }

    public class FilData
    {
        public List<DataSource> DataList
        {
            get
            {
                return CompList;
            }
        }

        public List<DataSource> CompList = new List<DataSource>();

        public void CallData()
        {
            CompList.Add(new DataSource
            {
                Id = 0,
                Name = "Samsung",
                Image = "ms-appx:///Assets/sam1.png"

            });

            CompList.Add(new DataSource
            {
                Id = 1,
                Name = "Nokia",
                Image = "Assets/nokk.jpg",
            });

            CompList.Add(new DataSource
            {
                Id = 2,
                Name = "HTC",
                Image = "Assets/HTC.png",
            });

            CompList.Add(new DataSource
            {
                Id = 3,
                Name = "Sony",
                Image = "Assets/vaio.png",
            });

            

        }
    }
}
