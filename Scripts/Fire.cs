using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public AudioClip liveFire;
    public float fireRate;
    protected float lastFireTime;

    public int range;
    public int damage;

    public GameObject projectile;

    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        lastFireTime = Time.time - 10;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && (Time.time - lastFireTime)> fireRate)
        {
            lastFireTime = Time.time;
            Shoot();
        }
    }

    public void Shoot()
    {
        GetComponent<AudioSource>().PlayOneShot(liveFire);
        // Instantiate the projectile at the position and rotation of this transform
        GameObject clone;
        clone = Instantiate(projectile, transform.position, transform.rotation);
            
    }
}

    /*private void processHit(GameObject hitObject) {
		if (hitObject.GetComponent<Player> () != null) {
			hitObject.GetComponent<Player> ().TakeDamage (damage);
		}
		if (hitObject.GetComponent<Robot> () != null) {
			hitObject.GetComponent<Robot> ().TakeDamage (damage);
		}

	} */

