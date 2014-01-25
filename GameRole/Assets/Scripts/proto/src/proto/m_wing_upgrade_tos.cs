namespace proto {
	public class m_wing_upgrade_tos : Message
	{
		public int type_id = 0;
		public bool auto_buy = true;
		public int times = 1;
		public m_wing_upgrade_tos() {
		}
		public override string getMethodName() {
			return "wing_upgrade";
		}
		public override string getClassName() {
			return "m_wing_upgrade_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"auto_buy", "bool", "null"},new string[] {"times", "int", "null"}};
		}
	}
}
