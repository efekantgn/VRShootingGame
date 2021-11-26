using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class Deneme : MonoBehaviour
{
    [SerializeField] private XRNode xRNode = XRNode.LeftHand;
    [SerializeField] private XRNode xRNode2 = XRNode.RightHand;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] protected Transform bulletSpawn;
    [SerializeField] private float firePower;

    private List<InputDevice> devices = new List<InputDevice>();
    private List<InputDevice> devices2 = new List<InputDevice>();
    private InputDevice leftHand;
    private InputDevice rightHand;
    private float nextFire=0;
    private float fireRate=0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void GetDevice()
    {

        InputDevices.GetDevicesAtXRNode(xRNode, devices);
        InputDevices.GetDevicesAtXRNode(xRNode2, devices2);
        leftHand = devices.First();
        rightHand = devices2.First();
       
    }

    private void OnEnable()
    {
        if (!leftHand.isValid)
        {
            GetDevice();
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!leftHand.isValid)
        {
            GetDevice();
        }

        bool leftHandTrigger = false;
        bool leftHandGrip = false;
        bool rightHandTrigger = false;
        bool rightHandGrip = false;
        if ((leftHand.TryGetFeatureValue(CommonUsages.triggerButton, out leftHandTrigger) && leftHandTrigger && leftHand.TryGetFeatureValue(CommonUsages.gripButton, out leftHandGrip) && leftHandGrip)
            || (rightHand.TryGetFeatureValue(CommonUsages.triggerButton, out rightHandTrigger) && rightHandTrigger && rightHand.TryGetFeatureValue(CommonUsages.gripButton, out rightHandGrip) && rightHandGrip)
            )
        {
            
            Shoot();
        }

        

    }

    private void Shoot()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.transform.forward * firePower);
            Destroy(bullet, 2f);
        }
        
        
    }

   
}
