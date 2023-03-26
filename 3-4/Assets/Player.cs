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
        // 이동처리
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


        
        // 발사체
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 발사체를 복사해서 움직이게 처리
            //GameObject.Instantiate(  );

            GameObject cloneobj = GameObject.Instantiate(CopyObj);
            cloneobj.transform.position = transform.position;

            Shoot cloneshot = cloneobj.GetComponent<Shoot>();
            cloneshot.ShotSpeed = 5;

        }

        // 이동처리
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

    // 이동처리
    // 발사처리
    void Start()
    {
        
    }

    public float MoveSpeed = 1;
    public GameObject CopyObj = null;

    void Update()
    {
        // 이동처리
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


        
        // 발사체
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // 발사체를 복사해서 움직이게 처리
            //GameObject.Instantiate(  );

            GameObject cloneobj = GameObject.Instantiate( CopyObj );
            cloneobj.transform.position = transform.position;

        }

        // 이동처리
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