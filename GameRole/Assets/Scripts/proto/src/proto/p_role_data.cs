namespace proto {
	public class p_role_data : Message
	{
		public double role_id = 0;
		public p_role_base base2 = null;
		public p_role_fight fight = null;
		public p_role_pos pos = null;
		public p_role_attr attr = null;
		public p_role_ext ext = null;
		public p_role_equip equip = null;
		public p_role_data() {
		}
		public override string getClassName() {
			return "p_role_data";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"base2", "p_role_base", "null"},new string[] {"fight", "p_role_fight", "null"},new string[] {"pos", "p_role_pos", "null"},new string[] {"attr", "p_role_attr", "null"},new string[] {"ext", "p_role_ext", "null"},new string[] {"equip", "p_role_equip", "null"}};
		}
	}
}
