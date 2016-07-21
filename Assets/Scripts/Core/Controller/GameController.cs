using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private World world;

	private WorldRendererController worldRendererController;

	void Awake(){
		worldRendererController = this.GetComponent<WorldRendererController> ();
	}

	void Start () {
		InitGame ();
	}

	void Update () {
	
	}

	public void InitGame(){
		Logger.getInstance ().log ("Initializing World...");
		world = new World ();
		world.Init ();
		Logger.getInstance ().log ("World initialized.");
		worldRendererController.Render (world);
		Logger.getInstance ().log ("World rendered.");
	}
}
