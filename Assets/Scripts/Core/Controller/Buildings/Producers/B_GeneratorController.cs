using UnityEngine;
using System.Collections;

public class B_GeneratorController : B_ProducerController, IB_Producer  {

	void Start () {
		Logger.getInstance ().log ("GeneratorController enabled");
		Init (Production.PRODUCER_BUILDING.GENERATOR,"Generator 1");
	}

	void Update () {
	
	}

	public void UpdateProduction(){

	}
}
