namespace proto {
	public class p_equip_stone : Message
	{
		public int type_id = 0;
		public bool bind = true;
		public p_equip_stone() {
		}
		public override string getClassName() {
			return "p_equip_stone";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"bind", "bool", "null"}};
		}
	}
}
