using UnityEngine;
using System.Collections;

public class MyRoleBehaviour : MonoBehaviour
{
    RaycastHit hit;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float sp = 100;
            if (Physics.Raycast(ray, out hit, sp))
            {
                NPCModule.getInstance().closePanel();
                MyRole.getInstance().play(AvatarUtil.ACT_WALK);
            }
        }
        if (hit.point != new Vector3(0, 0, 0) && Vector3.Distance(hit.point, new Vector3(transform.position.x, 0, transform.position.z)) > 1.0)
        {
            turn(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            move();
        }
        else
        {
            MyRole.getInstance().play(AvatarUtil.ACT_STAND);
        }
        //GlobalData.camera.transform.LookAt(transform);
    }
    void turn(Vector3 look)
    {
        Quaternion targetRotation = Quaternion.LookRotation(look - transform.position, Vector3.up);
        float sp = 5;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, (Time.deltaTime * sp));
    }
    void move()
    {
        float sp = 4;
       // GameObject uiroot = GameObject.Find("Main Camera");
        //uiroot.transform.Translate(Vector3.forward * Time.deltaTime * sp);
        transform.Translate(Vector3.forward * Time.deltaTime * sp);
    }


}