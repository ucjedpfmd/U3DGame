namespace proto {
	public class m_marry_divorce_info_toc : Message
	{
		public double target_id = 0;
		public int divorce_time = 0;
		public bool is_divorce = true;
		public m_marry_divorce_info_toc() {
		}
		public override string getMethodName() {
			return "marry_divorce_info";
		}
		public override string getClassName() {
			return "m_marry_divorce_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"target_id", "double", "null"},new string[] {"divorce_time", "int", "null"},new string[] {"is_divorce", "bool", "null"}};
		}
	}
}
