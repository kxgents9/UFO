using UnityEngine;
using System.Collections;

public class PickupController : MonoBehaviour {

	public float RotateSpeed;

    //public GameObject Pickup;

    float x, y, z;
    Vector3 pos, newpos;

    // Use this for initialization
    void Start () {
        x = Random.Range(-11, 11);
        y = Random.Range(-11, 11);
        z = 0;
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate (new Vector3(0,0,RotateSpeed*Time.deltaTime));
	}

    
}
