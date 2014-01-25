namespace proto {
	public class m_family_pet_embattle_invite_toc : Message
	{
		public double invite_role_id = 0;
		public string invite_name = null;
		public m_family_pet_embattle_invite_toc() {
		}
		public override string getMethodName() {
			return "family_pet_embattle_invite";
		}
		public override string getClassName() {
			return "m_family_pet_embattle_invite_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"invite_role_id", "double", "null"},new string[] {"invite_name", "string", "null"}};
		}
	}
}
