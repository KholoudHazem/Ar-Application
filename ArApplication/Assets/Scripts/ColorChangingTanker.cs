using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class ColorChangingTanker : MonoBehaviour
    {

        // define red tanker, private camera and a game object to follow camera.
        public GameObject RedTank;
        public GameObject faceCamObj;
        public Camera ARCam;

        // a string variable to store the name of object hit by ray
        string hitObj;

        void Start()
        {

            // hide both tanker and faceCamObj at the beginning
            RedTank.SetActive(false);
            faceCamObj.SetActive(false);

        }
        void Update()
        {
            // make faceCamObj always facing the cameras dirction
            faceCamObj.transform.LookAt(faceCamObj.transform.position + ARCam.transform.rotation * Vector3.forward,
            ARCam.transform.rotation * Vector3.up);

        // detect touches on camera
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {

                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;
                // check if ray hit an object 
                if (Physics.Raycast(ray, out hit))
                {

                    // store the name of object hit by ray 
                    hitObj = hit.transform.name;

                    // depending on the name of object hit show/hide the red tanker and the precentage text
                    switch (hitObj)
                    {
                        case "tanker":

                            // to show red tanker
                            RedTank.SetActive(true);

                            // activate object
                            faceCamObj.SetActive(true);
                           
                            break;
                        case "red tanker":

                            // hide red tanker
                            RedTank.SetActive(false);

                            // hide object
                            faceCamObj.SetActive(false);
                            break;
                        default:
                            break;
                    }
                }


            }
        }
    }