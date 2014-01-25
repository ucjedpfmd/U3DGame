namespace proto {
	public class m_pet_skill_extend_toc : Message
	{
		public int err_code = 0;
		public double pet_id = 0;
		public int num = 0;
		public m_pet_skill_extend_toc() {
		}
		public override string getMethodName() {
			return "pet_skill_extend";
		}
		public override string getClassName() {
			return "m_pet_skill_extend_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"pet_id", "double", "null"},new string[] {"num", "int", "null"}};
		}
	}
}
