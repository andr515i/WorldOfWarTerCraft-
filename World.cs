/* World class for modeling the entire in-game world
 */

class World {
  Space beach ;
  
  public World () {
    Space beach        = new Space("Dirty beach");
    Space mainBase     = new Space("Coralreef remains");
    Space challenge1   = new Space("Polluted Paradise");
    Space challenge2   = new Space("Plastic bottoms");
    Space challenge3   = new Space("Sandy loam");
    Space challenge4   = new Space("Rip current");
    Space challenge5   = new Space("Sargasso Sea of Waste");
    Space challenge6   = new Space("Sunken shipyard");
    Space challenge7   = new Space("Plastic trench");
    Space challenge8   = new Space("The Shimmering Trash Abyss");
    Space challenge9   = new Space("Hidden Plastic Parasite");
    Space challengeFin = new Space("Clean beach");

    Space npc1         = new Space("Ariel Angler");
    Space npc2         = new Space("Billy Blobfish");
    Space npc3         = new Space("Casper Clam");
    Space npc4         = new Space("Diddy Dolphin");
    Space npc5         = new Space("Egor Eel");
    Space npc6         = new Space("Ferb the Flying Fish");
    Space npc7         = new Space("Gahat the Ganges Shark");
    Space npc8         = new Space("Harold Herring");
    Space npc9         = new Space("Ian Icefish");
    Space npcFin       = new Space("John Dory");

    Space item1        = new Space("Plastic wrapper");
    Space item2        = new Space("Plastic wrapper");
    Space item3        = new Space("Plastic wrapper");
    Space item4        = new Space("Plastic wrapper");
    Space item5        = new Space("Plastic wrapper");
    Space item6        = new Space("Plastic wrapper");
    Space item7        = new Space("Plastic wrapper");
    Space item8        = new Space("Plastic wrapper");
    Space item9        = new Space("Plastic wrapper");

    //world map
    beach.AddEdge("sea", mainBase);
    mainBase.AddEdge("home", mainBase);
    mainBase.AddEdge("right", challenge1);
    mainBase.AddEdge("left", challenge2);
    mainBase.AddEdge("deeper", challenge4);

    //every challange besides the first one, needs an item to access.
    challenge1.AddEdge("home", mainBase);

    challenge2.AddEdge("home", mainBase);
    challenge2.AddEdge("deeper", challenge3);

    challenge3.AddEdge("back", challenge2);
    challenge3.AddEdge("home", mainBase);
    
    challenge4.AddEdge("deeper", challenge5);
    challenge4.AddEdge("riptide", challenge7);
    challenge4.AddEdge("home", mainBase);

    challenge5.AddEdge("shipyard", challenge6);
    challenge5.AddEdge("home", mainBase);
    challenge5.AddEdge("back", challenge4);
    challenge5.AddEdge("caves", challenge9);

    challenge6.AddEdge("abyss", challenge8);
    challenge6.AddEdge("home", mainBase);
    challenge6.AddEdge("back", challenge5);

    challenge7.AddEdge("back", challenge4);
    challenge7.AddEdge("home", mainBase);
    
    challenge8.AddEdge("home", mainBase);
    challenge8.AddEdge("back", challenge6);

    challenge9.AddEdge("home", mainBase);
    challenge9.AddEdge("back", challenge5);
    challenge9.AddEdge("beach", challengeFin);

    challengeFin.AddEdge("back", challenge9);
    challengeFin.AddEdge("home", mainBase);

    
    //npcs in mainBase
    mainBase.AddEdge("ariel", npc1);
    mainBase.AddEdge("billy", npc2); 
    mainBase.AddEdge("casper", npc3); 
    mainBase.AddEdge("diddy", npc4); 
    mainBase.AddEdge("egor", npc5); 
    mainBase.AddEdge("ferb", npc6); 
    mainBase.AddEdge("gahat", npc7); 
    mainBase.AddEdge("harold", npc8); 
    mainBase.AddEdge("ian", npc9); 
    mainBase.AddEdge("john", npcFin);

        npc1.AddEdge("back", mainBase);
        npc2.AddEdge("back", mainBase);
        npc3.AddEdge("back", mainBase);
        npc4.AddEdge("back", mainBase);
        npc5.AddEdge("back", mainBase);
        npc6.AddEdge("back", mainBase);
        npc7.AddEdge("back", mainBase);
        npc8.AddEdge("back", mainBase);
        npc9.AddEdge("back", mainBase);
        npcFin.AddEdge("back", mainBase);

        this.beach = beach;

  //Items in world
  challenge1.AddEdge("trash", item1);
    item1.AddEdge("back", challenge1);
    item1.AddEdge("home", mainBase);

  challenge2.AddEdge("trash", item2);
    item2.AddEdge("back", challenge2);
    item2.AddEdge("home", mainBase);

  challenge3.AddEdge("trash", item3);
    item3.AddEdge("back", challenge3);
    item3.AddEdge("home", mainBase);

  challenge4.AddEdge("trash", item4);
    item4.AddEdge("back", challenge4);
    item4.AddEdge("home", mainBase);

  challenge5.AddEdge("trash", item5);
    item5.AddEdge("back", challenge5);
    item5.AddEdge("home", mainBase);

  challenge6.AddEdge("trash", item6);
    item6.AddEdge("back", challenge6);
    item6.AddEdge("home", mainBase);

  challenge7.AddEdge("trash", item7);
    item7.AddEdge("back", challenge7);
    item7.AddEdge("home", mainBase);

  challenge8.AddEdge("trash", item8);
    item8.AddEdge("back", challenge8);
    item8.AddEdge("home", mainBase);

  challenge9.AddEdge("trash", item9);
    item9.AddEdge("back", challenge9);
    item9.AddEdge("home", mainBase);
  }
  
  public Space GetBeach() {
    return beach;
  }
}
