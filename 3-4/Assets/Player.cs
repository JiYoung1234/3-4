using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float MoveSpeed = 1;
    public GameObject CopyObj = null;
    public 
    // Update is called once per frame
    void Update()
    {
        // �̵�ó��
        if (Input.GetKey(KeyCode.LeftArrow)
            || Input.GetKey(KeyCode.A))
        {
            Vector3 pos = transform.position;
            pos.x -= MoveSpeed * Time.deltaTime;
            this.transform.position = pos;
        }

        if (Input.GetKey(KeyCode.RightArrow)
            || Input.GetKey(KeyCode.D))
        {
            Vector3 pos = transform.position;
            pos.x += MoveSpeed * Time.deltaTime;
            this.transform.position = pos;
        }


        
        // �߻�ü
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �߻�ü�� �����ؼ� �����̰� ó��
            //GameObject.Instantiate(  );

            GameObject cloneobj = GameObject.Instantiate(CopyObj);
            cloneobj.transform.position = transform.position;

            Shoot cloneshot = cloneobj.GetComponent<Shoot>();
            cloneshot.ShotSpeed = 5;

        }

        // �̵�ó��
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Vector3 pos = transform.position;
            pos.x -= MoveSpeed * Time.deltaTime;
            this.transform.position = pos;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Vector3 pos = transform.position;
            pos.x += MoveSpeed * Time.deltaTime;
            this.transform.position = pos;
        }
    }
}
/*
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // �̵�ó��
    // �߻�ó��
    void Start()
    {
        
    }

    public float MoveSpeed = 1;
    public GameObject CopyObj = null;

    void Update()
    {
        // �̵�ó��
        if( Input.GetKey( KeyCode.LeftArrow )
            || Input.GetKey(KeyCode.A) )
        {
            Vector3 pos = transform.position;
            pos.x -= MoveSpeed * Time.deltaTime;
            this.transform.position = pos;
        }

        if (Input.GetKey(KeyCode.RightArrow)
            || Input.GetKey(KeyCode.D) )
        {
            Vector3 pos = transform.position;
            pos.x += MoveSpeed * Time.deltaTime;
            this.transform.position = pos;
        }


        
        // �߻�ü
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // �߻�ü�� �����ؼ� �����̰� ó��
            //GameObject.Instantiate(  );

            GameObject cloneobj = GameObject.Instantiate( CopyObj );
            cloneobj.transform.position = transform.position;

        }

        // �̵�ó��
        if (Input.GetKey(Keycode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Vector3 pos = transform.position;
            pos.x -= MoveSpeed * Time.deltaTime;
            this.transform.position = pos;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Vector3 pos = transform.position;
            pos.x += MoveSpeed * Time.deltaTime;
            this.transform.position = pos;
        }

    }
}*/