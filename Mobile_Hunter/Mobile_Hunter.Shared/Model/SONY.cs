using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_Hunter.Model
{
    public class SONY
    {
        public int ID { get; set; }
        public string PName { get; set; }
        public string PImage { get; set; }
        public string Specs { get; set; }
        public int Price { get; set; }
    }


    public class Data4
    {
        public List<SONY> myList4
        {
            get
            {
                return privateList;
            }
        }

        private List<SONY> privateList = new List<SONY>();


        public void Data_in()
        {
            myList4.Add(new SONY()
            {
                ID = 0,
                PName = "M2 AQUA",
                PImage = "Assets/s1.jpg",
                Price = 1950,
                Specs = "OS : Android 4.4.2 KitKAt \n Back-Camera : 8 MB With LED Flash  \n Front-Camera : 5 MB  \n Internal-Storage : 8 GB \n RAM :1 GB \t Processor : 1.2 Quad Core "
            });

            myList4.Add(new SONY()
            {
                ID = 1,
                PName = "sony xperia sl",
                PImage = "Assets/s2.jpg",
                Price = 2650,
                Specs = "OS : Android  v4.0.4 ICE CREAME SANDAWITCH \n Back-Camera : 12 MB With LED Flash  \n Front-Camera : 1.3 MB  \n Internal-Storage : 32 GB \n RAM :1 GB \t Processor : 1.2 Quad Core "
            });

            myList4.Add(new SONY()
            {
                ID = 2,
                PName = "sony Xperia C3",
                PImage = "Assets/s3.jpg",
                Price = 2330,
                Specs = "OS : Android 4.4.2 KitKAt \n Back-Camera : 8 MB With LED Flash  \n Front-Camera : 5 with LED Flash MB  \n Internal-Storage : 8 GB \n RAM :1 GB \t Processor : 1.2 Quad Core "
            });

            myList4.Add(new SONY()
            {
                ID = 3,
                PName = "sony Xperia E3",
                PImage = "Assets/s4.jpg",
                Price = 1475,
                Specs = "OS : Android 4.4.4 KitKAt \n Back-Camera : 5 MB With LED Flash  \n Front-Camera : VGA  \n Internal-Storage : 4 GB \n RAM :1 GB \t Processor : 1.2 Quad Core "
            });

            myList4.Add(new SONY()
            {
                ID = 4,
                PName = " sony Xperia Z2 Tablet LTE",
                PImage = "Assets/s5.jpg",
                Price = 1950,
                Specs = "OS : Android v4.4 KitKAt \n Back-Camera : 8.1 MB  \n Front-Camera : 2.2 MB  \n Internal-Storage : 16 GB \n RAM :3 GB \t Processor : 1.2 Quad Core "
            });

            myList4.Add(new SONY()
            {
                ID = 5,
                PName = "sony Xperia E1",
                PImage = "Assets/s6.jpg",
                Price = 4800,
                Specs = "OS : Android 4800 GellyBeen \n Back-Camera : 3.15 MB   \n Front-Camera : NO  \n Internal-Storage : 4 GB \n RAM : 512 MG \t Processor : 1.2 Quad Core "
            });

            myList4.Add(new SONY()
            {
                ID = 6,
                PName = " sony xperia z ultra",
                PImage = "Assets/s7.jpg",
                Price = 1950,
                Specs = "OS : Android 4.4.2 KitKAt \n Back-Camera : 8 MB   \n Front-Camera : 5 MB  \n Internal-Storage : 8 GB \n RAM :1 GB \t Processor : 1.2 Quad Core "
            });


            myList4.Add(new SONY()
            {
                ID = 7,
                PName = "sony Xperia SP",
                PImage = "Assets/s8.jpg",
                Price = 2800,
                Specs = "OS : Android 4.1 GellyBeen \n Back-Camera : 8 MB   \n Front-Camera : VGA  \n Internal-Storage : 8 GB \n RAM :1 GB \t Processor : 1.2 Quad Core "
            });






        }
    }
}
