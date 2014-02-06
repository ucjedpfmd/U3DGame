using System;
using UnityEngine;

namespace module.scene.sceneUnit.avatar
{
    public class Animal : SceneUnit
    {
        protected Vector3 point;
        protected string curAct;
        protected float time;

        public Animal()
	    {

	    }

        public virtual void runToPoint(Vector3 pointAft)
        {

        }

        protected virtual void loop(params object[] arg)
        {

            switch (curAct)
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

        protected virtual void SetGameAct(string act)
        {
            switch (act)
            {
                case AvatarUtil.ACT_STAND:
                    //播放站立动画
                    point = myObj.transform.position;
                    avatar.body.animation.Play(AvatarUtil.ACT_STAND);
                    break;
                case AvatarUtil.ACT_WALK:
                    //播放行走动画
                    avatar.body.animation.Play(AvatarUtil.ACT_WALK);
                    break;
                case AvatarUtil.ACT_RUN:
                    //播放奔跑动画
                    avatar.body.animation.Play(AvatarUtil.ACT_WALK);
                    break;
            }
            curAct = act;
        }

        protected virtual void Move(float speed)
        {
            float dis = Mathf.Abs(Vector3.Distance(point, myObj.transform.position));
            //主角没到达目标点时，一直向该点移动
            if (dis >= 1.0f)
            {
                //得到角色控制器组件
                CharacterController controller = myObj.GetComponent<CharacterController>();
                //注解3 限制移动
                Vector3 v = Vector3.ClampMagnitude(point - myObj.transform.position, speed);
                //可以理解为主角行走或奔跑了一步
                v.y = 0;
                controller.Move(v);
            }
            else
            {
                //到达目标时 继续保持站立状态。
                SetGameAct(AvatarUtil.ACT_STAND);
                Debug.Log("怪物：" + id + "当前位置：" + myObj.transform.position.ToString());
            }
        }

        public virtual void attack(string act, int dir) {
            this.play(act, dir);
		}

        override public void remove()
        {
            SetGameAct(AvatarUtil.ACT_STAND);
            base.remove();
        }
    }
}
