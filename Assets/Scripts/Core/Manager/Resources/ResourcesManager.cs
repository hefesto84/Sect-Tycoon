using UnityEngine;
using System.Collections;

public class ResourcesManager {

	private static ResourcesManager INSTANCE = null;

	private ResourcesManager(){

	}

	public static ResourcesManager getInstance(){
		if (INSTANCE == null) {
			INSTANCE = new ResourcesManager ();
		}
		return INSTANCE;
	}

	public void onProductionBuildingUpdateHandler(B_ProducerController target){

		System.Type type = target.GetType ();

		if (type.Equals (typeof(B_FarmController))) {
			Logger.getInstance().log ("FarmController");
		} else if (type.Equals (typeof(B_GeneratorController))) {
			Logger.getInstance().log ("GeneratorController");
		} else if (type.Equals (typeof(B_WaterWellController))) {
			Logger.getInstance().log ("WaterWellController");
		}
		
	}
}
