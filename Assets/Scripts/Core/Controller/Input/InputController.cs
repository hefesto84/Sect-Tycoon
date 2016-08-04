using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			sendRayCast ();
		}
	}

	private void sendRayCast(){
		
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		/* We use bitmask for detect only objects in layer 8 ( Tile )    */
		/* Layers must be obtained by shiftting the real number of the layer */

		if (Physics.Raycast (ray, out hit, 100, (1 << 8))) {
			
			Debug.DrawLine (ray.origin, hit.point);
			GameObject target = hit.collider.transform.gameObject;

			TileController tileController = target.GetComponent<TileController> ();

			if (tileController != null) {
				this.gameObject.GetComponent<UIController> ().OpenBuildingSelector (tileController);
			}

		}

	}


}
