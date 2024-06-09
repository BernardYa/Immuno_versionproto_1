using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala2 : MonoBehaviour
{
    public GameObject bala;
    public float balaveloci;
    public Transform shootpoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet();
        }
    }
    private void ShootBullet()
    {
        var bala2 = Instantiate(bala, shootpoint);
        bala2.transform.SetParent(null);
        bala2.GetComponent<Rigidbody2D>().velocity = bala2.transform.right * balaveloci;
    }
}
