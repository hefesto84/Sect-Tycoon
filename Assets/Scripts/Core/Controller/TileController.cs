using UnityEngine;
using System.Collections;

public class TileController : MonoBehaviour {

	private bool b_isFallingFromTheSky = false;
	private Vector3 m_source, m_destination;

	void Start () {
	
	}

	void FixedUpdate(){
		if (this.transform.position.Equals (m_destination)) {
			b_isFallingFromTheSky = false;
		}
		fallFromSky ();
	}

	void Update () {
		
	}

	public void Animate(Vector3 source, Vector3 destination){

		Logger.getInstance ().log ("Animated tile!");

		m_source = source;
		m_destination = destination;
		b_isFallingFromTheSky = true;

	}

	/* TODO: Make this method more...well...more Candy Crash style. */

	private void fallFromSky(){
		if (b_isFallingFromTheSky) {
			Vector3 pos = this.transform.position;
			pos.x = m_destination.x;
			pos.y = pos.y - Constants.C_MAX_VELOCITY_WHEN_FALLING;
			pos.z = m_destination.z;
			this.transform.position = pos;
		}
	}

}
