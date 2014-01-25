namespace proto {
	public class m_world_boss_unlock_toc : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int boss_id = 0;
		public int open_level = 0;
		public m_world_boss_unlock_toc() {
		}
		public override string getMethodName() {
			return "world_boss_unlock";
		}
		public override string getClassName() {
			return "m_world_boss_unlock_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"boss_id", "int", "null"},new string[] {"open_level", "int", "null"}};
		}
	}
}
