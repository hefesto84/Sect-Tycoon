using UnityEngine;
using System.Collections;

public class PanBuildingSelectorController : MonoBehaviour {

	private TileController m_target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddTarget(TileController tileController){
		Logger.getInstance ().log ("Target attached to PanBuildingSelector");
		m_target = tileController;
	}

	public void AddBuilding(GameObject buildingType){
		m_target.AddPlaceholderCube ();
		Logger.getInstance ().log (this.gameObject.name);
	}
}
