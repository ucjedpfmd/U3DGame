namespace proto {
	public class p_battle_attr_change : Message
	{
		public int change_type = 0;
		public double change_value = 0;
		public p_battle_attr_change() {
		}
		public override string getClassName() {
			return "p_battle_attr_change";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"change_type", "int", "null"},new string[] {"change_value", "double", "null"}};
		}
	}
}
