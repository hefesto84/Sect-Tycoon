using UnityEngine;
using System.Collections;

public class World {

	public Tile[,] tiles { get; set; }

	public World(){
		Logger.getInstance ().log ("World instance created.");
	}

	public void Init(){
		createWorld ();
	}

	public void Init(string cfg_file){
		createWorld (cfg_file);
	}

	private void createWorld(){

		Logger.getInstance ().log ("Creating world...");
		this.tiles = new Tile[Constants.C_DEFAULT_WORLD_TILES_W,Constants.C_DEFAULT_WORLD_TILES_H];

		for (int i = 0; i < Constants.C_DEFAULT_WORLD_TILES_H; i++) {
			for(int j = 0; j<Constants.C_DEFAULT_WORLD_TILES_W; j++){

				Logger.getInstance ().log ("Populating inner tiles...");

				this.tiles [i, j] = new Tile ();
				this.tiles[i,j].tiles = new Tile[Constants.C_DEFAULT_WORLD_TILES_W, Constants.C_DEFAULT_WORLD_TILES_H];

				for (int k = 0; k < Constants.C_DEFAULT_WORLD_TILES_H; k++) {
					for (int l = 0; l < Constants.C_DEFAULT_WORLD_TILES_W; l++) {
						this.tiles [i, j].tiles [k, l] = new Tile ();
					}
				}


			}
		}
		Logger.getInstance ().log ("World created...");

	}

	private void createWorld(string cfg_file){
		// TODO: Method to create a world from a config file must be implemented
	}

}
