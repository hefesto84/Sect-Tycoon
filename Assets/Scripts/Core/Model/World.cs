using UnityEngine;
using System.Collections;

public class World {

	public Tile[,] tiles 	{	get; set; 	}
	public int width 		{	get; private set;	}
	public int height 		{	get; private set;	}

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

		this.width 	= Constants.C_DEFAULT_WORLD_TILES_W;
		this.height = Constants.C_DEFAULT_WORLD_TILES_H;

		this.tiles = new Tile[this.width,this.height];

		for (int i = 0; i < this.height; i++) {
			for(int j = 0; j<this.width; j++){

				Logger.getInstance ().log ("Populating inner tiles...");

				this.tiles [i, j] = new Tile ();
				this.tiles[i,j].tiles = new Tile[this.width, this.height];

				for (int k = 0; k < this.height; k++) {
					for (int l = 0; l <this.width; l++) {
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
