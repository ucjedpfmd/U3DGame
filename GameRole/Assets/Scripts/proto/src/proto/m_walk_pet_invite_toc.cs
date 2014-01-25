namespace proto {
	public class m_walk_pet_invite_toc : Message
	{
		public int op_type = 0;
		public double invite_role_id = 0;
		public string invite_name = null;
		public m_walk_pet_invite_toc() {
		}
		public override string getMethodName() {
			return "walk_pet_invite";
		}
		public override string getClassName() {
			return "m_walk_pet_invite_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"invite_role_id", "double", "null"},new string[] {"invite_name", "string", "null"}};
		}
	}
}
