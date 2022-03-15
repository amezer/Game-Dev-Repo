using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Gun : MonoBehaviour
{
    public SteamVR_Action_Boolean fireAction;
    public GameObject bullet;
    public Transform barrelPivot;
    public float shootingSpeed = 1;
    private Interactable interactable;
    // Start is called before the first frame update
    private void Start() {
        interactable = GetComponent<Interactable>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("fire");
            Fire();
        }
        // if(interactable.attachedToHand != null){
        //     SteamVR_Input_Sources source = interactable.attachedToHand.handType;
        //     if (fireAction[source].stateDown){
        //         Fire();
        //     }
        // }
    }

    // Update is called once per frame
    void Fire()
    {
        Debug.Log("Fire");
        Rigidbody bulletrb = Instantiate(bullet, barrelPivot.position, barrelPivot.rotation).GetComponent<Rigidbody>();
        bulletrb.velocity = barrelPivot.forward * shootingSpeed;
    }
}
