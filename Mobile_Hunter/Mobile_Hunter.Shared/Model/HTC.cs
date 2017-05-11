using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_Hunter.Model
{
  public  class HTC
    {
        public int ID { get; set; }
      public  string PName { get; set; }
       public string PImage { get; set; }
       public string  Specs { get; set; }
       public int Price { get; set; }
    }


    public class Data2
    {
        public List<HTC> myList2
        {
    get{
        return privateList;
    }
         }

        private List<HTC> privateList = new List<HTC>();

      
        public void Data_in() {
            myList2.Add(new HTC()
            {
                ID = 0,
                PName = "DESIRE 620 DUAL SIM",
                PImage = "Assets/ht1.jpg",
                Price = 3100, 
        Specs = "OS : Android 4.4.4 KitKAt \n Back-Camera : 8 MB With LED Flash  \n Front-Camera : 5 MB  \n Internal-Storage : 16 GB \n RAM :2 GB \t Processor : 1.2 Quad Core " } );



            myList2.Add(new HTC()
            {
                ID = 1,
                PName = "Desire SV",
                PImage = "Assets/ht2.jpg",
                Price = 0000 ,
                Specs = "OS :  v4.0.4 (Ice Cream Sandwich) \n Back-Camera : 8 MB With LED Flash  \n Front-Camera : 5 MB  \n Internal-Storage : 4 GB \n RAM :768  MB \t Processor : 1.2 Quad Core "
            });


            myList2.Add(new HTC()
            {
                ID = 2,
                PName = "htc Butterfly 2",
                PImage = "Assets/ht3.jpg",
                Price = 0000,
                Specs = "OS : Android 4.4.2 KitKAt \n Back-Camera : 13  MB With LED Flash  \n Front-Camera : 5 MB  \n Internal-Storage : 16 GB \n RAM :2 GB \t Processor : 1.2 Quad Core "
            });


            myList2.Add(new HTC()
            {
                ID = 3,
                PName = "htc Desire 300",
                PImage = "Assets/ht3.jpg",
                Price = 1400,
                Specs = "OS : Android 4.1.2 GelyBeen \n Back-Camera : 8 MB With LED Flash  \n Front-Camera : 5 MB  \n Internal-Storage : 8 GB \n RAM :512 MB \t Processor : 1.2 Quad Core "
            });


            myList2.Add(new HTC()
            {
                ID = 4,
                PName = "htc Desire 310",
                PImage = "Assets/ht4.jpg",
                Price = 1175,
                Specs = "OS : Android 4.2.2 GelyBeen \n Back-Camera : 5 MB With LED Flash  \n Front-Camera : VGA  \n Internal-Storage : 4 GB \n RAM :1 or 0.5 GB \t Processor : 1.2 Quad Core "
            });



            myList2.Add(new HTC()
            {
                ID = 5,
                PName = "htc Desire 500",
                PImage = "Assets/ht5.jpg",
                Price = 2200,
                Specs = "OS : Android v4.2.2 GelyBeen \n Back-Camera : 8 MB With LED Flash  \n Front-Camera : 1.6 MB  \n Internal-Storage : 4 GB \n RAM :1 GB \t Processor : 1.2 Quad Core "
            });


            myList2.Add(new HTC()
            {
                ID = 6,
                PName = "htc Desire 616 Dual Sim",
                PImage = "Assets/ht6.jpg",
                Price = 2620,
                Specs = "OS : Android 4.4.2 KitKAt \n Back-Camera : 13 MB With LED Flash  \n Front-Camera : 5 MB  \n Internal-Storage : 8 GB \n RAM :1.5 GB \t Processor : 1.2 Quad Core "
            });



            myList2.Add(new HTC()
            {
                ID = 7,
                PName = "htc One M8 for Windows",
                PImage = "Assets/ht7.jpg",
                Price = 0000,
                Specs = "OS : Windows 8.1 \n Back-Camera : 4 MB With LED Flash  \n Front-Camera : 5 MB  \n Internal-Storage : 32 GB \n RAM :2 GB \t Processor : 2.3 Quad Core "
            });


        
        
        
        }
    }
}
