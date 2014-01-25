namespace proto {
	public class m_pearl_skill_tos : Message
	{
		public int op_type = 0;
		public int load_pos = 0;
		public m_pearl_skill_tos() {
		}
		public override string getMethodName() {
			return "pearl_skill";
		}
		public override string getClassName() {
			return "m_pearl_skill_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"load_pos", "int", "null"}};
		}
	}
}
