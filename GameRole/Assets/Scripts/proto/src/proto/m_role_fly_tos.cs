namespace proto {
	public class m_role_fly_tos : Message
	{
		public bool fly = true;
		public int pos = 0;
		public m_role_fly_tos() {
		}
		public override string getMethodName() {
			return "role_fly";
		}
		public override string getClassName() {
			return "m_role_fly_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"fly", "bool", "null"},new string[] {"pos", "int", "null"}};
		}
	}
}
