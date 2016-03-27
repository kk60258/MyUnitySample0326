using UnityEngine;
using System.Collections;

public abstract class Humanoid : MonoBehaviour {

    protected GameController gameController;
    public GameObject[] myUnits;
    // Use this for initialization
    void Start () {
        Debug.Log("Humanoid start+");
        onStart();
        Debug.Log("Humanoid start-");
    }
	
	// Update is called once per frame
	void Update () {
        onUpdate();
    }

    public abstract void onStart();
    public abstract void onUpdate();

    public void setGameController(GameController controller) {
        gameController = controller;
    }
}
