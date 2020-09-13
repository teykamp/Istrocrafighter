// ShipTile object that populates an 2d array to describe a ship
public class ShipTile
{
    // Name of instance, possible external enum resource?
    private string id = "";
    // Arrays of ordered pairs 
    private int[][] connectList = new int[][];
    private int[][] adjacentList = new int[][];
    private int hp = 0;
    private int mass = 0;

    // Default Constructor
    public ShipTile()
    {
        
    }
}
