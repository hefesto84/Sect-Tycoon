using UnityEngine;
using System.Collections;

public class Tile{

	public enum TileType { 
		EMPTY, 			// This tile is empty. Users can interact with it.
		LOCKED, 		// This tile is temporary locked but not blocked.
		BLOCKED, 		// This tile is not interactable.
		DEACTIVATED 	// This tile is temporary deactivated but not locked neither blocked.
	}
		
	public TileType type 	{ get; set; }

	public Tile[,] tiles 	{ get; set; }

	/* Constructors */

	public Tile(){

	}

	public Tile(TileType type){

	}

	/* Methods */

}
