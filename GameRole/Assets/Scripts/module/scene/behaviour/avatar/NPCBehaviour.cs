using UnityEngine;
using System.Collections;

public class NPCBehaviour : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
        }
        float dis = Vector3.Distance(MyRole.getInstance().pos(), transform.position);
        if (dis < 3)
        {
            if (MyRoleControler.isClickNPC == true)
            {
               // Debug.Log("打开对话框");
                Dispatcher.dispatch(ModuleCommand.OPEN_NPC_PANEL);
                //NPCModule.getInstance().openPanel();
            }
            Debug.Log("CLick" + MyRoleControler.isClickNPC);
        }
        else
        {
            //Debug.Log("MyRole离我还有"+dis);
        }
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MyRoleControler.isClickNPC = true;
        }
        else
        {
            
        }
    }

}