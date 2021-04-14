using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setDissolve : MonoBehaviour
{
    public float dissolveTime;
    public Shader dissolveShader;
    Material mat;
    public bool shade;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        shade = false;
        if (mat != null)
            mat.shader = dissolveShader;
    }

    // Update is called once per frame
    void Update()
    {
        if (shade)
        {
            shade = false;
            startDissolve();
        }
    }

    public void startDissolve()
    {
        StartCoroutine(dissolveHelper());
    }

    IEnumerator dissolveHelper()
    {
        float dissolve = 0;
        while (dissolve <= 1)
        {
            mat.SetFloat("_DissolveAmmount", dissolve + .5f);
            yield return new WaitForSeconds(1f);
            dissolve += 0.1f;
            Debug.LogError("Dissolve " + dissolve);
        }
        
    }
}
