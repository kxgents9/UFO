using UnityEngine;
using System.Collections;

public class UFOController : MonoBehaviour {

	public float forceValue;
	public ScoreManager scoremanager;

	private Rigidbody2D rigidbody2D = null;

    public int state = 1;

    // Use this for initialization
    void Start () {
		rigidbody2D = this.GetComponent<Rigidbody2D> ();
    }

	// Update is called once per frame
	void Update () {

		Vector2 force2D = Vector2.zero;

		if(Input.GetKey(KeyCode.W)){
			force2D.y += forceValue;
		}

		if(Input.GetKey(KeyCode.S)){
			force2D.y -= forceValue;
		}

		if(Input.GetKey(KeyCode.A)){
			force2D.x -= forceValue;
		}

		if(Input.GetKey(KeyCode.D)){
			force2D.x += forceValue;
		}

		rigidbody2D.AddForce(force2D);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
        scoremanager.AddScore(100);
        if (0 < state && state < 5)
        {
            other.transform.position = new Vector3(Random.Range(-11, 11), Random.Range(-11, 11), 0);
            state++;
        }
        else
        {
            other.gameObject.SetActive(false);
            Debug.Log("Done");
        }
    }
}
