using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {

	public GameObject panBuildingSelector;

	void Start () {
		
	}

	void Update () {
	
	}

	public void OnClick(GameObject target){
		if (target.name.Equals ("btnPanSelectBuildingClose")) {
			panBuildingSelector.SetActive (false);
		}
	}

	public void OpenBuildingSelector(TileController tileController){
		panBuildingSelector.SetActive (true);
		panBuildingSelector.GetComponent<PanBuildingSelectorController> ().AddTarget (tileController);
	}
}
