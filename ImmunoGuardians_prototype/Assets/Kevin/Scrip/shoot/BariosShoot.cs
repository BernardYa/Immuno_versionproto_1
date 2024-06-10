using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BariosShoot : MonoBehaviour
{
    GameObject CurrentBullet;
    
    public GameObject bullet1;

    public GameObject bullet2;

    public Transform shootpoint;
    // public float shootSpeed;
   // [SerializeField] AudioSource SonidoDis;
    public AudioClip sound1; // Sonido para bullet1
    public AudioClip sound2; // Sonido para bullet2

    private AudioSource audioSource;

    private void Start()
    {
        CurrentBullet = bullet1;
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet();
           // SonidoDis.Play();
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

        PlayShootSound();
    }

    private void PlayShootSound()
    {
        if (CurrentBullet == bullet1)
        {
            audioSource.clip = sound1;
        }
        else if (CurrentBullet == bullet2)
        {
            audioSource.clip = sound2;
        }

        audioSource.Play();
    }
}

