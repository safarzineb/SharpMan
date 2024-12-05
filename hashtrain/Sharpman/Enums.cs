namespace Sharpman;

public enum Direction
{
    North,  //cardinals for direction
    West,  
    South,
    East
}

public enum TileType
{
    Empty,      //empty tile. Walkable even!
    Wall,       //Collision Master
    Plus,       //Yum, and not optional for winning
    Hashtag,    //Bloodfury
    Letter,     //For On Screen text
    Sharpman,   //Our Hero
    Java,       //Our Nemesis
    Cherry      //On top
}

