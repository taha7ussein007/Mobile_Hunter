using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_Hunter.Model
{
  public  class Samsung
    {
        public int ID { get; set; }
      public  string PName { get; set; }
       public string PImage { get; set; }
       public string  Specs { get; set; }
       public int Price { get; set; }
    }


    public class Data
    {
        public List<Samsung> myList
        {
    get{
        return privateList;
    }
         }

        private List<Samsung> privateList = new List<Samsung>();

      
        public void Data_in() { 
        myList.Add(new Samsung()  {  ID =0,    PName = "Galaxy A5 Duos",   PImage = "Assets/sam-1.jpg",  Price = 3100, 
        Specs = "OS : Android 4.4.4 KitKAt \n Back-Camera : 13 MB With LED Flash  \n Front-Camera : 5 MB  \n Internal-Storage : 16 GB \n RAM :2 GB \t Processor : 1.2 Quad Core " } );



        myList.Add(new Samsung()
        {
            ID = 1,
            PName = "Galaxy A7",
            PImage = "Assets/sam-2.jpg",
            Price = 5775,
            Specs = "OS : Android 4.4.4 KitKAt \n Back-Camera : 16  MB With LED Flash  \n Front-Camera : 3.7 MB  \n Internal-Storage : 32 GB \n RAM :3 GB \t Processor : 2.7 Quad Core "
        });

        myList.Add(new Samsung()
        {
            ID = 2,
            PName = "Galaxy Ace 4",
            PImage = "Assets/sam-3.jpg",
            Price = 875,
            Specs = "OS : Android 4.4.2 KitKAt \n Back-Camera : 5 MB With LED Flash  \n Front-Camera : VGA  \n Internal-Storage : 16 GB \n RAM :2 GB \t Processor : 1.2 Quad Core "
        });

        myList.Add(new Samsung()
        {
            ID = 3,
            PName = "GALAXY ACE 4 LITE",
            PImage = "Assets/sam-4.jpg",
            Price = 800,
            Specs = "OS : Android 4.4.2 KitKAt \n Back-Camera : 3.15 MB With LED Flash  \n Front-Camera : NO  \n Internal-Storage : 4 GB \n RAM :512 MG \t Processor : 1.2 Quad Core "
        });


        myList.Add(new Samsung()
        {
            ID = 4,
            PName = "GALAXY E7",
            PImage = "Assets/sam-5.jpg",
            Price = 2750,
            Specs = "OS : Android 4.4.4 KitKAt \n Back-Camera : 13 MB With LED Flash  \n Front-Camera : 5 MB  \n Internal-Storage : 16 GB \n RAM :2 MG \t Processor : 1.2 Quad Core "
        });






        myList.Add(new Samsung()
        {
            ID = 5,
            PName = "Galaxy Grand Neo Plus ",
            PImage = "Assets/sam-6.jpg",
            Price = 1345,
            Specs = "OS : Android 4.2 GellyBeen \n Back-Camera : 5 MB With LED Flash  \n Front-Camera : VAGA  \n Internal-Storage : 8 GB \n RAM :1 MG \t Processor : 1.2 Quad Core "
        });



        myList.Add(new Samsung()
        {
            ID = 6,
            PName = "GALAXY K ZOOM",
            PImage = "Assets/sam-7.jpg",
            Price = 3500,
            Specs = "OS : Android 4.4.2 KitKAt \n Back-Camera : 20.7  MB With LED Flash  \n Front-Camera : 2 MB  \n Internal-Storage : 8 GB \n RAM :2 MG \t Processor : 1.2 Quad Core "
        });





      



        myList.Add(new Samsung()
        {
            ID = 7,
            PName = "GALAXY E7",
            PImage = "Assets/sam-8.jpg",
            Price = 3100,
            Specs = "OS : Android 4.4.4 KitKAt \n Back-Camera : 13 MB With LED Flash  \n Front-Camera : 5 MB  \n Internal-Storage : 16 GB \n RAM :2 MG \t Processor : 1.2 Quad Core "
        });



        }
    }
}
