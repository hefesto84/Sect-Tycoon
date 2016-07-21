using UnityEngine;
using System.Collections;

public class WorldRendererController : MonoBehaviour {

	public GameObject baseTile;
	private int m_tilesCreated = 0;
	private GameObject m_baseWorld;

	void Start () {
	
	}

	void Update () {
	
	}

	public void Render(World world){

		createBaseWorld ();

		Logger.getInstance ().log ("Rendering world...");
		for (int i = 0; i < world.height; i++) {
			for (int j = 0; j < world.width; j++) {
				createTile (i, j);
			}
		}
		Logger.getInstance ().log ("World rendered...");
	}

	public void Render(Tile[,] tiles){
		Logger.getInstance ().log ("Rendering subworld...");
	}
		
	/* TODO: This method needs optimization. If we animate a lot of game objects with a collider attached, profiler says us that 
	 * we are doing too much work.
	 */

	private void createTile(int i, int j){

		GameObject go = GameObject.Instantiate (baseTile);
		go.name = "tile-" + i + "," + j;
		go.transform.SetParent (m_baseWorld.transform);

		int initialHeight = Random.Range (10, 20);

		/* In fact, the tileSize.y value hasn't utility because the tile is a perfect quad. */
		/* In the future, if we want to add support for non-quad tiles, this value will be needed. */

		Vector3 from = new Vector3 (i * go.GetComponent<MeshCollider> ().bounds.size.x, initialHeight, j * go.GetComponent<MeshCollider> ().bounds.size.x);
		Vector3 to = new Vector3 (i * go.GetComponent<MeshCollider> ().bounds.size.x, 0, j * go.GetComponent<MeshCollider> ().bounds.size.x);

		Vector3 position = new Vector3 (i * go.GetComponent<MeshCollider> ().bounds.size.x, initialHeight, j * go.GetComponent<MeshCollider> ().bounds.size.x);
		go.transform.localPosition = position;

		((TileController)go.AddComponent<TileController> ()).Animate (from, to);
	
		m_tilesCreated++;
	}
		
	private void createBaseWorld(){
		
		GameObject.DestroyImmediate (m_baseWorld);
		m_baseWorld = new GameObject ();
		m_baseWorld.name = "m_baseWorld";
		m_baseWorld.transform.SetParent (this.transform);

	}
}
