namespace proto {
	public class m_family_merge_merge_tos : Message
	{
		public double family_id = 0;
		public object[] del_roles;
		public object[] del_roles2;
		public m_family_merge_merge_tos() {
		}
		public override string getMethodName() {
			return "family_merge_merge";
		}
		public override string getClassName() {
			return "m_family_merge_merge_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"family_id", "double", "null"},new string[] {"del_roles", "array", "double"},new string[] {"del_roles2", "array", "double"}};
		}
	}
}
