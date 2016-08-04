using UnityEngine;
using System.Collections;

public class B_ProducerController : MonoBehaviour {
	
	private Production production;

	void Start () {
	
	}

	void Update () {
		
	}

	protected void Init(Production.PRODUCER_BUILDING producerBuildingType, string name){
		this.production = new Production (producerBuildingType,name);
		Logger.getInstance().log("Building [name:"+name+"]|[life:"+production.life+"]|[level:"+production.level+"]");
	}

}
