namespace proto {
	public class m_battle_sign_tos : Message
	{
		public int op_type = 0;
		public m_battle_sign_tos() {
		}
		public override string getMethodName() {
			return "battle_sign";
		}
		public override string getClassName() {
			return "m_battle_sign_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
