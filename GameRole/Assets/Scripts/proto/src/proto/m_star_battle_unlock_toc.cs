namespace proto {
	public class m_star_battle_unlock_toc : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public m_star_battle_unlock_toc() {
		}
		public override string getMethodName() {
			return "star_battle_unlock";
		}
		public override string getClassName() {
			return "m_star_battle_unlock_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"}};
		}
	}
}
