using UnityEngine;

public class RaycastAction : MonoBehaviour
{
    public Camera mainCam;
    public LayerMask layerMask; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            FireRaycast(); 
        }
    }

    private void FireRaycast() 
    {
        RaycastHit hit;

        if (Physics.Raycast(mainCam.transform.position, transform.forward, out hit, 10f, layerMask))
        {
            Debug.Log("Did hit: " + hit);
            Debug.DrawRay(mainCam.transform.position, transform.forward, Color.red);
        }
        else
        {
            Debug.DrawRay(mainCam.transform.position, transform.forward, Color.green);
        }
    }
}
