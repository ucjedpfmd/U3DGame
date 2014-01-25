namespace proto {
	public class m_star_battle_info_change_toc : Message
	{
		public object[] changes;
		public m_star_battle_info_change_toc() {
		}
		public override string getMethodName() {
			return "star_battle_info_change";
		}
		public override string getClassName() {
			return "m_star_battle_info_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"changes", "array", "p_star_battle_info"}};
		}
	}
}
