using module.scene.tile;
using proto;
namespace module.scene.utils
{
	class ConvertMath
	{
        		/**
		 * 将p_map_tile路径转为Pt路径
		 * @param arr
		 * @return
		 *
		 */
		public static Pt[] walkPath_pt(object[] arr) {
            Pt[] ptArr = new Pt[arr.Length];
			for (int i = 0; i < arr.Length; i++) {
				int tx = PosUtil.getTx((int)arr[i]);
				int ty = PosUtil.getTy((int)arr[i]);
				int tz = PosUtil.getTz((int)arr[i]);
				Pt pt = new Pt(tx, ty, tz);
                ptArr[i] = pt;
			}
			return ptArr;
		}
	}


}
