namespace proto {
	public class m_role_enemy_change_toc : Message
	{
		public double role_id = 0;
		public object[] new_enemys;
		public m_role_enemy_change_toc() {
		}
		public override string getMethodName() {
			return "role_enemy_change";
		}
		public override string getClassName() {
			return "m_role_enemy_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"new_enemys", "array", "p_role_enemy"}};
		}
	}
}
