using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BariosShoot : MonoBehaviour
{
    GameObject CurrentBullet;
    
    public GameObject bullet1;

    public GameObject bullet2;

    public Transform shootpoint;
    // public float shootSpeed;
    [SerializeField] AudioSource SonidoDis;



    private void Start()
    {
        CurrentBullet = bullet1;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet();
            SonidoDis.Play();
        }
     
           
            
    
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CurrentBullet = bullet1;
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CurrentBullet = bullet2;
            
        }
    }



    private void ShootBullet()
    {
        var bullet = Instantiate(CurrentBullet , shootpoint);
        bullet.transform.SetParent(null);
        //bullet.GetComponent<Rigidbody2D>().velocity = shootpoint.right * shootSpeed;
    }

}
