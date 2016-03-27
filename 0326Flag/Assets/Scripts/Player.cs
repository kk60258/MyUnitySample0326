using UnityEngine;
using System.Collections;

public class Player : Humanoid {

    //public GameObject[] myUnits;

    // Use this for initialization
    public override void onStart() {
        Debug.Log("Player onStart+");
        Debug.Log("Player onStart-");
    }

    // Update is called once per frame
    public override void onUpdate () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Player spawn");
            Vector3 cameraPointP = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 p = new Vector3(cameraPointP.x, cameraPointP.y, transform.position.z);

            GameObject obj = Instantiate(myUnits[0], p, Quaternion.identity) as GameObject;
            obj.transform.parent = gameController.transform;
        }
    }
}
