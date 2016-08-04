using UnityEngine;
using System.Collections;

public class EventManager{

	private static EventManager INSTANCE = null;

	private EventManager(){

	}

	public static EventManager getInstance(){
		if (INSTANCE == null) {
			INSTANCE = new EventManager ();
		}
		return INSTANCE;
	}

	public delegate void ProductionBuildingListener (B_ProducerController target);
	public event ProductionBuildingListener OnProductionBuildingUpdateListener;

	public void onProductionBuildingUpdate(B_ProducerController target){
		if (OnProductionBuildingUpdateListener != null) {
			OnProductionBuildingUpdateListener (target);
		}
	}
}
