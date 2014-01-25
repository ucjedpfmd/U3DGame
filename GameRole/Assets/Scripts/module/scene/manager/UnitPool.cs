using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using module.scene.sceneUnit.avatar;
using module.scene.sceneUnit;
namespace module.scene.manager
{
	class UnitPool
	{
        private static List<Monster> monsterPool = new List<Monster>();
       // private static List<Role> rolePool = new List<Role>();
        //private static Monster[] petPool = new Monster[120];

		private static MyRole myRole;
		//private static var myPet:MyPet;

		public UnitPool() {
		}

		public static MyRole getMyRole() {
			if (myRole == null) {
				myRole = new MyRole();
			}
			return myRole;
		}

		public static Monster getMonster() {
			if (monsterPool.Count > 0) {
                Monster m = monsterPool.ElementAt(0);
                monsterPool.RemoveAt(0);
                return m;
			}
			return new Monster();
		}

		public static void disposeMonster(Monster m) {
			if (monsterPool.Count < 120) {
				monsterPool.Add(m);
			}
		}

		public static List<Monster> MonsterPool() {
			return monsterPool;
		}

		public static int MonsterPoolNum {
            get{return monsterPool.Count;}
		}
	}
}
