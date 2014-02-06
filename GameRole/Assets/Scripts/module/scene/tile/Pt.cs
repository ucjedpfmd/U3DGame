namespace module.scene.tile
{
	public class Pt
	{
        public double x;
        public double y;
        public double z;

        public Pt(double x = 0, double y = 0, double z = 0)
        {
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static bool isEqual(Pt pt1, Pt pt2) {
			if (pt1 == null || pt2 == null) {
				return false;
			}
			if (pt1.x != pt2.x || pt1.z != pt2.z) {
				return false;
			}
			return true;
		}

		public string key {
          get {return this.x + '|' + this.y + '|' + this.z.ToString();}
		}

		public string toString() {
            return "(" + this.x + ',' + this.y + ',' + this.z + ")";
		}
	}
}
