using UnityEngine;
using System.Collections;

public class MoveMe : MonoBehaviour {

public	Vector3 speed = new Vector3 (0f, 0f, 0f);
	public GameObject[] moveables;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (GetComponent<Transform>().position);


        // instead of doing GameObject.GetComponent<Transform>
        //GetComponent<Transform> ().position += speed;
        //transform.Translate (speed);

        foreach (GameObject thingToMove in moveables)
        {
            thingToMove.transform.Translate(speed);
        }    
            foreach (GameObject thingToMove in moveables) {
            thingToMove.transform.position = new Vector3(Mathf.PingPong(Time.time, 3), transform.position.y, transform.position.z);

        }


    }
}