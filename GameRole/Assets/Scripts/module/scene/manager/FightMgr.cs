using module.scene.sceneUnit.avatar;
using proto;
using System;

namespace module.scene.manager
{
    public class FightMgr
    {
        public static Animal getSrc(m_fight_attack_toc fightVO)
        {
			return SceneUnitMgr.getUnit(fightVO.src_id) as Animal;
		}

        public static Animal[] getDest(m_fight_attack_toc fightVO)
        {
			Animal[] dests = new Animal[fightVO.result.Length];
			p_attack_result result;
			Animal dest;
			int leftHP;
            for (int i = fightVO.result.Length - 1; i >= 0; i--)
            {
				result = fightVO.result[i] as p_attack_result;
				dest = SceneUnitMgr.getUnit(result.dest_id) as Animal;
				if (dest != null) {
					dests[i] = dest;
				}
			}
			return dests;
		}
    }
}
