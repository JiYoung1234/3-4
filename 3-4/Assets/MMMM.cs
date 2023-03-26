using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMMM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    GameObject Copyobj = null;
    void CreateMob()
    {
        GameObject cloneobj = GameObject.Instantiate(Copyobj);

        UnityEngine.Random.Range(-17.0f, 17.0f);
        //float randposx=
        //Vector3 randompos = new Vector3(0, 5f, 0);
        //cloneobj.transform.position=
    }
}
