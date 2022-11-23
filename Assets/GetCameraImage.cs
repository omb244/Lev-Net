using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCameraImage : MonoBehaviour
{
    WebCamTexture WebCamTexture;
    public string path;
    public RawImage imgDisplayForPhotoSnap;

    // Start is called before the first frame update
    void Start()
    {
        WebCamTexture = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = WebCamTexture;
        WebCamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
