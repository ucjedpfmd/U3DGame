namespace proto {
	public class m_pet_embattle_skill_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public double pet_id = 0;
		public int embattle_skill = 0;
		public int silver = 0;
		public m_pet_embattle_skill_toc() {
		}
		public override string getMethodName() {
			return "pet_embattle_skill";
		}
		public override string getClassName() {
			return "m_pet_embattle_skill_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"pet_id", "double", "null"},new string[] {"embattle_skill", "int", "null"},new string[] {"silver", "int", "null"}};
		}
	}
}
