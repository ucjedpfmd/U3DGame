namespace proto {
	public class p_role_equip : Message
	{
		public double role_id = 0;
		public object[] equips;
		public p_role_equip() {
		}
		public override string getClassName() {
			return "p_role_equip";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"equips", "array", "p_goods"}};
		}
	}
}
