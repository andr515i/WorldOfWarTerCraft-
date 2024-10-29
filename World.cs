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
    Space npcFin       = new Space("Jack the Jellyfish");
    
    beach.AddEdge("sea", mainBase);
    mainBase.AddEdge("left", challenge2);
    mainBase.AddEdge("right", challenge1);
    mainBase.AddEdge("deeper", challenge4);
    .AddEdge("left", mainBase);
    mainBase.AddEdge("left", mainBase);
    mainBase.AddEdge("left", mainBase);
    mainBase.AddEdge("left", mainBase);
  
    
    this.marineBase = marineBase;
  }
  
  public Space GetMarineBase () {
    return marineBase;
  }
}
