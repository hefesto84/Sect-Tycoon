using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private World world;

	private WorldRendererController worldRendererController;
	private ResourcesManager resourcesManager;

	void Awake(){
		worldRendererController = this.GetComponent<WorldRendererController> ();
	}

	void Start () {
		InitGame ();
	}

	void Update () {
	
	}

	public void InitGame(){
		InitWorld ();
	}

	public void InitWorld(){
		Logger.getInstance ().log ("Initializing World...");
		world = new World ();
		world.Init ();
		Logger.getInstance ().log ("World initialized.");
		Logger.getInstance ().log ("Initializing listeners.");
		initListeners ();
		worldRendererController.Render (world);
		Logger.getInstance ().log ("World rendered.");

	}

	private void initListeners(){
		EventManager.getInstance ().OnProductionBuildingUpdateListener += ResourcesManager.getInstance().onProductionBuildingUpdateHandler;
	}
}
