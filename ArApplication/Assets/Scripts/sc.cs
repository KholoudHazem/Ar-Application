using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//using System.Collections;

public class sc : MonoBehaviour {

    public GameObject RedTank, precText;
    string hitObj;
   
    void Start()
    {
      

        // set it active
        RedTank.SetActive(false);
        precText.SetActive(false);
    }
    void Update()
    {
        if(Input.touchCount>0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit)){
                

                hitObj = hit.transform.name;
               
                switch(hitObj)
                {
                    case "tanker":
                        RedTank.SetActive(true);
                        precText.SetActive(true);
                        break;
                    case "red tanker":
                        RedTank.SetActive(false);
                        precText.SetActive(false);
                        break;
                    default:
                        break;
                }
            }
         
            
        }
    }
}
