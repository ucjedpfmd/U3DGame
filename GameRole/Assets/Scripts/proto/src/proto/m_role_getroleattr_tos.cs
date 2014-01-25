namespace proto {
	public class m_role_getroleattr_tos : Message
	{
		public double role_id = 0;
		public bool is_check = false;
		public m_role_getroleattr_tos() {
		}
		public override string getMethodName() {
			return "role_getroleattr";
		}
		public override string getClassName() {
			return "m_role_getroleattr_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"is_check", "bool", "null"}};
		}
	}
}
