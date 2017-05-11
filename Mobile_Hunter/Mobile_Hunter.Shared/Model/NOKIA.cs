using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_Hunter.Model
{
  public  class NOKIA
    {
        public int ID { get; set; }
      public  string PName { get; set; }
       public string PImage { get; set; }
       public string  Specs { get; set; }
       public int Price { get; set; }
    }


    public class Data3
    {
        public List<NOKIA> myList3
        {
    get{
        return privateList;
    }
         }

        private List<NOKIA> privateList = new List<NOKIA>();

      
        public void Data_in() {
            myList3.Add(new NOKIA()
            {
                ID = 0,
                PName = "LUMIA-530 DUAL SIM",
                PImage = "Assets/n1.jpg",
                Price = 650,
                Specs = "OS :  Windows 8.1  \n Back-Camera : 5 MB With LED Flash  \n Front-Camera : NO  \n Internal-Storage : 4 GB \n RAM :512 MG \t Processor : 1.2 Quad Core "
            });


            myList3.Add(new NOKIA()
            {
                ID = 1,
                PName = "Nokia Lumia 638",
                PImage = "Assets/n2.jpg",
                Price = 0000,
                Specs = "OS :  Windows 8.1  \n Back-Camera : 5 MB With LED Flash  \n Front-Camera : NO  \n Internal-Storage : 4 GB \n RAM :512 MG \t Processor : 1.2 Quad Core "
            });



            myList3.Add(new NOKIA()
            {
                ID = 2,
                PName = "Nokia Lumia 830",
                PImage = "Assets/n3.jpg",
                Price = 3250,
                Specs = "OS :  Windows 8.1  \n Back-Camera : 10 MB With LED Flash  \n Front-Camera : 0.9 MG  \n Internal-Storage : 4 GB \n RAM :512 MG \t Processor : 1.2 Quad Core "
            });


            myList3.Add(new NOKIA()
            {
                ID = 3,
                PName = "Nokia Asha 230",
                PImage = "Assets/n4.jpg",
                Price = 3100,
                Specs = "OS : ASHA 1.1.1 \n Back-Camera : 1.3 MB With LED Flash  \n Front-Camera : NO  \n Internal-Storage :NO \n RAM :NO \t Processor : NO  "
            });


            myList3.Add(new NOKIA()
            {
                ID = 4,
                PName = "Nokia Lumia 525",
                PImage = "Assets/n5.jpg",
                Price = 0000,
                Specs = "OS : Windows 8 \n Back-Camera : 8 MB With LED Flash  \n Front-Camera : NO  MB \n Internal-Storage : 8 GB \n RAM :1 GB \t Processor : B "
            });




            myList3.Add(new NOKIA()
            {
                ID = 5,
                PName = "Nokia Lumia 2520",
                PImage = "Assets/n6.jpg",
                Price = 3100,
                Specs = "OS : Windows RT \n Back-Camera : 6.7 MB With LED Flash  \n Front-Camera : 2 MB  \n Internal-Storage : 32 GB \n RAM :2 GB \t Processor : 2.2 Quad Core "
            });


            myList3.Add(new NOKIA()
            {
                ID = 6,
                PName = "Nokia Lumia 1320",
                PImage = "Assets/n7.jpg",
                Price = 0000,
                Specs = "OS : Windows 8  \n Back-Camera : 5 MB With LED Flash  \n Front-Camera : VGA  \n Internal-Storage : 8 GB \n RAM :1 GB \t Processor : 1.2 Quad Core "
            });


            myList3.Add(new NOKIA()
            {
                ID = 7,
                PName = "Nokia Lumia 1520",
                PImage = "Assets/n8.jpg",
                Price = 3800,
                Specs = "OS : Windows 8 \n Back-Camera : 8 MB With LED Flash  \n Front-Camera : 5 MB  \n Internal-Storage : 16 GB \n RAM :2 GB \t Processor : 1.2 Quad Core "
            });
        }
    }
}
