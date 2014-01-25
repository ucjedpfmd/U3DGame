namespace proto {
	public class m_couple_on_hook_tos : Message
	{
		public int op_type = 0;
		public m_couple_on_hook_tos() {
		}
		public override string getMethodName() {
			return "couple_on_hook";
		}
		public override string getClassName() {
			return "m_couple_on_hook_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
