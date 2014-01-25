namespace module.scene.utils
{
	class PosUtil
	{
        public static int getTx(int value) {
			return value & 0x1FF;
		}

		public static int getTy(int value) {
			return (value >> 18) & 0x1FF;
		}

		public static int getTz(int value) {
			return (value >> 9) & 0x1FF;
		}

		public static int getDir(int value) {
			return (value >> 27) & 0x1FF;
		}

		public static int getPos(int tx, int ty, int dir = 0, int tz = 0) {
			return (dir << 27) + (tz << 9) + (ty << 18) + tx;
		}

		public static int resetTxTy(int pos, int tx, int ty) {
			int dir = getDir(pos);
			return getPos(tx, ty, dir);
		}

        public static int resetDir(int pos, int dir)
        {
			int tx = getTx(pos);
			int ty = getTy(pos);
			return getPos(tx, ty, dir);
		}
	}
}
