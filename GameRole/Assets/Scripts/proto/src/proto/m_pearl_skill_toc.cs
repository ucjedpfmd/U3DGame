namespace proto {
	public class m_pearl_skill_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int op_type = 0;
		public object[] pearls;
		public int skill_id = 0;
		public m_pearl_skill_toc() {
		}
		public override string getMethodName() {
			return "pearl_skill";
		}
		public override string getClassName() {
			return "m_pearl_skill_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"},new string[] {"pearls", "array", "p_pearl"},new string[] {"skill_id", "int", "null"}};
		}
	}
}
