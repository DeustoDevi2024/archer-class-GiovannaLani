using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light directional;
    public Light torch;
    // Start is called before the first frame update
    void Start()
    {
        directional.enabled = false;
        torch.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
