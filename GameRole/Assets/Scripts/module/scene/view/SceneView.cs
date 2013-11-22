using UnityEngine;
using System.Collections;

public class SceneView {

	// Use this for initialization
	GameObject train;
    MyRole myRole;
    MainLight mainLight;
    MainTrrain mainTrrain;
	public void init() {
		initTrain();
        initMyRole();
        initLight();
        //initNPC();
	}
	
	void initTrain() {
	    mainTrrain = new MainTrrain();
        mainTrrain.init();
	}
	
	void initMyRole() {
        myRole = MyRole.getInstance();
        myRole.reset();
        myRole.play(AvatarUtil.ACT_STAND);
        myRole.resetPos(new Vector3(110, 1, 130));
	}

    void initLight()
    {
        mainLight = new MainLight();
        mainLight.init();
    }

    void initNPC()
    {
        Vector3[] arr = new Vector3[4];
        int i;
        for(i=0;i<arr.Length;i++){
            arr[i] = new Vector3();
            if (i == 0)
            {
                 arr[i].x = 100;
                 arr[i].z = 120;
            } 
            else if (i == 1)
            {
                arr[i].x = 120;
                arr[i].z = 120;
            } 
            else if (i == 2)
            {
                arr[i].x = 100;
                arr[i].z = 140;
            } 
            else if (i == 3)
            {
                arr[i].x = 120;
                arr[i].z = 140;
            }
        }
        for (i = 0; i < arr.Length; i++)
        {
            NPC npc = new NPC();
            npc.reset();
            npc.play(AvatarUtil.ACT_STAND);
            npc.resetPos(arr[i]);
        }
    }

    public void resetMyRolePos(Vector3 pos)
    {
        myRole.resetPos(pos);
    }
}
