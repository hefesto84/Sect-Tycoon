using UnityEngine;
using System.Collections;

public class B_FarmController : B_ProducerController {

	void Awake(){
		
	}

	void Start () {
		Logger.getInstance ().log ("FarmController enabled");
		Init (PRODUCER_BUILDING.FARM,"Farm 1");
	}

	void Update () {
	
	}
}
