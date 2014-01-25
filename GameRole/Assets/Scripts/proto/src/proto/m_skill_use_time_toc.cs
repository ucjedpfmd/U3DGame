namespace proto {
	public class m_skill_use_time_toc : Message
	{
		public object[] skill_time;
		public int server_time = 0;
		public m_skill_use_time_toc() {
		}
		public override string getMethodName() {
			return "skill_use_time";
		}
		public override string getClassName() {
			return "m_skill_use_time_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"skill_time", "array", "p_skill_time"},new string[] {"server_time", "int", "null"}};
		}
	}
}
