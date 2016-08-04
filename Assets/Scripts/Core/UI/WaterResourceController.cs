using UnityEngine;
using System.Collections;

public class WaterResourceController : MonoBehaviour {

	void Start () {
		EventManager.getInstance ().OnProductionBuildingUpdateListener += onProductionBuildingUpdateHandler;
	}

	void Update () {
	
	}

	private void onProductionBuildingUpdateHandler(B_ProducerController target){
		Debug.Log ("Hola");
	}
}
