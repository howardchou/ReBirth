using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardClose : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.One)){
            Panel.SetActive(false);
        }
    }
}
