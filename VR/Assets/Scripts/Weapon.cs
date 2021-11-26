using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] public GameObject bulletSpawn;
    [SerializeField] private float firePower;
    [SerializeField] public XRDeviceSimulatorControls simulatorActions;
    [SerializeField] public XRIDefaultInputActions vrInputs;


   
    private float nextFire = 0;
    private float fireRate = 0.5f;
    

    // Start is called before the first frame update
    

    void Awake()
    {
        simulatorActions = new XRDeviceSimulatorControls();
        vrInputs = new XRIDefaultInputActions();
    }

    

    private void OnEnable()
    {
       

        simulatorActions.Enable();
        vrInputs.Enable();

    }
    private void OnDisable()
    {
        simulatorActions.Disable();
        vrInputs.Disable();
    }
    // Update is called once per frame
    void Update()
    {


    }

    public void Shoot()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.transform.forward * firePower);
            Destroy(bullet, 2f);
        }


    }


}
