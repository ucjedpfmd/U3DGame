using UnityEngine;
using System.Collections;

public class Controller : IAvatarBehaviour
{
	private float time;
	
	void Start ()
	{
		//初始设置人物为站立状态
        SetGameAct(AvatarUtil.ACT_STAND);
		
	}

    override public void runToPoint(Vector3 pointAft){
        
        //目前场景中只有地形
		//其实应当在判断一下当前射线碰撞到的对象是否为地形。
				
		//得到在3D世界中点击的坐标
		point = pointAft;
				
		//设置主角面朝这个点，主角的X 与 Z轴不应当发生旋转，
		//注解1
		transform.LookAt(new Vector3(point.x,transform.position.y,point.z));
				
		//用户是否连续点击按钮
		if(Time.realtimeSinceStartup - time <=0.2f)
		{
			//连续点击 进入奔跑状态
            SetGameAct(AvatarUtil.ACT_RUN);
		}else
		{
			//点击一次只进入走路状态
            SetGameAct(AvatarUtil.ACT_WALK);
		}
				
		//记录本地点击鼠标的时间
		time = Time.realtimeSinceStartup;
    }
	
	void FixedUpdate()
	{
		
		switch(curAct)
		{
            case AvatarUtil.ACT_STAND:
			
			break;
        case AvatarUtil.ACT_WALK:
			//移动主角 一次移动长度为0.05
			Move(0.05f);
			break;

        case AvatarUtil.ACT_RUN:
			//奔跑时移动的长度为0.1
			Move(0.1f);
			break;
		}	
	}
}