using UnityEngine;
using System.Collections;

public class Production{

	public enum PRODUCER_BUILDING { 
		FARM,
		GENERATOR,
		WATERWELL
	};

	public PRODUCER_BUILDING producerBuildingType;
	public int life;
	public int level;
	public string name;
	public int production;

	public Production(PRODUCER_BUILDING producerBuildingType, string name = "noname"){
		this.life = Constants.C_STARTLIFE;
		this.level = 1;
		this.name = name;
		this.producerBuildingType = producerBuildingType;
	}

}
