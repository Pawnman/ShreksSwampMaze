using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamMechanics : MonoBehaviour
{
    public Transform Bullet;
    public Transform BulletHolder;
    public float BulletSpeed;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Transform BulletTrans = Instantiate(Bullet, BulletHolder.position, BulletHolder.rotation);
            Rigidbody BulletRB = BulletTrans.GetComponent<Rigidbody>();
            BulletRB.AddRelativeForce(Vector3.forward * BulletSpeed);
            audio.Play();
        }
    }
}
