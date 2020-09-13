using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    // subclass of ship parts
    public enum PartType {
        EMPTY, BLOCK
    }

    // subclass ShipTile to store data
    public class ShipTile
    {
        public PartType partID;

        // store ordered pair of tiles considered the same part in damage calculation
        public Vector2[] connectList = new Vector2[8];
        // store ordered pair of tiles considered adjacent in damage calcualtion
        public Vector2[] adjacentList = new Vector2[8];

        public float submass = 0f;
        public float hp = 0f;

        // Constructor
        public ShipTile(PartType id, Vector2[] con, Vector2[] adj, int mas, int life) {
            partID = id;
            connectList = con;
            adjacentList = adj;
            submass = mas;
            hp = life;
        }

        //Default Constructor
        public ShipTile() {
            partID = PartType.EMPTY;
            adjacentList[0] = Vector2.up;
            adjacentList[1] = Vector2.down;
            adjacentList[2] = Vector2.left;
            adjacentList[3] = Vector2.right;
            submass = 1;
            hp = 100;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ShipTile[,] ship = new ShipTile[64, 64];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Update called upon possible change in ship data
    void Recalculate()
    {

    }
}
