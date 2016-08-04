using UnityEngine;
using System.Collections;

public class B_WaterWellController : B_ProducerController, IB_Producer  {

	void Start () {
		Logger.getInstance ().log ("WaterWellController enabled");
		Init (Production.PRODUCER_BUILDING.WATERWELL,"WaterWell 1");
	}

	void Update () {
	
	}

	public void UpdateProduction(){

	}
}
