using UnityEngine;
using System.Collections;

public class B_ProducerController : MonoBehaviour {

	public enum PRODUCER_BUILDING { 
		FARM,
		GENERATOR,
		WATERWELL
	};

	protected PRODUCER_BUILDING producerBuildingType;
	protected int life;
	protected int level;
	protected string name;
	protected int production;

	void Start () {
	
	}

	void Update () {
		
	}

	protected void UpdateProducerBuilding(){
		this.level++;
	}

	protected void UpdateProducerName(string name){
		this.name = name;
	}

	protected void Init(PRODUCER_BUILDING producerBuildingType, string name){
		Logger.getInstance().log("Building [name:"+name+"]|[life:"+life+"]|[level:"+level+"]");
		this.producerBuildingType = producerBuildingType;
		this.life = Constants.C_STARTLIFE;
		this.name = name;
		this.level = 1;
		this.production = 0;
		InvokeRepeating ("updateProduction", 5, 5);
	}

	private void updateProduction(){
		if (this.level < 0) {
			CancelInvoke ();
			Logger.getInstance ().log ("Building has been destroyed");
		} else {
			production += 1*this.level;
			Logger.getInstance ().log ("Production: " + this.production);
		}
	}
		
}
