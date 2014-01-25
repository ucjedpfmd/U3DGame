namespace proto {
	public class m_family_qq_operate_tos : Message
	{
		public int op_type = 0;
		public bool sync = true;
		public m_family_qq_operate_tos() {
		}
		public override string getMethodName() {
			return "family_qq_operate";
		}
		public override string getClassName() {
			return "m_family_qq_operate_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"sync", "bool", "null"}};
		}
	}
}
