using UnityEngine;
using System.Collections;

public class BaseUnit : MonoBehaviour {

    GameObject target;
    
	// Use this for initialization
	void Start () {
        target = GameObject.FindWithTag("Flag1");
        Debug.Log("BaseUnit + " + target);
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = target.transform.localPosition - transform.localPosition;
        transform.localPosition += direction.normalized * getSpeed() * Time.deltaTime;
    }

    public float getSpeed() {
        return 20f;
    }
}
