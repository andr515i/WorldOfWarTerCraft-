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

    //world map
    beach.AddEdge("sea", mainBase);
    mainBase.AddEdge("right", challenge1);
    challenge1.AddEdge("home", mainBase);

    mainBase.AddEdge("left", challenge2);
    challenge2.AddEdge("home", mainBase);
    challenge2.AddEdge("deeper", challenge3);
    challenge3.AddEdge("back", challenge2);
    challenge3.AddEdge("home", mainBase);
    
    //Needs an item to get past this point, from challenge3
    mainBase.AddEdge("deeper", challenge4);
    challenge4.AddEdge("deeper", challenge5);
    
    //needs another item, you get it from challenge6
    challenge4.AddEdge("riptide", challenge7);
    challenge4.AddEdge("home", mainBase);

    challenge7.AddEdge("back", challenge4);
    challenge7.AddEdge("home", mainBase);

    //no item.
    challenge5.AddEdge("shipyard", challenge6);
    challenge5.AddEdge("home", mainBase);
    challenge5.AddEdge("back", challenge4);

    //another item here, though you need it from challenge8
    challenge5.AddEdge("caves", challenge9);
    
    challenge6.AddEdge("abyss", challenge8);
    challenge6.AddEdge("home", mainBase);
    challenge6.AddEdge("back", challenge5);

    //item required from challenge7
    challenge8.AddEdge("home", mainBase);
    challenge8.AddEdge("back", challenge6);
    challenge9.AddEdge("home", mainBase);
    challenge9.AddEdge("back", challenge5);
    challenge9.AddEdge("beach", challengeFin);

    
    //npcs in mainBase
    mainBase.AddEdge("ariel", npc1);   
    npc1.AddEdge("back", mainBase);  
    mainBase.AddEdge("billy", npc2);
    npc2.AddEdge("back", mainBase); 
    mainBase.AddEdge("casper", npc3);
    npc3.AddEdge("back", mainBase); 
    mainBase.AddEdge("diddy", npc4);
    npc4.AddEdge("back", mainBase); 
    mainBase.AddEdge("egor", npc5); 
    npc5.AddEdge("back", mainBase); 
    mainBase.AddEdge("ferb", npc6);
    npc6.AddEdge("back", mainBase); 
    mainBase.AddEdge("gahat", npc7);
    npc7.AddEdge("back", mainBase); 
    mainBase.AddEdge("harold", npc8);
    npc8.AddEdge("back", mainBase); 
    mainBase.AddEdge("ian", npc9);
    npc9.AddEdge("back", mainBase); 
    mainBase.AddEdge("john", npcFin);
    npcFin.AddEdge("back", mainBase); 
    
    this.beach = beach;
  }
  
  public Space GetBeach() {
    return beach;
  }
}
