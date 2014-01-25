namespace proto {
	public class m_firework_toc : Message
	{
		public int type = 0;
		public int last_time = 0;
		public m_firework_toc() {
		}
		public override string getMethodName() {
			return "firework";
		}
		public override string getClassName() {
			return "m_firework_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"last_time", "int", "null"}};
		}
	}
}
