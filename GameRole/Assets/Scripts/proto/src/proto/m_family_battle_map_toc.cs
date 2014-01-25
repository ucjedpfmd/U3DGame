namespace proto {
	public class m_family_battle_map_toc : Message
	{
		public object[] monster_list;
		public m_family_battle_map_toc() {
		}
		public override string getMethodName() {
			return "family_battle_map";
		}
		public override string getClassName() {
			return "m_family_battle_map_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"monster_list", "array", "p_key_value"}};
		}
	}
}
