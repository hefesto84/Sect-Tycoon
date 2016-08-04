using UnityEngine;
using System.Collections;

public class B_FarmController : B_ProducerController, IB_Producer {

	void Start () {
		Logger.getInstance ().log ("FarmController enabled");
		Init (Production.PRODUCER_BUILDING.FARM,"Farm 1");
		InvokeRepeating ("UpdateProduction", 5, 5);
	}

	void Update () {
	
	}

	public void UpdateProduction(){
		EventManager.getInstance ().onProductionBuildingUpdate (this);
	}
}
