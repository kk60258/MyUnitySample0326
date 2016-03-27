using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public Humanoid[] humanoid;
    // Use this for initialization
    void Start () {
        createHumanoid();
    }
	
	// Update is called once per frame
	void Update () {

    }

    void createHumanoid() {
        foreach (Humanoid h in humanoid) {
            Humanoid obj = Instantiate(h, Vector3.zero, Quaternion.identity) as Humanoid;
            obj.setGameController(this);
            obj.transform.parent = transform;
        }
    }
}
