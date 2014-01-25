namespace proto {
	public class m_battle_sign_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public m_battle_sign_toc() {
		}
		public override string getMethodName() {
			return "battle_sign";
		}
		public override string getClassName() {
			return "m_battle_sign_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
