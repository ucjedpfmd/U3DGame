namespace proto {
	public class m_anima_upgrade_tos : Message
	{
		public int op_type = 0;
		public m_anima_upgrade_tos() {
		}
		public override string getMethodName() {
			return "anima_upgrade";
		}
		public override string getClassName() {
			return "m_anima_upgrade_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
