using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Playermovement movement;

    // Use this for initialization
    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Öbstacle")
        {
            movement.enabled = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
